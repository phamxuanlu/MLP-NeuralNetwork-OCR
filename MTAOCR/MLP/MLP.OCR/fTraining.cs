
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
using MLP.Network;
namespace MLP.OCR
{
    public partial class fTraining : Form
    {
        public fTraining()
        {
            InitializeComponent();
            try
            {
                settings = new Settings();
            }
            catch (Exception e)
            {
                string s = e.Message;
            }
            LoadSettings();
        }

        Settings settings;

        private void LoadSettings()
        {
            this.lbMinError.Text ="MinError: "+ settings["ErrorToStop"].ToString();
        }
        private void fTraining_Load(object sender, EventArgs e)
        {
            
        }

        private void Training()
        {
            MLP.Network.MLP mlp = new MLP.Network.MLP(settings);
            //mlp.Training()
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox6_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
