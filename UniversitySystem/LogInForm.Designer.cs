namespace UniversitySystem
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.TxTBUserName = new System.Windows.Forms.TextBox();
            this.TxTBPassword = new System.Windows.Forms.TextBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.CBRememberMe = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxTBUserName
            // 
            this.TxTBUserName.Location = new System.Drawing.Point(33, 226);
            this.TxTBUserName.Name = "TxTBUserName";
            this.TxTBUserName.Size = new System.Drawing.Size(205, 20);
            this.TxTBUserName.TabIndex = 0;
            this.TxTBUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTBUserName.MouseEnter += new System.EventHandler(this.TxTBUserName_MouseEnter);
            // 
            // TxTBPassword
            // 
            this.TxTBPassword.Location = new System.Drawing.Point(33, 256);
            this.TxTBPassword.Name = "TxTBPassword";
            this.TxTBPassword.PasswordChar = '•';
            this.TxTBPassword.Size = new System.Drawing.Size(205, 20);
            this.TxTBPassword.TabIndex = 1;
            this.TxTBPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTBPassword.MouseEnter += new System.EventHandler(this.TxTBPassword_MouseEnter);
            // 
            // BTNLogin
            // 
            this.BTNLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BTNLogin.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNLogin.FlatAppearance.BorderSize = 2;
            this.BTNLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BTNLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTNLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLogin.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogin.Location = new System.Drawing.Point(33, 282);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(205, 42);
            this.BTNLogin.TabIndex = 2;
            this.BTNLogin.Text = "Log In";
            this.BTNLogin.UseVisualStyleBackColor = false;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // CBRememberMe
            // 
            this.CBRememberMe.AutoSize = true;
            this.CBRememberMe.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRememberMe.Location = new System.Drawing.Point(33, 330);
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
            this.label1.Location = new System.Drawing.Point(28, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 90);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to UTech\r\nSign into your account\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "UTech\r";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBRememberMe);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.TxTBPassword);
            this.Controls.Add(this.TxTBUserName);
            this.DoubleBuffered = true;
            this.Name = "LogInForm";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxTBUserName;
        private System.Windows.Forms.TextBox TxTBPassword;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.CheckBox CBRememberMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

