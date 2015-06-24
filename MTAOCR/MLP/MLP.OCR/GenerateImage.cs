using MLP.ImagePreceeding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLP.OCR
{
    public partial class GenerateImage : Form
    {

        private readonly object locker = new object();
        public delegate void DrawBinarizationDelegate(Bitmap bm);
        public GenerateImage()
        {
            InitializeComponent();
        }
        List<char> lstChar = new List<char>();
        List<int> UnicodeValues = new List<int>();
        Dictionary<string, object> Configuration;// = new Dictionary<string, object>();
        private void GenerateImage_Load(object sender, EventArgs e)
        {
            AddChars();
            
            this.udWidth.Value = 15;
            this.udHeight.Value = 20;
            this.udOffsetX.Value = 0;
            this.udOffsetX.Value = 0;
            this.udSize.Value = 10;
            this.udThres.Value = 100;
            this.udThres.Maximum = 255;
            this.udThres.Minimum = 0;
            foreach (FontFamily fm in FontFamily.Families)
            {
                cbFont.Items.Add(fm.Name);
            }
            cbFont.Text = "Tahoma";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void AddChars()
        {
            //for (char c = 'a'; c <= 'z'; c++)
            //{
            //    lstChar.Add(c);
            //}
            //for (char c = 'A'; c <= 'Z'; c++)
            //{
            //    lstChar.Add(c);
            //}
            for (char c = '0'; c <= '9'; c++)
            {
                lstChar.Add(c);
            }
            foreach(char c in lstChar){
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] bytes = UE.GetBytes(c.ToString());
                UnicodeValues.Add(BitConverter.ToInt16(bytes,0));
            }
        }

        private void ReadConfiguration()
        {
            Configuration = new Dictionary<string, object>();
            int width = (int)udWidth.Value;
            int height = (int)udHeight.Value;
            int size = (int)udSize.Value;
            byte thres = (byte)udThres.Value;
            int offsetX = (int)udOffsetX.Value;
            int offsetY = (int)udOffsetY.Value;
            Configuration.Add("Width", width);
            Configuration.Add("Height", height);
            Configuration.Add("Size", size);
            Configuration.Add("Font", cbFont.Text);
            Configuration.Add("Threshold", thres);
            Configuration.Add("OffsetX", offsetX);
            Configuration.Add("OffsetY", offsetY);
            Configuration.Add("FolderName", txtData.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
                ReadConfiguration();;

                Thread t = new Thread(new ThreadStart(Generate));
                t.IsBackground = true;
                t.Start();
        }

        private void Generate()
        {
            try
            {
                lock (locker)
                {
                    int W = (int)(Configuration["Width"]);
                    int H = (int)Configuration["Height"];
                    Font font = new Font(Configuration["Font"].ToString(), 12);
                    Brush br = Brushes.Black;

                    foreach (char c in lstChar)
                    {
                        Bitmap bm = new Bitmap(W, H);
                        Graphics g = Graphics.FromImage(bm);
                        g.FillRectangle(Brushes.White, new Rectangle(0, 0, W, H));
                        //g.DrawString(c.ToString(), font, br, new PointF(0,0));
                        g.DrawString(c.ToString(), font, br, (int)Configuration["OffsetX"], (int)Configuration["OffsetY"]);
                        string fileName = Configuration["FolderName"] + "\\"
                            + ((c.ToString() == c.ToString().ToUpper()) ? c.ToString() + "-UpperCase" : c.ToString() + "-LowerCase") + "-"
                            + Configuration["Font"]
                            + "-[" + Configuration["OffsetX"] + "."
                            + Configuration["OffsetY"] + "].jpg";

                        MyResizeImage character = new MyResizeImage(bm);
                        bm = character.getImage(new Size(15, 20));
                        bm.Save(fileName);

                        DrawBinarizationDelegate dr = new DrawBinarizationDelegate(DrawBinarization);
                        Action update = new Action(() => { picImage.Image = bm; });
                        if (picImage.InvokeRequired)
                        {
                            picImage.BeginInvoke(update);
                            pictureBox1.BeginInvoke(dr, bm);
                        }
                        else
                        {
                            update();
                            dr(bm);
                        }
                        Thread.Sleep(200);
                    }
                }
            }
            catch (Exception ex) { }
        }


        //private Bitmap Normalize(Bitmap bm)
        //{
        //    Bitmap ret;
        //    BitmapData bmDt = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height),ImageLockMode.ReadOnly,PixelFormat.Format24bppRgb);

        //    int offset = bmDt.Stride - bm.Width * 3;
        //    int top_left_X=0;
        //    int top_left_Y = 0;
        //    int bottom_right_X = bm.Width;
        //    int bottom_right_Y = bm.Height;
        //    unsafe
        //    {
        //        byte* p = (byte*)bmDt.Scan0;

        //        for (int i = 0; i < bm.Height; i++)
        //        {
        //            for (int j = 0; j < bm.Width; j++)
        //            {
        //                byte grayscale = (byte)(0.11 * p[0] + 0.59 * p[1] + 0.3 * p[2]);
        //                if (grayscale >= 127)
        //                {
        //                    top_left_X = j;
        //                    top_left_Y = i;
        //                }
        //                p+=3;
        //            }
        //            p+=offset;
        //        }

                
        //        for (int i = bm.Height - 1; i >= 0; i--)
        //        {
        //            for (int j = bm.Width; j >= 0; j--)
        //            {
        //                p = (byte*)bmDt.Scan0;

        //                p += (i * (bm.Width * 3 + offset) + j * 3);
        //                byte grayscale = (byte)(0.11 * p[0] + 0.59 * p[1] + 0.3 * p[2]);
        //                if (grayscale >= 127)
        //                {
        //                    bottom_right_X = j;
        //                    bottom_right_Y = i;
        //                }
        //            }
        //        }

        //    }
        //}

        private void DrawBinarization(Bitmap bm)
        {
            //Graphics g = pictureBox1.CreateGraphics();
            Bitmap nBM = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(nBM);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            int W = (int)Configuration["Width"];
            int H = (int)Configuration["Height"];
            BitmapHelper bmh = new BitmapHelper(bm);
            bmh.Binarization((byte)Configuration["Threshold"], true);
            double[] binaryArray = bmh.ToBinaryArray();
            int j = 0;
            double ratioX = pictureBox1.Width / W;
            double ratioY = pictureBox1.Height / H;
            Pen p = new Pen(Brushes.Blue,2.0f);
            Font f = new Font("Tahoma",1.0f);
            for (int i = 0; i < binaryArray.Length; i++)
            {
                if (i%W == 0&&i!=0)
                {
                    j++;
                }
                int RealW = i - j * W;
                if (binaryArray[i] > 0)
                {
                    g.FillRectangle(Brushes.Gray, new Rectangle((int)(RealW * ratioX), (int)(j * ratioY), (int)ratioX, (int)ratioY));
                    g.DrawString("1", f, Brushes.Blue, (int)(RealW * ratioX), (int)(j * ratioY));
                    //g.DrawRectangle(p, new Rectangle((int)(RealW * ratioX), (int)(j * ratioY), (int)ratioX, (int)ratioY));
                }else
                {
                    g.DrawString("0", f, Brushes.Blue, (int)(RealW * ratioX), (int)(j * ratioY));
                }
            }
            pictureBox1.Image = nBM;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtData.Text = f.SelectedPath;
            }
        }
    }
}
