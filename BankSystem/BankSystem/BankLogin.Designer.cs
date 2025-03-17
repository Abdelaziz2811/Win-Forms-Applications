namespace BankSystem
{
    partial class BankLogin
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
            if (this.guna2PictureBox1.Visible == false || guna2PictureBox1.Visible == false)
            {
                this.guna2PictureBox1.Visible = true;
                this.TXTUsername.Visible = true;
                this.TXTPassword.Visible = true;
                this.BTNLogin.Visible = true;
                this.CHBRememberme.Visible = true;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankLogin));
            this.MainPNL = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CHBRememberme = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TXTPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MainPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPNL
            // 
            this.MainPNL.BackColor = System.Drawing.SystemColors.Window;
            this.MainPNL.BackgroundImage = global::BankSystem.Properties.Resources.BankLoginBackground;
            this.MainPNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPNL.Controls.Add(this.guna2PictureBox1);
            this.MainPNL.Controls.Add(this.CHBRememberme);
            this.MainPNL.Controls.Add(this.TXTPassword);
            this.MainPNL.Controls.Add(this.TXTUsername);
            this.MainPNL.Controls.Add(this.BTNLogin);
            this.MainPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPNL.Location = new System.Drawing.Point(0, 0);
            this.MainPNL.Name = "MainPNL";
            this.MainPNL.Size = new System.Drawing.Size(800, 450);
            this.MainPNL.TabIndex = 3;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSystem.Properties.Resources.bankGIF;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(54, 27);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 131);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CHBRememberme
            // 
            this.CHBRememberme.AutoSize = true;
            this.CHBRememberme.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CHBRememberme.CheckedState.BorderRadius = 0;
            this.CHBRememberme.CheckedState.BorderThickness = 0;
            this.CHBRememberme.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CHBRememberme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBRememberme.Location = new System.Drawing.Point(98, 376);
            this.CHBRememberme.Name = "CHBRememberme";
            this.CHBRememberme.Size = new System.Drawing.Size(113, 21);
            this.CHBRememberme.TabIndex = 3;
            this.CHBRememberme.Text = "Remember me";
            this.CHBRememberme.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CHBRememberme.UncheckedState.BorderRadius = 3;
            this.CHBRememberme.UncheckedState.BorderThickness = 0;
            this.CHBRememberme.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            // 
            // TXTPassword
            // 
            this.TXTPassword.Animated = true;
            this.TXTPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.TXTPassword.BorderRadius = 15;
            this.TXTPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTPassword.DefaultText = "";
            this.TXTPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.TXTPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTPassword.Location = new System.Drawing.Point(54, 248);
            this.TXTPassword.Modified = true;
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PlaceholderText = "Password";
            this.TXTPassword.SelectedText = "";
            this.TXTPassword.Size = new System.Drawing.Size(200, 36);
            this.TXTPassword.TabIndex = 2;
            this.TXTPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTPassword.MouseEnter += new System.EventHandler(this.TXTUserCredentials_MouseEnter);
            // 
            // TXTUsername
            // 
            this.TXTUsername.Animated = true;
            this.TXTUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.TXTUsername.BorderRadius = 15;
            this.TXTUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTUsername.DefaultText = "";
            this.TXTUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.TXTUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTUsername.Location = new System.Drawing.Point(54, 189);
            this.TXTUsername.Name = "TXTUsername";
            this.TXTUsername.PlaceholderText = "Username";
            this.TXTUsername.SelectedText = "";
            this.TXTUsername.Size = new System.Drawing.Size(200, 36);
            this.TXTUsername.TabIndex = 1;
            this.TXTUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTUsername.MouseEnter += new System.EventHandler(this.TXTUserCredentials_MouseEnter);
            // 
            // BTNLogin
            // 
            this.BTNLogin.BackColor = System.Drawing.Color.Transparent;
            this.BTNLogin.BorderRadius = 15;
            this.BTNLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNLogin.FillColor = System.Drawing.Color.CornflowerBlue;
            this.BTNLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.BTNLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BTNLogin.ForeColor = System.Drawing.Color.White;
            this.BTNLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.BTNLogin.Location = new System.Drawing.Point(78, 319);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(152, 42);
            this.BTNLogin.TabIndex = 0;
            this.BTNLogin.Text = "Login";
            this.BTNLogin.UseTransparentBackground = true;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // BankLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPNL);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BankLogin";
            this.Text = "Bank System";
            this.MainPNL.ResumeLayout(false);
            this.MainPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel MainPNL;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2TextBox TXTUsername;
        public Guna.UI2.WinForms.Guna2GradientButton BTNLogin;
        public Guna.UI2.WinForms.Guna2CheckBox CHBRememberme;
        internal Guna.UI2.WinForms.Guna2TextBox TXTPassword;
    }
}

