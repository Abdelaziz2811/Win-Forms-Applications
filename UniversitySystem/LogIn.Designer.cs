namespace UniversitySystem
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.CBRememberMe = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxTBUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxTBPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BTNShowHide = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TrialsTimer = new System.Windows.Forms.Timer(this.components);
            this.LBTrials = new System.Windows.Forms.Label();
            this.BTNCloseForm = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.LBDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CBRememberMe
            // 
            this.CBRememberMe.AutoSize = true;
            this.CBRememberMe.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRememberMe.Location = new System.Drawing.Point(89, 346);
            this.CBRememberMe.Name = "CBRememberMe";
            this.CBRememberMe.Size = new System.Drawing.Size(109, 23);
            this.CBRememberMe.TabIndex = 3;
            this.CBRememberMe.Text = "Remember me";
            this.CBRememberMe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 90);
            this.label1.TabIndex = 4;
            this.label1.Text = "   Welcome to UTech\r\nSign into your account\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(115, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "UTech\r";
            // 
            // TxTBUserName
            // 
            this.TxTBUserName.Animated = true;
            this.TxTBUserName.BackColor = System.Drawing.SystemColors.Window;
            this.TxTBUserName.BorderRadius = 15;
            this.TxTBUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBUserName.DefaultText = "";
            this.TxTBUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxTBUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxTBUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxTBUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxTBUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxTBUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxTBUserName.ForeColor = System.Drawing.Color.Black;
            this.TxTBUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxTBUserName.Location = new System.Drawing.Point(44, 181);
            this.TxTBUserName.Name = "TxTBUserName";
            this.TxTBUserName.PasswordChar = '\0';
            this.TxTBUserName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxTBUserName.PlaceholderText = "Username";
            this.TxTBUserName.SelectedText = "";
            this.TxTBUserName.Size = new System.Drawing.Size(205, 36);
            this.TxTBUserName.TabIndex = 8;
            this.TxTBUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTBUserName.TextChanged += new System.EventHandler(this.TxTBUserName_TextChanged);
            this.TxTBUserName.MouseEnter += new System.EventHandler(this.TxTBUserName_MouseEnter);
            // 
            // TxTBPassword
            // 
            this.TxTBPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TxTBPassword.BorderRadius = 15;
            this.TxTBPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBPassword.DefaultText = "";
            this.TxTBPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxTBPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxTBPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxTBPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxTBPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxTBPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxTBPassword.ForeColor = System.Drawing.Color.Black;
            this.TxTBPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxTBPassword.Location = new System.Drawing.Point(44, 236);
            this.TxTBPassword.Name = "TxTBPassword";
            this.TxTBPassword.PasswordChar = '●';
            this.TxTBPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxTBPassword.PlaceholderText = "Password";
            this.TxTBPassword.SelectedText = "";
            this.TxTBPassword.Size = new System.Drawing.Size(205, 36);
            this.TxTBPassword.TabIndex = 9;
            this.TxTBPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTBPassword.TextChanged += new System.EventHandler(this.TxTBPassword_TextChanged);
            this.TxTBPassword.MouseEnter += new System.EventHandler(this.TxTBPassword_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 380);
            this.label3.TabIndex = 10;
            this.label3.Text = "\r\n                                                          \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r" +
    "\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // BTNLogin
            // 
            this.BTNLogin.BackColor = System.Drawing.Color.Transparent;
            this.BTNLogin.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNLogin.BorderRadius = 15;
            this.BTNLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNLogin.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNLogin.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.BTNLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.BTNLogin.ForeColor = System.Drawing.Color.Black;
            this.BTNLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTNLogin.HoverState.FillColor = System.Drawing.Color.SkyBlue;
            this.BTNLogin.HoverState.FillColor2 = System.Drawing.Color.SkyBlue;
            this.BTNLogin.Location = new System.Drawing.Point(44, 291);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNLogin.Size = new System.Drawing.Size(205, 36);
            this.BTNLogin.TabIndex = 11;
            this.BTNLogin.Text = "Log in";
            this.BTNLogin.UseTransparentBackground = true;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // BTNShowHide
            // 
            this.BTNShowHide.BackColor = System.Drawing.SystemColors.Window;
            this.BTNShowHide.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BTNShowHide.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.BTNShowHide.Image = global::UniversitySystem.Properties.Resources.show;
            this.BTNShowHide.ImageOffset = new System.Drawing.Point(0, 0);
            this.BTNShowHide.ImageRotate = 0F;
            this.BTNShowHide.ImageSize = new System.Drawing.Size(16, 16);
            this.BTNShowHide.Location = new System.Drawing.Point(217, 244);
            this.BTNShowHide.Name = "BTNShowHide";
            this.BTNShowHide.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.BTNShowHide.Size = new System.Drawing.Size(23, 21);
            this.BTNShowHide.TabIndex = 12;
            this.BTNShowHide.Tag = "show";
            this.BTNShowHide.Click += new System.EventHandler(this.BTNShowHide_Click);
            // 
            // TrialsTimer
            // 
            this.TrialsTimer.Enabled = true;
            this.TrialsTimer.Interval = 1000;
            this.TrialsTimer.Tick += new System.EventHandler(this.TrialsTimer_Tick);
            // 
            // LBTrials
            // 
            this.LBTrials.AutoSize = true;
            this.LBTrials.Location = new System.Drawing.Point(90, 386);
            this.LBTrials.Name = "LBTrials";
            this.LBTrials.Size = new System.Drawing.Size(0, 13);
            this.LBTrials.TabIndex = 14;
            this.LBTrials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNCloseForm
            // 
            this.BTNCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.BTNCloseForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNCloseForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNCloseForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNCloseForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNCloseForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNCloseForm.ForeColor = System.Drawing.Color.White;
            this.BTNCloseForm.Image = global::UniversitySystem.Properties.Resources.close;
            this.BTNCloseForm.Location = new System.Drawing.Point(762, 12);
            this.BTNCloseForm.Name = "BTNCloseForm";
            this.BTNCloseForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTNCloseForm.Size = new System.Drawing.Size(22, 22);
            this.BTNCloseForm.TabIndex = 15;
            this.BTNCloseForm.Tile = false;
            this.BTNCloseForm.UseTransparentBackground = true;
            this.BTNCloseForm.Click += new System.EventHandler(this.BTNCloseForm_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // LBDate
            // 
            this.LBDate.BackColor = System.Drawing.Color.Transparent;
            this.LBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDate.Location = new System.Drawing.Point(657, 420);
            this.LBDate.Name = "LBDate";
            this.LBDate.Size = new System.Drawing.Size(3, 2);
            this.LBDate.TabIndex = 16;
            this.LBDate.Text = null;
            this.LBDate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBDate);
            this.Controls.Add(this.BTNCloseForm);
            this.Controls.Add(this.LBTrials);
            this.Controls.Add(this.BTNShowHide);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.TxTBPassword);
            this.Controls.Add(this.TxTBUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBRememberMe);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.ShowInTaskbar = false;
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CBRememberMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxTBUserName;
        private Guna.UI2.WinForms.Guna2TextBox TxTBPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton BTNLogin;
        private Guna.UI2.WinForms.Guna2ImageButton BTNShowHide;
        private System.Windows.Forms.Timer TrialsTimer;
        private System.Windows.Forms.Label LBTrials;
        private Guna.UI2.WinForms.Guna2CircleButton BTNCloseForm;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBDate;
        private System.Windows.Forms.Timer timer1;
    }
}

