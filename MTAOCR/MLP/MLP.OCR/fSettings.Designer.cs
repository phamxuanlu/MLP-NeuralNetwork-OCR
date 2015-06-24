namespace MLP.OCR
{
    partial class fSettings
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
            this.udL1 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.udLayers = new System.Windows.Forms.NumericUpDown();
            this.cboxTransferFunction = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMomentum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLearningRateDownStep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLearningRateUpStep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtErrorThresholdPercent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtErrorToStop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEpochToStop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLearningRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLay1 = new System.Windows.Forms.Label();
            this.lbL2 = new System.Windows.Forms.Label();
            this.udL2 = new System.Windows.Forms.NumericUpDown();
            this.lbL3 = new System.Windows.Forms.Label();
            this.udL3 = new System.Windows.Forms.NumericUpDown();
            this.lbL4 = new System.Windows.Forms.Label();
            this.udL4 = new System.Windows.Forms.NumericUpDown();
            this.lbL5 = new System.Windows.Forms.Label();
            this.udL5 = new System.Windows.Forms.NumericUpDown();
            this.lbL6 = new System.Windows.Forms.Label();
            this.udL6 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLayers)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udL3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udL4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udL5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udL6)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMomentum);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtErrorToStop);
            this.groupBox1.Controls.Add(this.txtEpochToStop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLearningRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxTransferFunction);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global paranmeters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // udL1
            // 
            this.udL1.Location = new System.Drawing.Point(105, 91);
            this.udL1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udL1.Name = "udL1";
            this.udL1.Size = new System.Drawing.Size(110, 20);
            this.udL1.TabIndex = 4;
            this.udL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udL1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(102, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Neurons:";
            // 
            // udLayers
            // 
            this.udLayers.Location = new System.Drawing.Point(105, 37);
            this.udLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLayers.Name = "udLayers";
            this.udLayers.Size = new System.Drawing.Size(110, 20);
            this.udLayers.TabIndex = 4;
            this.udLayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udLayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLayers.ValueChanged += new System.EventHandler(this.updownNumberOfLayers_ValueChanged);
            // 
            // cboxTransferFunction
            // 
            this.cboxTransferFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTransferFunction.FormattingEnabled = true;
            this.cboxTransferFunction.Location = new System.Drawing.Point(16, 216);
            this.cboxTransferFunction.Name = "cboxTransferFunction";
            this.cboxTransferFunction.Size = new System.Drawing.Size(110, 21);
            this.cboxTransferFunction.TabIndex = 3;
            this.cboxTransferFunction.SelectedIndexChanged += new System.EventHandler(this.cboxTransferFunction_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Transfer Function:";
            // 
            // txtMomentum
            // 
            this.txtMomentum.Location = new System.Drawing.Point(16, 173);
            this.txtMomentum.Name = "txtMomentum";
            this.txtMomentum.Size = new System.Drawing.Size(110, 20);
            this.txtMomentum.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Minimum Error:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Momentum:";
            // 
            // txtLearningRateDownStep
            // 
            this.txtLearningRateDownStep.Location = new System.Drawing.Point(19, 132);
            this.txtLearningRateDownStep.Name = "txtLearningRateDownStep";
            this.txtLearningRateDownStep.Size = new System.Drawing.Size(110, 20);
            this.txtLearningRateDownStep.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Decrease Step:";
            // 
            // txtLearningRateUpStep
            // 
            this.txtLearningRateUpStep.Location = new System.Drawing.Point(19, 86);
            this.txtLearningRateUpStep.Name = "txtLearningRateUpStep";
            this.txtLearningRateUpStep.Size = new System.Drawing.Size(110, 20);
            this.txtLearningRateUpStep.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Increase Step:";
            // 
            // txtErrorThresholdPercent
            // 
            this.txtErrorThresholdPercent.Location = new System.Drawing.Point(19, 44);
            this.txtErrorThresholdPercent.Name = "txtErrorThresholdPercent";
            this.txtErrorThresholdPercent.Size = new System.Drawing.Size(110, 20);
            this.txtErrorThresholdPercent.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "E Threshold:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(135, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "%";
            // 
            // txtErrorToStop
            // 
            this.txtErrorToStop.Location = new System.Drawing.Point(16, 85);
            this.txtErrorToStop.Name = "txtErrorToStop";
            this.txtErrorToStop.Size = new System.Drawing.Size(110, 20);
            this.txtErrorToStop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "%";
            // 
            // txtEpochToStop
            // 
            this.txtEpochToStop.Location = new System.Drawing.Point(16, 132);
            this.txtEpochToStop.Name = "txtEpochToStop";
            this.txtEpochToStop.Size = new System.Drawing.Size(110, 20);
            this.txtEpochToStop.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maximum Epoch:";
            // 
            // txtLearningRate
            // 
            this.txtLearningRate.Location = new System.Drawing.Point(16, 44);
            this.txtLearningRate.Name = "txtLearningRate";
            this.txtLearningRate.Size = new System.Drawing.Size(110, 20);
            this.txtLearningRate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Learning Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Layers:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbL6);
            this.groupBox2.Controls.Add(this.udL6);
            this.groupBox2.Controls.Add(this.lbL5);
            this.groupBox2.Controls.Add(this.udL5);
            this.groupBox2.Controls.Add(this.lbL4);
            this.groupBox2.Controls.Add(this.udL4);
            this.groupBox2.Controls.Add(this.lbL3);
            this.groupBox2.Controls.Add(this.udL3);
            this.groupBox2.Controls.Add(this.lbL2);
            this.groupBox2.Controls.Add(this.udL2);
            this.groupBox2.Controls.Add(this.lbLay1);
            this.groupBox2.Controls.Add(this.udLayers);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.udL1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(172, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 294);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network";
            // 
            // lbLay1
            // 
            this.lbLay1.AutoSize = true;
            this.lbLay1.Location = new System.Drawing.Point(6, 93);
            this.lbLay1.Name = "lbLay1";
            this.lbLay1.Size = new System.Drawing.Size(45, 13);
            this.lbLay1.TabIndex = 5;
            this.lbLay1.Text = "Layer 1:";
            // 
            // lbL2
            // 
            this.lbL2.AutoSize = true;
            this.lbL2.Location = new System.Drawing.Point(6, 128);
            this.lbL2.Name = "lbL2";
            this.lbL2.Size = new System.Drawing.Size(45, 13);
            this.lbL2.TabIndex = 7;
            this.lbL2.Text = "Layer 2:";
            // 
            // udL2
            // 
            this.udL2.Location = new System.Drawing.Point(105, 124);
            this.udL2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udL2.Name = "udL2";
            this.udL2.Size = new System.Drawing.Size(110, 20);
            this.udL2.TabIndex = 6;
            this.udL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udL2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbL3
            // 
            this.lbL3.AutoSize = true;
            this.lbL3.Location = new System.Drawing.Point(6, 159);
            this.lbL3.Name = "lbL3";
            this.lbL3.Size = new System.Drawing.Size(45, 13);
            this.lbL3.TabIndex = 9;
            this.lbL3.Text = "Layer 3:";
            // 
            // udL3
            // 
            this.udL3.Location = new System.Drawing.Point(105, 157);
            this.udL3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udL3.Name = "udL3";
            this.udL3.Size = new System.Drawing.Size(110, 20);
            this.udL3.TabIndex = 8;
            this.udL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udL3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbL4
            // 
            this.lbL4.AutoSize = true;
            this.lbL4.Location = new System.Drawing.Point(6, 192);
            this.lbL4.Name = "lbL4";
            this.lbL4.Size = new System.Drawing.Size(45, 13);
            this.lbL4.TabIndex = 11;
            this.lbL4.Text = "Layer 4:";
            // 
            // udL4
            // 
            this.udL4.Location = new System.Drawing.Point(105, 190);
            this.udL4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udL4.Name = "udL4";
            this.udL4.Size = new System.Drawing.Size(110, 20);
            this.udL4.TabIndex = 10;
            this.udL4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udL4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbL5
            // 
            this.lbL5.AutoSize = true;
            this.lbL5.Location = new System.Drawing.Point(6, 227);
            this.lbL5.Name = "lbL5";
            this.lbL5.Size = new System.Drawing.Size(45, 13);
            this.lbL5.TabIndex = 13;
            this.lbL5.Text = "Layer 5:";
            // 
            // udL5
            // 
            this.udL5.Location = new System.Drawing.Point(105, 223);
            this.udL5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udL5.Name = "udL5";
            this.udL5.Size = new System.Drawing.Size(110, 20);
            this.udL5.TabIndex = 12;
            this.udL5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udL5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbL6
            // 
            this.lbL6.AutoSize = true;
            this.lbL6.Location = new System.Drawing.Point(6, 258);
            this.lbL6.Name = "lbL6";
            this.lbL6.Size = new System.Drawing.Size(45, 13);
            this.lbL6.TabIndex = 15;
            this.lbL6.Text = "Layer 6:";
            // 
            // udL6
            // 
            this.udL6.Location = new System.Drawing.Point(105, 256);
            this.udL6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udL6.Name = "udL6";
            this.udL6.Size = new System.Drawing.Size(110, 20);
            this.udL6.TabIndex = 14;
            this.udL6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udL6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtLearningRateDownStep);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtLearningRateUpStep);
            this.groupBox3.Controls.Add(this.txtErrorThresholdPercent);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(411, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 296);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Variable Learning Rate";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 320);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fSettings_FormClosing);
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLayers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udL3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udL4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udL5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udL6)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLearningRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMomentum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtErrorToStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEpochToStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxTransferFunction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtErrorThresholdPercent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLearningRateUpStep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLearningRateDownStep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown udLayers;
        private System.Windows.Forms.NumericUpDown udL1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbL6;
        private System.Windows.Forms.NumericUpDown udL6;
        private System.Windows.Forms.Label lbL5;
        private System.Windows.Forms.NumericUpDown udL5;
        private System.Windows.Forms.Label lbL4;
        private System.Windows.Forms.NumericUpDown udL4;
        private System.Windows.Forms.Label lbL3;
        private System.Windows.Forms.NumericUpDown udL3;
        private System.Windows.Forms.Label lbL2;
        private System.Windows.Forms.NumericUpDown udL2;
        private System.Windows.Forms.Label lbLay1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}