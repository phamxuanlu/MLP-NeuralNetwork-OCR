using MLP.ImagePreceeding;
using MLP.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLP.OCR
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        FolderBrowserDialog fLink2Learn;

        MLP.Network.MLP mlp;
        Stopwatch s;
        private void fMain_Load(object sender, EventArgs e)
        {
            //FolderBrowserDialog f = new FolderBrowserDialog();
            //if (f.ShowDialog() != DialogResult.OK)
            //    return;

        }

        private void UpdateUI(double Error, double EPoch, double ValidError)
        {
            this.lbEpoch.Text = EPoch.ToString();
            this.lbError.Text = Error.ToString();
            this.lbValidErr.Text = ValidError.ToString();
            this.lbTime.Text = s.Elapsed.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            if (mlp == null)
            {
                mlp = new Network.MLP(settings);
            }
            else
            {
                mlp.Epoch = 0; // trong trường hợp đã có mạng sẵn và nạp lại từ file FileSave.data -- mục đích để cho huấn luyện tiếp nếu Sai số của mạng chưa nhỏ hơn sai số cho phép
                //mlp.CreateNew_errorEachEpoch_errorOnValidation();
                //private List<double> _errorEachEpoch;
                //private List<double> _errorOnValidation;
                // còn 2 cái này thì tôi thấy nên cho khởi tạo lại (new List) -- do khi đọc từ file thì _errorEachEpoch _errorOnValidation đc nạp lại => xóa đi để lưu lại cái mới khi cho huấn luyện tiếp

            }
            s = new Stopwatch();
            Thread thr = new Thread(new ThreadStart(MLPExecute));
            thr.IsBackground = true;
            thr.Start();

            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            tm.Interval = 10;
            tm.Tick += (o, ev) => { UpdateUI(mlp.Error, mlp.Epoch,0/*mlp.ValidationError*/); };
            tm.Start();

        }
        List<TrainingData> lst;
        List<TrainingData> validData;
        private void MLPExecute()
        {
            ImageData id = new ImageData();
            lst = id.ReadFolder(txtURL.Text);
            validData = id.ReadFolder(txtValid.Text);

            Action<List<TrainingData>> act = new Action<List<TrainingData>>((lstTD) => { lstTD.ForEach(x => { comboBox1.Items.Add(x.C); }); });
            if (comboBox1.InvokeRequired)
            {
                comboBox1.BeginInvoke(act, lst);
            }
            else
            {
                act(lst);
            }

            //mlp.updateUI = new Network.UpdateUI(UpdateUI);

            s.Start();
            mlp.Training(lst, validData);
            s.Stop();

            string time = s.Elapsed.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateImage g = new GenerateImage();
            g.Show();
        }

        private string Cal(double[] t)
        {
            double[] p = mlp.GetNetworkOutput(t);
            byte[] b = new byte[2];
            for (int i = 0; i < p.Length; i++)
            {
                bool tt = true;
                if (p[i] < 0.2)
                    tt = false;
                b[(int)i / 8] = BitHelper.SetBit(b[(int)i / 8], (byte)(i % 8), tt);
            }
            return Encoding.Unicode.GetString(b);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrainingData tr = lst.Find(x => (x.C.ToString() == comboBox1.SelectedItem.ToString()));
            lbResult.Text = "Result: " + Cal(tr.p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fLink2Learn = new FolderBrowserDialog();
            if (fLink2Learn.ShowDialog() != DialogResult.OK)
                return;
            txtURL.Text = fLink2Learn.SelectedPath;
        }

        private void btnTestImage_Click(object sender, EventArgs e)
        {
            Bitmap temp = OpenDialogLoadImage.OpenDialog(picboxImageSource);
            if (temp != null)
            {
                try
                {
                    BitmapHelper bmHelp = new BitmapHelper(temp);

                    bmHelp.Binarization(160, true); // giống vs ngưỡng trong file ImageData.cs -- đặt cùng ngưỡng để chuyển thành ảnh nhị phân
                    MyDrawing.DrawBinarization(bmHelp.ToBinaryArray(),picBinary,temp.Width,temp.Height);
                    lbResult.Text = "Result: " + Cal(bmHelp.ToBinaryArray());
                }
                catch (Exception ex) { };
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSettings fst = new fSettings();
            fst.Show();
        }

        private void generateImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateImage gi = new GenerateImage();
            gi.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtValid.Text = f.SelectedPath;
            }
        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("TrainedData.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                mlp = (MLP.Network.MLP)bf.Deserialize(fs);
                fs.Close();
                MessageBox.Show("Loaded");
            }
            catch (Exception ex) { }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("TrainedData.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, mlp);
                fs.Close();
                MessageBox.Show("Saved");
            }
            catch (Exception ex) { }
        }

        private void errorGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorChart er = new ErrorChart();
            if (this.mlp != null)
            {
                er.mlp = this.mlp;
                er.DrawChart(null, "", mlp.ErrorEachEpoch, Color.Red);
                er.DrawChart(null, "", mlp.ErrorOnValidationData, Color.DarkCyan);
                er.Show();
            }
        }

        private void statisticalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStatistical fsta = new fStatistical();
            fsta.Show();
        }

    }
}
