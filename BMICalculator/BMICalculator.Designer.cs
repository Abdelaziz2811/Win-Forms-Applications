namespace BMICalculator
{
    partial class BMICalculator
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
            this.components = new System.ComponentModel.Container();
            this.TxTBWeight = new System.Windows.Forms.TextBox();
            this.TxTBHeight = new System.Windows.Forms.TextBox();
            this.GBUnits = new System.Windows.Forms.GroupBox();
            this.RBTNImperial = new System.Windows.Forms.RadioButton();
            this.RBTNMetric = new System.Windows.Forms.RadioButton();
            this.LBHeight = new System.Windows.Forms.Label();
            this.LBWeight = new System.Windows.Forms.Label();
            this.BTNCalculateBMI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LBBMIResult = new System.Windows.Forms.Label();
            this.LBHealthStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GBUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxTBWeight
            // 
            this.TxTBWeight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxTBWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTBWeight.Location = new System.Drawing.Point(409, 226);
            this.TxTBWeight.Name = "TxTBWeight";
            this.TxTBWeight.Size = new System.Drawing.Size(134, 26);
            this.TxTBWeight.TabIndex = 2;
            this.TxTBWeight.Validating += new System.ComponentModel.CancelEventHandler(this.TxTBWeight_Validating);
            // 
            // TxTBHeight
            // 
            this.TxTBHeight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxTBHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTBHeight.Location = new System.Drawing.Point(409, 179);
            this.TxTBHeight.Name = "TxTBHeight";
            this.TxTBHeight.Size = new System.Drawing.Size(134, 26);
            this.TxTBHeight.TabIndex = 1;
            this.TxTBHeight.Validating += new System.ComponentModel.CancelEventHandler(this.TxTBHeight_Validating);
            // 
            // GBUnits
            // 
            this.GBUnits.Controls.Add(this.RBTNImperial);
            this.GBUnits.Controls.Add(this.RBTNMetric);
            this.GBUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBUnits.Location = new System.Drawing.Point(188, 69);
            this.GBUnits.Name = "GBUnits";
            this.GBUnits.Size = new System.Drawing.Size(382, 78);
            this.GBUnits.TabIndex = 0;
            this.GBUnits.TabStop = false;
            this.GBUnits.Text = "Units";
            // 
            // RBTNImperial
            // 
            this.RBTNImperial.AutoSize = true;
            this.RBTNImperial.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RBTNImperial.Location = new System.Drawing.Point(184, 33);
            this.RBTNImperial.Name = "RBTNImperial";
            this.RBTNImperial.Size = new System.Drawing.Size(171, 24);
            this.RBTNImperial.TabIndex = 1;
            this.RBTNImperial.TabStop = true;
            this.RBTNImperial.Text = "Imperial (lbs, inches)";
            this.RBTNImperial.UseVisualStyleBackColor = false;
            this.RBTNImperial.CheckedChanged += new System.EventHandler(this.RBTNImperial_CheckedChanged);
            // 
            // RBTNMetric
            // 
            this.RBTNMetric.AutoSize = true;
            this.RBTNMetric.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RBTNMetric.Location = new System.Drawing.Point(31, 33);
            this.RBTNMetric.Name = "RBTNMetric";
            this.RBTNMetric.Size = new System.Drawing.Size(130, 24);
            this.RBTNMetric.TabIndex = 0;
            this.RBTNMetric.TabStop = true;
            this.RBTNMetric.Text = "Metric (kg, cm)";
            this.RBTNMetric.UseVisualStyleBackColor = false;
            this.RBTNMetric.CheckedChanged += new System.EventHandler(this.RBTNMetric_CheckedChanged);
            // 
            // LBHeight
            // 
            this.LBHeight.AutoSize = true;
            this.LBHeight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LBHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBHeight.Location = new System.Drawing.Point(215, 181);
            this.LBHeight.Name = "LBHeight";
            this.LBHeight.Size = new System.Drawing.Size(118, 24);
            this.LBHeight.TabIndex = 3;
            this.LBHeight.Text = "Height (cm) :";
            // 
            // LBWeight
            // 
            this.LBWeight.AutoSize = true;
            this.LBWeight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LBWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBWeight.Location = new System.Drawing.Point(215, 228);
            this.LBWeight.Name = "LBWeight";
            this.LBWeight.Size = new System.Drawing.Size(116, 24);
            this.LBWeight.TabIndex = 4;
            this.LBWeight.Text = "Weight (kg) :";
            // 
            // BTNCalculateBMI
            // 
            this.BTNCalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCalculateBMI.Location = new System.Drawing.Point(310, 287);
            this.BTNCalculateBMI.Name = "BTNCalculateBMI";
            this.BTNCalculateBMI.Size = new System.Drawing.Size(132, 38);
            this.BTNCalculateBMI.TabIndex = 3;
            this.BTNCalculateBMI.Text = "Calculate BMI";
            this.BTNCalculateBMI.UseVisualStyleBackColor = true;
            this.BTNCalculateBMI.Click += new System.EventHandler(this.BTNCalculateBMI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "BMI Calculator";
            // 
            // LBBMIResult
            // 
            this.LBBMIResult.AutoSize = true;
            this.LBBMIResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LBBMIResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBMIResult.Location = new System.Drawing.Point(405, 346);
            this.LBBMIResult.Name = "LBBMIResult";
            this.LBBMIResult.Size = new System.Drawing.Size(99, 24);
            this.LBBMIResult.TabIndex = 8;
            this.LBBMIResult.Text = "BMI Result";
            // 
            // LBHealthStatus
            // 
            this.LBHealthStatus.AutoSize = true;
            this.LBHealthStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LBHealthStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBHealthStatus.Location = new System.Drawing.Point(405, 390);
            this.LBHealthStatus.Name = "LBHealthStatus";
            this.LBHealthStatus.Size = new System.Drawing.Size(119, 24);
            this.LBHealthStatus.TabIndex = 9;
            this.LBHealthStatus.Text = "Health Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "BMI Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Health Status";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBHealthStatus);
            this.Controls.Add(this.LBBMIResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNCalculateBMI);
            this.Controls.Add(this.LBWeight);
            this.Controls.Add(this.LBHeight);
            this.Controls.Add(this.GBUnits);
            this.Controls.Add(this.TxTBHeight);
            this.Controls.Add(this.TxTBWeight);
            this.DoubleBuffered = true;
            this.Name = "BMICalculator";
            this.Text = "BMI Calculator";
            this.GBUnits.ResumeLayout(false);
            this.GBUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxTBWeight;
        private System.Windows.Forms.TextBox TxTBHeight;
        private System.Windows.Forms.GroupBox GBUnits;
        private System.Windows.Forms.RadioButton RBTNImperial;
        private System.Windows.Forms.RadioButton RBTNMetric;
        private System.Windows.Forms.Label LBHeight;
        private System.Windows.Forms.Label LBWeight;
        private System.Windows.Forms.Button BTNCalculateBMI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBBMIResult;
        private System.Windows.Forms.Label LBHealthStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

