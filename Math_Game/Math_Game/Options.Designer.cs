namespace Math_Game
{
    partial class Options
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
            this.EPValidRoundsNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlOption = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UPDRounds = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.CBOperationType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CBGameLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BTNExit = new Guna.UI2.WinForms.Guna2Button();
            this.BTNNext = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.EPValidRoundsNumber)).BeginInit();
            this.pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPDRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // EPValidRoundsNumber
            // 
            this.EPValidRoundsNumber.ContainerControl = this;
            // 
            // pnlOption
            // 
            this.pnlOption.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlOption.BackgroundImage = global::Math_Game.Properties.Resources.Math_Game_Background;
            this.pnlOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOption.Controls.Add(this.guna2GradientButton1);
            this.pnlOption.Controls.Add(this.UPDRounds);
            this.pnlOption.Controls.Add(this.CBOperationType);
            this.pnlOption.Controls.Add(this.CBGameLevel);
            this.pnlOption.Controls.Add(this.BTNExit);
            this.pnlOption.Controls.Add(this.BTNNext);
            this.pnlOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOption.Location = new System.Drawing.Point(0, 0);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(800, 450);
            this.pnlOption.TabIndex = 0;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(104)))), ((int)(((byte)(110)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(279, 49);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(220, 45);
            this.guna2GradientButton1.TabIndex = 6;
            this.guna2GradientButton1.Text = "Game Options";
            this.guna2GradientButton1.UseTransparentBackground = true;
            // 
            // UPDRounds
            // 
            this.UPDRounds.BackColor = System.Drawing.Color.Transparent;
            this.UPDRounds.BorderRadius = 15;
            this.UPDRounds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UPDRounds.FillColor = System.Drawing.Color.DarkGray;
            this.UPDRounds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UPDRounds.Location = new System.Drawing.Point(314, 256);
            this.UPDRounds.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UPDRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UPDRounds.Name = "UPDRounds";
            this.UPDRounds.Size = new System.Drawing.Size(158, 36);
            this.UPDRounds.TabIndex = 5;
            this.UPDRounds.TextOffset = new System.Drawing.Point(55, 0);
            this.UPDRounds.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(104)))), ((int)(((byte)(110)))));
            this.UPDRounds.UseTransparentBackground = true;
            this.UPDRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CBOperationType
            // 
            this.CBOperationType.BackColor = System.Drawing.Color.Transparent;
            this.CBOperationType.BorderRadius = 15;
            this.CBOperationType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOperationType.FillColor = System.Drawing.Color.DarkGray;
            this.CBOperationType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBOperationType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBOperationType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CBOperationType.ForeColor = System.Drawing.Color.Black;
            this.CBOperationType.ItemHeight = 30;
            this.CBOperationType.Items.AddRange(new object[] {
            "Addition",
            "Abstraction",
            "Multiplication",
            "Division",
            "Mix"});
            this.CBOperationType.Location = new System.Drawing.Point(314, 196);
            this.CBOperationType.Name = "CBOperationType";
            this.CBOperationType.Size = new System.Drawing.Size(158, 36);
            this.CBOperationType.StartIndex = 0;
            this.CBOperationType.TabIndex = 3;
            this.CBOperationType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBGameLevel
            // 
            this.CBGameLevel.BackColor = System.Drawing.Color.Transparent;
            this.CBGameLevel.BorderRadius = 15;
            this.CBGameLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBGameLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGameLevel.FillColor = System.Drawing.Color.DarkGray;
            this.CBGameLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBGameLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBGameLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CBGameLevel.ForeColor = System.Drawing.Color.Black;
            this.CBGameLevel.ItemHeight = 30;
            this.CBGameLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Mix"});
            this.CBGameLevel.Location = new System.Drawing.Point(314, 136);
            this.CBGameLevel.Name = "CBGameLevel";
            this.CBGameLevel.Size = new System.Drawing.Size(158, 36);
            this.CBGameLevel.StartIndex = 0;
            this.CBGameLevel.TabIndex = 2;
            this.CBGameLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNExit
            // 
            this.BTNExit.BackColor = System.Drawing.Color.Transparent;
            this.BTNExit.BorderColor = System.Drawing.Color.White;
            this.BTNExit.BorderRadius = 15;
            this.BTNExit.BorderThickness = 2;
            this.BTNExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.BTNExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNExit.ForeColor = System.Drawing.Color.White;
            this.BTNExit.Location = new System.Drawing.Point(248, 341);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(118, 44);
            this.BTNExit.TabIndex = 1;
            this.BTNExit.Text = "Exit";
            this.BTNExit.UseTransparentBackground = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // BTNNext
            // 
            this.BTNNext.BackColor = System.Drawing.Color.Transparent;
            this.BTNNext.BorderColor = System.Drawing.Color.White;
            this.BTNNext.BorderRadius = 15;
            this.BTNNext.BorderThickness = 2;
            this.BTNNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.BTNNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNext.ForeColor = System.Drawing.Color.White;
            this.BTNNext.Location = new System.Drawing.Point(421, 341);
            this.BTNNext.Name = "BTNNext";
            this.BTNNext.Size = new System.Drawing.Size(118, 44);
            this.BTNNext.TabIndex = 0;
            this.BTNNext.Text = "Next";
            this.BTNNext.UseTransparentBackground = true;
            this.BTNNext.Click += new System.EventHandler(this.BTNNext_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOption);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Options";
            this.Text = "Math Game";
            ((System.ComponentModel.ISupportInitialize)(this.EPValidRoundsNumber)).EndInit();
            this.pnlOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UPDRounds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlOption;
        private Guna.UI2.WinForms.Guna2Button BTNNext;
        private Guna.UI2.WinForms.Guna2Button BTNExit;
        private Guna.UI2.WinForms.Guna2NumericUpDown UPDRounds;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.ErrorProvider EPValidRoundsNumber;
        public Guna.UI2.WinForms.Guna2ComboBox CBOperationType;
        public Guna.UI2.WinForms.Guna2ComboBox CBGameLevel;
    }
}

