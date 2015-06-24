namespace MLP.OCR
{
    partial class GenerateImage
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.udThres = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.udSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.udHeight = new System.Windows.Forms.NumericUpDown();
            this.udWidth = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.udOffsetX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.udOffsetY = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOffsetY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.White;
            this.picImage.Location = new System.Drawing.Point(6, 19);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(235, 181);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Binarization";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.udOffsetY);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.udOffsetX);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.udThres);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.udSize);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbFont);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.udHeight);
            this.groupBox3.Controls.Add(this.udWidth);
            this.groupBox3.Location = new System.Drawing.Point(13, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Threshold:";
            // 
            // udThres
            // 
            this.udThres.Location = new System.Drawing.Point(68, 72);
            this.udThres.Name = "udThres";
            this.udThres.Size = new System.Drawing.Size(172, 20);
            this.udThres.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Size:";
            // 
            // udSize
            // 
            this.udSize.Location = new System.Drawing.Point(316, 45);
            this.udSize.Name = "udSize";
            this.udSize.Size = new System.Drawing.Size(145, 20);
            this.udSize.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Font:";
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(316, 19);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(145, 21);
            this.cbFont.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width:";
            // 
            // udHeight
            // 
            this.udHeight.Location = new System.Drawing.Point(68, 46);
            this.udHeight.Name = "udHeight";
            this.udHeight.Size = new System.Drawing.Size(172, 20);
            this.udHeight.TabIndex = 1;
            // 
            // udWidth
            // 
            this.udWidth.Location = new System.Drawing.Point(68, 20);
            this.udWidth.Name = "udWidth";
            this.udWidth.Size = new System.Drawing.Size(172, 20);
            this.udWidth.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(369, 389);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(450, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Offset X:";
            // 
            // udOffsetX
            // 
            this.udOffsetX.Location = new System.Drawing.Point(316, 74);
            this.udOffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udOffsetX.Name = "udOffsetX";
            this.udOffsetX.Size = new System.Drawing.Size(145, 20);
            this.udOffsetX.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Offset Y:";
            // 
            // udOffsetY
            // 
            this.udOffsetY.Location = new System.Drawing.Point(316, 102);
            this.udOffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udOffsetY.Name = "udOffsetY";
            this.udOffsetY.Size = new System.Drawing.Size(145, 20);
            this.udOffsetY.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(198, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(68, 101);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(132, 20);
            this.txtData.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Data:";
            // 
            // GenerateImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 424);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GenerateImage";
            this.Text = "Auto Generate Data";
            this.Load += new System.EventHandler(this.GenerateImage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOffsetY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udHeight;
        private System.Windows.Forms.NumericUpDown udWidth;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown udThres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown udOffsetX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown udOffsetY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button button1;
    }
}