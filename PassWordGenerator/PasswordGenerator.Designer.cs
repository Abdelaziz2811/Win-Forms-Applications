namespace PassWordGenerator
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBUppercaseletters = new System.Windows.Forms.CheckBox();
            this.CBLowercaseletters = new System.Windows.Forms.CheckBox();
            this.CBNumbers = new System.Windows.Forms.CheckBox();
            this.CBSymbols = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.TXTBGeneratedCode = new System.Windows.Forms.TextBox();
            this.BTNGenerate = new System.Windows.Forms.Button();
            this.BTNCopy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.CBSymbols);
            this.panel1.Controls.Add(this.CBNumbers);
            this.panel1.Controls.Add(this.CBLowercaseletters);
            this.panel1.Controls.Add(this.CBUppercaseletters);
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(364, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 94);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(398, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Generator";
            // 
            // CBUppercaseletters
            // 
            this.CBUppercaseletters.AutoSize = true;
            this.CBUppercaseletters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBUppercaseletters.Location = new System.Drawing.Point(18, 16);
            this.CBUppercaseletters.Name = "CBUppercaseletters";
            this.CBUppercaseletters.Size = new System.Drawing.Size(143, 22);
            this.CBUppercaseletters.TabIndex = 0;
            this.CBUppercaseletters.Text = "Uppercase letters";
            this.CBUppercaseletters.UseVisualStyleBackColor = true;
            // 
            // CBLowercaseletters
            // 
            this.CBLowercaseletters.AutoSize = true;
            this.CBLowercaseletters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLowercaseletters.Location = new System.Drawing.Point(18, 49);
            this.CBLowercaseletters.Name = "CBLowercaseletters";
            this.CBLowercaseletters.Size = new System.Drawing.Size(144, 22);
            this.CBLowercaseletters.TabIndex = 1;
            this.CBLowercaseletters.Text = "Lowercase letters";
            this.CBLowercaseletters.UseVisualStyleBackColor = true;
            // 
            // CBNumbers
            // 
            this.CBNumbers.AutoSize = true;
            this.CBNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNumbers.Location = new System.Drawing.Point(174, 16);
            this.CBNumbers.Name = "CBNumbers";
            this.CBNumbers.Size = new System.Drawing.Size(88, 22);
            this.CBNumbers.TabIndex = 2;
            this.CBNumbers.Text = "Numbers";
            this.CBNumbers.UseVisualStyleBackColor = true;
            // 
            // CBSymbols
            // 
            this.CBSymbols.AutoSize = true;
            this.CBSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSymbols.Location = new System.Drawing.Point(174, 49);
            this.CBSymbols.Name = "CBSymbols";
            this.CBSymbols.Size = new System.Drawing.Size(85, 22);
            this.CBSymbols.TabIndex = 3;
            this.CBSymbols.Text = "Symbols";
            this.CBSymbols.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(364, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(364, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password Length";
            // 
            // NUDPasswordLength
            // 
            this.NUDPasswordLength.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NUDPasswordLength.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NUDPasswordLength.Location = new System.Drawing.Point(539, 215);
            this.NUDPasswordLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDPasswordLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUDPasswordLength.Name = "NUDPasswordLength";
            this.NUDPasswordLength.Size = new System.Drawing.Size(105, 20);
            this.NUDPasswordLength.TabIndex = 4;
            this.NUDPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // TXTBGeneratedCode
            // 
            this.TXTBGeneratedCode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXTBGeneratedCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBGeneratedCode.Location = new System.Drawing.Point(403, 259);
            this.TXTBGeneratedCode.Name = "TXTBGeneratedCode";
            this.TXTBGeneratedCode.ReadOnly = true;
            this.TXTBGeneratedCode.Size = new System.Drawing.Size(203, 22);
            this.TXTBGeneratedCode.TabIndex = 5;
            this.TXTBGeneratedCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNGenerate
            // 
            this.BTNGenerate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BTNGenerate.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.BTNGenerate.FlatAppearance.BorderSize = 2;
            this.BTNGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.BTNGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BTNGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGenerate.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BTNGenerate.Location = new System.Drawing.Point(364, 304);
            this.BTNGenerate.Name = "BTNGenerate";
            this.BTNGenerate.Size = new System.Drawing.Size(111, 47);
            this.BTNGenerate.TabIndex = 6;
            this.BTNGenerate.Text = "Generate";
            this.BTNGenerate.UseVisualStyleBackColor = false;
            this.BTNGenerate.Click += new System.EventHandler(this.BTNGenerate_Click);
            // 
            // BTNCopy
            // 
            this.BTNCopy.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BTNCopy.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.BTNCopy.FlatAppearance.BorderSize = 2;
            this.BTNCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.BTNCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BTNCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCopy.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BTNCopy.Location = new System.Drawing.Point(532, 304);
            this.BTNCopy.Name = "BTNCopy";
            this.BTNCopy.Size = new System.Drawing.Size(111, 47);
            this.BTNCopy.TabIndex = 7;
            this.BTNCopy.Text = "Copy";
            this.BTNCopy.UseVisualStyleBackColor = false;
            this.BTNCopy.Click += new System.EventHandler(this.BTNCopy_Click);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.BTNCopy);
            this.Controls.Add(this.BTNGenerate);
            this.Controls.Add(this.TXTBGeneratedCode);
            this.Controls.Add(this.NUDPasswordLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBUppercaseletters;
        private System.Windows.Forms.CheckBox CBSymbols;
        private System.Windows.Forms.CheckBox CBNumbers;
        private System.Windows.Forms.CheckBox CBLowercaseletters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDPasswordLength;
        private System.Windows.Forms.TextBox TXTBGeneratedCode;
        private System.Windows.Forms.Button BTNGenerate;
        private System.Windows.Forms.Button BTNCopy;
    }
}

