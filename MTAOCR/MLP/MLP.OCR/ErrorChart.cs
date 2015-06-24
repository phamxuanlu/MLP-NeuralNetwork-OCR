using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLP.OCR
{
    public partial class ErrorChart : Form
    {
        public ErrorChart()
        {
            InitializeComponent();
            DrawAxis(pictureBox1, "Error", "Epoch");
        }

        public MLP.Network.MLP mlp;

        double maxError = 0;
        double pixelStep = 0;
        private void ErrorChart_Load(object sender, EventArgs e)
        {
            Timer tm = new Timer();
            tm.Interval = 100;
            tm.Tick += (o, ev) => {
                            DrawChart(null, "", mlp.ErrorEachEpoch, Color.Red);
                            DrawChart(null, "", mlp.ErrorOnValidationData, Color.DarkCyan);
            };

            tm.Start();
        }

        public void DrawAxis(PictureBox p, string XAxisName, string YAxisName)
        {
            Pen pBlue = new Pen(new SolidBrush(Color.Blue),2.0f);
            Font f = new System.Drawing.Font("Tahoma",10.0f,FontStyle.Regular);
            Bitmap bm = new Bitmap(p.Width,p.Height);
            Graphics g = Graphics.FromImage(bm);

            //DrawAxis
            g.DrawLine(pBlue, 40, 40, 40, bm.Height - 40);
            g.DrawLine(pBlue,40,bm.Height-40,bm.Width-40,bm.Height-40);

            //DrawAxisName
            g.DrawString(XAxisName,f,Brushes.Black,45,45);
            g.DrawString(YAxisName, f, Brushes.Black, bm.Width-80, bm.Height-60);

            pictureBox1.Image = bm;
        }

        public void DrawData(double[] data)
        {

        }
        public void DrawChart(PictureBox p,string name, double[] value, Color c)
        {
            if (p == null)
            {
                p = pictureBox1;
            }
            for (int i = 0; i < value.Length; i++)
                maxError = value[i] > maxError ? value[i] : maxError;
            
            pixelStep = (p.Width - 90) / (double)value.Length;
            Pen pen = new Pen(new SolidBrush(c), 2.0f);
            Font f = new System.Drawing.Font("Tahoma", 10.0f, FontStyle.Regular);
            Bitmap bm = new Bitmap(p.Image);
            Graphics g = Graphics.FromImage(bm);

            int maxPixH = bm.Height - 90;
            for (int i = 1; i < value.Length; i++)
            {
                if (value[i] == 0.0)
                    break;
                int x1 = (int)(40 + (i - 1) * pixelStep);
                int y1 = bm.Height - 40 - (int)((value[i - 1] / maxError) * maxPixH);
                int x2 = (int)(40 + i * pixelStep);
                int y2 = bm.Height - 40 - (int)((value[i] / maxError) * maxPixH);
                g.DrawLine(pen, x1, y1, x2, y2);
            }

            p.Image = bm;
        }
    }
}
