using MLP.Network;
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
    public partial class fSettings : Form
    {
        Settings setting  ;
        String linkOld="";
        public fSettings()
        {
            InitializeComponent();

            udLayers.Maximum = 6;
            udLayers.Minimum = 1;

            lstUdLayer.AddRange(new NumericUpDown[] { udL1,udL2,udL3,udL4,udL5,udL6});
            lstlbL.AddRange(new Label[]{lbLay1,lbL2,lbL3,lbL4,lbL5,lbL6});
            for (int i = 0; i < lstlbL.Count; i++)
            {
                lstlbL[i].Visible = false;
                lstUdLayer[i].Visible = false;
            }
        }

        List<NumericUpDown> lstUdLayer = new List<NumericUpDown>();
        List<Label> lstlbL = new List<Label>();
        private void fSettings_Load(object sender, EventArgs e)
        {
            setting = new Settings();
            List<string> fucn = Settings.getAllTranferFunctions();
            foreach (string f in fucn)
            {
                cboxTransferFunction.Items.Add(f);
            }
            udLayers.Value = (int)setting["NumberOfLayers"];
            txtLearningRate.Text = setting["LearningRate"].ToString();
            txtEpochToStop.Text = setting["EpochToStop"] + "";
            txtMomentum.Text = setting["Momentum"] + "";
            txtErrorToStop.Text = setting["ErrorToStop"] + "";
            txtLearningRate.Text = setting["LearningRate"] + "";
            txtLearningRateDownStep.Text = setting["LearningRateDownStep"] + "";
            txtLearningRateUpStep.Text = setting["LearningRateUpStep"] + "";
            txtErrorThresholdPercent.Text = setting["ErrorThresholdPercent"] + "";
            cboxTransferFunction.SelectedIndex = cboxTransferFunction.Items.IndexOf(setting["TransferFunction"]);

            for (int i = 0; i < udLayers.Value; i++)
            {
                lstUdLayer[i].Value = (int)setting["NeuronsOfLayer[" + (i+1) + "]"];
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //linkOld = OpenDialogLoadImage.OpenFile("|*ini");
            
        }

        private void updownNumberOfLayers_ValueChanged(object sender, EventArgs e)
        {
            int layers = (int)udLayers.Value;

            for (int i = 0; i < lstUdLayer.Count; i++)
            {
                lstlbL[i].Visible = false;
                lstUdLayer[i].Visible = false;
            }
            for (int i = 0; i < layers; i++)
            {
                lstlbL[i].Visible = true;
                lstUdLayer[i].Visible = true;
            }

            int NumberOfLayers = int.Parse(setting["NumberOfLayers"]+"");
            if (NumberOfLayers > (int)udLayers.Value)
            {
                for (int i = ((int)udLayers.Value + 1); i <= NumberOfLayers; i++)
                {
                    setting.Remove("NeuronsOfLayer[" + i + "]");
                }
            }

            if (NumberOfLayers < (int)udLayers.Value)
            {
                for (int i = (NumberOfLayers + 1); i <= udLayers.Value; i++)
                {
                    setting["NeuronsOfLayer[" + i + "]"] = 1;
                }
                for (int i = 0; i < layers; i++)
                {
                    lstUdLayer[i].Value = (int)setting["NeuronsOfLayer[" + (i+1) + "]"];
                }
            }
            setting["NumberOfLayers"] = (int)udLayers.Value;
            
        }

        private void cboxTransferFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu lại cấu hình này?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                setting["LearningRate"] = double.Parse(txtLearningRate.Text);
                setting["Momentum"] = double.Parse(txtMomentum.Text);
                setting["EpochToStop"] = int.Parse(txtEpochToStop.Text);
                setting["ErrorToStop"] = double.Parse(txtErrorToStop.Text);
                setting["ErrorThresholdPercent"] = int.Parse(txtErrorThresholdPercent.Text);
                setting["LearningRateUpStep"] = int.Parse(txtLearningRateUpStep.Text);
                setting["LearningRateDownStep"] = int.Parse(txtLearningRateDownStep.Text);
                setting["TransferFunction"] = cboxTransferFunction.Items[cboxTransferFunction.SelectedIndex] + "";
                for (int i = 1; i <= udLayers.Value; i++)
                {
                    setting["NeuronsOfLayer[" + i + "]"] = lstUdLayer[i - 1].Value;
                }

                setting.Save();
            }
        }

        

       

        

        

        
    }
}
