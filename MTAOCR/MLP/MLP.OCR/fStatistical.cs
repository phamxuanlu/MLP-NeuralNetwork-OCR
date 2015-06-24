using MLP.Network;
using MLP.OCR.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLP.OCR
{
    public partial class fStatistical : Form
    {
        public fStatistical()
        {
            InitializeComponent();
        }

        MLP.Network.MLP mlp;

        List<StatisticalData> _thongKe1;
        List<StatisticalData> _thongKe2;
        List<StatisticalData> _thongKe3;

        private void fStatistical_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("TrainedData.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                mlp = (MLP.Network.MLP)bf.Deserialize(fs);
                fs.Close();
                MessageBox.Show("Loaded MLP");
            }
            catch (Exception ex) { MessageBox.Show("Error"); }
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtLink1.Text = f.SelectedPath;
                _thongKe1 = new List<StatisticalData>();
                try
                {
                    ThongKe(_thongKe1, txtLink1.Text, dataGVDetail1, dataGVCorrectFile1, dataGVErrorFile1, lbPercentCorrect1);
                }
                catch (Exception ex) { }
            }
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtLink2.Text = f.SelectedPath;
                _thongKe2 = new List<StatisticalData>();
                try
                {
                    ThongKe(_thongKe2, txtLink2.Text, dataGVDetail2, dataGVCorrectFile2, dataGVErrorFile2, lbPercentCorrect2);
                }
                catch (Exception ex) { }
            }
        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtLink3.Text = f.SelectedPath;
                _thongKe3 = new List<StatisticalData>();
                try
                {
                    ThongKe(_thongKe3, txtLink3.Text, dataGVDetail3, dataGVCorrectFile3, dataGVErrorFile3, lbPercentCorrect3);
                }
                catch (Exception ex) { }
            }
        }

        public void ThongKe(List<StatisticalData> _thongKe, string linkFolder, DataGridView dataGVDetail, DataGridView dataGVCorrect, DataGridView dataGVError, Label lbPercentCorrect)
        {
            ImageData imageData = new ImageData();
            string character="";
            int index;
            List<TrainingData> trainingData= imageData.ReadFolder(linkFolder);
            foreach (TrainingData training in trainingData)
            {
                 character= training.C[0]+"";
                 index=_thongKe.FindIndex(x=>x.Name==character);
                if (index>=0)
                {
                    _thongKe[index].Count++;
                }
                else
                {
                    StatisticalData temp = new StatisticalData(character);
                    temp.Count = 1;
                    _thongKe.Add(temp);
                    index = _thongKe.Count - 1;
                }


                if (character == Cal(training.p))
                {
                    _thongKe[index].CountCorrect++;
                    _thongKe[index]._listCorrect.Add(training.fileName);
                }
                else
                {
                    _thongKe[index]._listError.Add(training.fileName);
                }
                
            }
            _thongKe.OrderBy(x => x.Name);

            dataGVDetail.Rows.Clear();
            dataGVCorrect.Rows.Clear();
            dataGVError.Rows.Clear();

            int TotalCount = 0, TotalCountCorrect = 0;

            foreach (StatisticalData StaData in _thongKe)
            {

                TotalCount += StaData.Count;
                TotalCountCorrect += StaData.CountCorrect;

                foreach (string correct in StaData._listCorrect)
                {
                    dataGVCorrect.Rows.Add(correct);
                }

                foreach (string error in StaData._listError)
                {
                    dataGVError.Rows.Add(error);
                }

           


                dataGVDetail.Rows.Add(new string[] {
                    StaData.Name,
                    StaData.Count+"",
                    StaData.CountCorrect+"",
                    StaData.getPercentCorrect()+"" });
            }

            lbPercentCorrect.Text = Math.Round((TotalCountCorrect / (double)TotalCount) * 100,2) + "";

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

      

       

       
    }
}
