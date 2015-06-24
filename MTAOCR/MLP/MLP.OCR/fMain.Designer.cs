namespace MLP.OCR
{
    partial class fMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBinary = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbValidErr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtValid = new System.Windows.Forms.TextBox();
            this.btnTestImage = new System.Windows.Forms.Button();
            this.picboxImageSource = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbEpoch = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.statisticalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBinary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImageSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.trainingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.generateImageToolStripMenuItem,
            this.errorGraphToolStripMenuItem,
            this.statisticalDataToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // generateImageToolStripMenuItem
            // 
            this.generateImageToolStripMenuItem.Name = "generateImageToolStripMenuItem";
            this.generateImageToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.generateImageToolStripMenuItem.Text = "Generate Image";
            this.generateImageToolStripMenuItem.Click += new System.EventHandler(this.generateImageToolStripMenuItem_Click);
            // 
            // errorGraphToolStripMenuItem
            // 
            this.errorGraphToolStripMenuItem.Name = "errorGraphToolStripMenuItem";
            this.errorGraphToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.errorGraphToolStripMenuItem.Text = "Error Graph";
            this.errorGraphToolStripMenuItem.Click += new System.EventHandler(this.errorGraphToolStripMenuItem_Click);
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trainingToolStripMenuItem.Text = "Training";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picBinary);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbValidErr);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtValid);
            this.panel1.Controls.Add(this.btnTestImage);
            this.panel1.Controls.Add(this.picboxImageSource);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbResult);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbEpoch);
            this.panel1.Controls.Add(this.lbError);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 508);
            this.panel1.TabIndex = 1;
            // 
            // picBinary
            // 
            this.picBinary.Location = new System.Drawing.Point(689, 219);
            this.picBinary.Name = "picBinary";
            this.picBinary.Size = new System.Drawing.Size(186, 149);
            this.picBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBinary.TabIndex = 19;
            this.picBinary.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Validation MSE";
            // 
            // lbValidErr
            // 
            this.lbValidErr.AutoSize = true;
            this.lbValidErr.Location = new System.Drawing.Point(336, 150);
            this.lbValidErr.Name = "lbValidErr";
            this.lbValidErr.Size = new System.Drawing.Size(35, 13);
            this.lbValidErr.TabIndex = 17;
            this.lbValidErr.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Validation set:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(807, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtValid
            // 
            this.txtValid.Location = new System.Drawing.Point(640, 10);
            this.txtValid.Name = "txtValid";
            this.txtValid.ReadOnly = true;
            this.txtValid.Size = new System.Drawing.Size(157, 20);
            this.txtValid.TabIndex = 14;
            this.txtValid.Text = "D:\\imageOCR\\Validation";
            // 
            // btnTestImage
            // 
            this.btnTestImage.Location = new System.Drawing.Point(689, 116);
            this.btnTestImage.Name = "btnTestImage";
            this.btnTestImage.Size = new System.Drawing.Size(197, 26);
            this.btnTestImage.TabIndex = 13;
            this.btnTestImage.Text = "OCR";
            this.btnTestImage.UseVisualStyleBackColor = true;
            this.btnTestImage.Click += new System.EventHandler(this.btnTestImage_Click);
            // 
            // picboxImageSource
            // 
            this.picboxImageSource.Location = new System.Drawing.Point(467, 219);
            this.picboxImageSource.Name = "picboxImageSource";
            this.picboxImageSource.Size = new System.Drawing.Size(186, 149);
            this.picboxImageSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImageSource.TabIndex = 12;
            this.picboxImageSource.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(82, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(157, 20);
            this.txtURL.TabIndex = 10;
            this.txtURL.Text = "D:\\imageOCR\\Training";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Training set:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Training MSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Epoch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ảnh gốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thời gian";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(78, 258);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(80, 24);
            this.lbResult.TabIndex = 7;
            this.lbResult.Text = "Result: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 475);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bắt đầu huấn luyện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbEpoch
            // 
            this.lbEpoch.AutoSize = true;
            this.lbEpoch.Location = new System.Drawing.Point(138, 150);
            this.lbEpoch.Name = "lbEpoch";
            this.lbEpoch.Size = new System.Drawing.Size(35, 13);
            this.lbEpoch.TabIndex = 2;
            this.lbEpoch.Text = "label3";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(217, 150);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(35, 13);
            this.lbError.TabIndex = 1;
            this.lbError.Text = "label2";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(39, 150);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(33, 13);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Time:";
            // 
            // statisticalDataToolStripMenuItem
            // 
            this.statisticalDataToolStripMenuItem.Name = "statisticalDataToolStripMenuItem";
            this.statisticalDataToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.statisticalDataToolStripMenuItem.Text = "Statistical Data";
            this.statisticalDataToolStripMenuItem.Click += new System.EventHandler(this.statisticalDataToolStripMenuItem_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBinary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImageSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEpoch;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picboxImageSource;
        private System.Windows.Forms.Button btnTestImage;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateImageToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtValid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorGraphToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbValidErr;
        private System.Windows.Forms.PictureBox picBinary;
        private System.Windows.Forms.ToolStripMenuItem statisticalDataToolStripMenuItem;
    }
}

