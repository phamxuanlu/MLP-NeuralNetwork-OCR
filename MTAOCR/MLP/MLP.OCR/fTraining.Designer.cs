namespace MLP.OCR
{
    partial class fTraining
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picTarget = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picBinarization = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDataDir = new System.Windows.Forms.TextBox();
            this.lbEta = new System.Windows.Forms.Label();
            this.lbMaxEpoch = new System.Windows.Forms.Label();
            this.lbMinError = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBinarization)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picTarget);
            this.groupBox3.Location = new System.Drawing.Point(544, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target";
            // 
            // picTarget
            // 
            this.picTarget.BackColor = System.Drawing.Color.White;
            this.picTarget.Location = new System.Drawing.Point(6, 19);
            this.picTarget.Name = "picTarget";
            this.picTarget.Size = new System.Drawing.Size(251, 208);
            this.picTarget.TabIndex = 1;
            this.picTarget.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picBinarization);
            this.groupBox4.Location = new System.Drawing.Point(275, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 233);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Binarization";
            // 
            // picBinarization
            // 
            this.picBinarization.BackColor = System.Drawing.Color.White;
            this.picBinarization.Location = new System.Drawing.Point(6, 19);
            this.picBinarization.Name = "picBinarization";
            this.picBinarization.Size = new System.Drawing.Size(251, 208);
            this.picBinarization.TabIndex = 1;
            this.picBinarization.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picImage);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 233);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.White;
            this.picImage.Location = new System.Drawing.Point(6, 19);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(251, 208);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.txtDataDir);
            this.groupBox5.Controls.Add(this.lbEta);
            this.groupBox5.Controls.Add(this.lbMaxEpoch);
            this.groupBox5.Controls.Add(this.lbMinError);
            this.groupBox5.Location = new System.Drawing.Point(13, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(402, 161);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = ". . .";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDataDir
            // 
            this.txtDataDir.Location = new System.Drawing.Point(12, 88);
            this.txtDataDir.Name = "txtDataDir";
            this.txtDataDir.Size = new System.Drawing.Size(204, 20);
            this.txtDataDir.TabIndex = 4;
            // 
            // lbEta
            // 
            this.lbEta.AutoSize = true;
            this.lbEta.Location = new System.Drawing.Point(131, 44);
            this.lbEta.Name = "lbEta";
            this.lbEta.Size = new System.Drawing.Size(26, 13);
            this.lbEta.TabIndex = 3;
            this.lbEta.Text = "Eta:";
            // 
            // lbMaxEpoch
            // 
            this.lbMaxEpoch.AutoSize = true;
            this.lbMaxEpoch.Location = new System.Drawing.Point(131, 20);
            this.lbMaxEpoch.Name = "lbMaxEpoch";
            this.lbMaxEpoch.Size = new System.Drawing.Size(61, 13);
            this.lbMaxEpoch.TabIndex = 2;
            this.lbMaxEpoch.Text = "MaxEpoch:";
            // 
            // lbMinError
            // 
            this.lbMinError.AutoSize = true;
            this.lbMinError.Location = new System.Drawing.Point(9, 20);
            this.lbMinError.Name = "lbMinError";
            this.lbMinError.Size = new System.Drawing.Size(49, 13);
            this.lbMinError.TabIndex = 1;
            this.lbMinError.Text = "MinError:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(421, 278);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(407, 161);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Epoch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Error:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Output: ";
            // 
            // fTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 492);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTraining";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "fTraining";
            this.Load += new System.EventHandler(this.fTraining_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBinarization)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picTarget;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picBinarization;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbEta;
        private System.Windows.Forms.Label lbMaxEpoch;
        private System.Windows.Forms.Label lbMinError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDataDir;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}