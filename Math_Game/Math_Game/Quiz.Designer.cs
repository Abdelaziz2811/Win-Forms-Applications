namespace Math_Game
{
    partial class Quiz
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
            this.BTNGameOptions = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlQuiz = new Guna.UI2.WinForms.Guna2Panel();
            this.CPBProblemDuration = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.TXTBMathProblem = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTBPlayerAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTNGameResults = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Problem_Timer = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.IBTNStart = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PBPlayerAnswerStatus2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PBPlayerAnswerStatus1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PBThinking = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.IBTNNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.IBTNRestart = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlQuiz.SuspendLayout();
            this.CPBProblemDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlayerAnswerStatus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlayerAnswerStatus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBThinking)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNGameOptions
            // 
            this.BTNGameOptions.BackColor = System.Drawing.Color.Transparent;
            this.BTNGameOptions.BorderColor = System.Drawing.Color.White;
            this.BTNGameOptions.BorderRadius = 15;
            this.BTNGameOptions.BorderThickness = 1;
            this.BTNGameOptions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNGameOptions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNGameOptions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNGameOptions.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNGameOptions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNGameOptions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.BTNGameOptions.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(104)))), ((int)(((byte)(110)))));
            this.BTNGameOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGameOptions.ForeColor = System.Drawing.Color.White;
            this.BTNGameOptions.Location = new System.Drawing.Point(65, 371);
            this.BTNGameOptions.Name = "BTNGameOptions";
            this.BTNGameOptions.Size = new System.Drawing.Size(126, 37);
            this.BTNGameOptions.TabIndex = 7;
            this.BTNGameOptions.Text = "Game Options";
            this.BTNGameOptions.UseTransparentBackground = true;
            this.BTNGameOptions.Click += new System.EventHandler(this.BTNGameOptions_Click);
            // 
            // pnlQuiz
            // 
            this.pnlQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.pnlQuiz.Controls.Add(this.guna2PictureBox2);
            this.pnlQuiz.Controls.Add(this.guna2PictureBox1);
            this.pnlQuiz.Controls.Add(this.IBTNStart);
            this.pnlQuiz.Controls.Add(this.PBPlayerAnswerStatus2);
            this.pnlQuiz.Controls.Add(this.PBPlayerAnswerStatus1);
            this.pnlQuiz.Controls.Add(this.CPBProblemDuration);
            this.pnlQuiz.Controls.Add(this.TXTBMathProblem);
            this.pnlQuiz.Controls.Add(this.TXTBPlayerAnswer);
            this.pnlQuiz.Controls.Add(this.BTNGameResults);
            this.pnlQuiz.Controls.Add(this.BTNGameOptions);
            this.pnlQuiz.Controls.Add(this.IBTNNext);
            this.pnlQuiz.Controls.Add(this.IBTNRestart);
            this.pnlQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuiz.Location = new System.Drawing.Point(0, 0);
            this.pnlQuiz.Name = "pnlQuiz";
            this.pnlQuiz.Size = new System.Drawing.Size(803, 455);
            this.pnlQuiz.TabIndex = 8;
            // 
            // CPBProblemDuration
            // 
            this.CPBProblemDuration.Controls.Add(this.PBThinking);
            this.CPBProblemDuration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.CPBProblemDuration.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CPBProblemDuration.ForeColor = System.Drawing.Color.White;
            this.CPBProblemDuration.Location = new System.Drawing.Point(343, 42);
            this.CPBProblemDuration.Maximum = 60;
            this.CPBProblemDuration.Minimum = 0;
            this.CPBProblemDuration.Name = "CPBProblemDuration";
            this.CPBProblemDuration.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CPBProblemDuration.Size = new System.Drawing.Size(89, 89);
            this.CPBProblemDuration.TabIndex = 13;
            this.CPBProblemDuration.Value = 60;
            // 
            // TXTBMathProblem
            // 
            this.TXTBMathProblem.BorderRadius = 15;
            this.TXTBMathProblem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTBMathProblem.DefaultText = "";
            this.TXTBMathProblem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTBMathProblem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTBMathProblem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTBMathProblem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTBMathProblem.FillColor = System.Drawing.Color.DarkGray;
            this.TXTBMathProblem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTBMathProblem.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.TXTBMathProblem.ForeColor = System.Drawing.Color.Black;
            this.TXTBMathProblem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTBMathProblem.Location = new System.Drawing.Point(270, 169);
            this.TXTBMathProblem.Margin = new System.Windows.Forms.Padding(5);
            this.TXTBMathProblem.Name = "TXTBMathProblem";
            this.TXTBMathProblem.PasswordChar = '\0';
            this.TXTBMathProblem.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TXTBMathProblem.PlaceholderText = "Math Problem";
            this.TXTBMathProblem.ReadOnly = true;
            this.TXTBMathProblem.SelectedText = "";
            this.TXTBMathProblem.Size = new System.Drawing.Size(235, 65);
            this.TXTBMathProblem.TabIndex = 12;
            this.TXTBMathProblem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTBPlayerAnswer
            // 
            this.TXTBPlayerAnswer.BorderRadius = 15;
            this.TXTBPlayerAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTBPlayerAnswer.DefaultText = "";
            this.TXTBPlayerAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTBPlayerAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTBPlayerAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTBPlayerAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTBPlayerAnswer.FillColor = System.Drawing.Color.DarkGray;
            this.TXTBPlayerAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTBPlayerAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TXTBPlayerAnswer.ForeColor = System.Drawing.Color.Black;
            this.TXTBPlayerAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTBPlayerAnswer.Location = new System.Drawing.Point(303, 272);
            this.TXTBPlayerAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTBPlayerAnswer.Name = "TXTBPlayerAnswer";
            this.TXTBPlayerAnswer.PasswordChar = '\0';
            this.TXTBPlayerAnswer.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TXTBPlayerAnswer.PlaceholderText = "Answer";
            this.TXTBPlayerAnswer.SelectedText = "";
            this.TXTBPlayerAnswer.Size = new System.Drawing.Size(169, 41);
            this.TXTBPlayerAnswer.TabIndex = 0;
            this.TXTBPlayerAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTBPlayerAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBPlayerAnswer_KeyPress);
            // 
            // BTNGameResults
            // 
            this.BTNGameResults.BackColor = System.Drawing.Color.Transparent;
            this.BTNGameResults.BorderColor = System.Drawing.Color.White;
            this.BTNGameResults.BorderRadius = 15;
            this.BTNGameResults.BorderThickness = 1;
            this.BTNGameResults.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNGameResults.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNGameResults.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNGameResults.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNGameResults.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNGameResults.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.BTNGameResults.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(104)))), ((int)(((byte)(110)))));
            this.BTNGameResults.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTNGameResults.ForeColor = System.Drawing.Color.White;
            this.BTNGameResults.Location = new System.Drawing.Point(599, 371);
            this.BTNGameResults.Name = "BTNGameResults";
            this.BTNGameResults.Size = new System.Drawing.Size(126, 37);
            this.BTNGameResults.TabIndex = 8;
            this.BTNGameResults.Text = "Game Results";
            this.BTNGameResults.UseTransparentBackground = true;
            this.BTNGameResults.Click += new System.EventHandler(this.BTNGameResults_Click);
            // 
            // Problem_Timer
            // 
            this.Problem_Timer.Interval = 1000;
            this.Problem_Timer.Tick += new System.EventHandler(this.Problem_Timer_Tick);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Math_Game.Properties.Resources.book;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(65, 21);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(128, 119);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 24;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Math_Game.Properties.Resources._123;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(597, 21);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 119);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 23;
            this.guna2PictureBox1.TabStop = false;
            // 
            // IBTNStart
            // 
            this.IBTNStart.BackColor = System.Drawing.Color.Transparent;
            this.IBTNStart.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBTNStart.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBTNStart.Image = global::Math_Game.Properties.Resources.Start;
            this.IBTNStart.ImageOffset = new System.Drawing.Point(0, 0);
            this.IBTNStart.ImageRotate = 0F;
            this.IBTNStart.Location = new System.Drawing.Point(343, 341);
            this.IBTNStart.Name = "IBTNStart";
            this.IBTNStart.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBTNStart.Size = new System.Drawing.Size(89, 67);
            this.IBTNStart.TabIndex = 19;
            this.IBTNStart.Click += new System.EventHandler(this.IBTNStart_Click);
            // 
            // PBPlayerAnswerStatus2
            // 
            this.PBPlayerAnswerStatus2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.PBPlayerAnswerStatus2.ImageRotate = 0F;
            this.PBPlayerAnswerStatus2.Location = new System.Drawing.Point(65, 185);
            this.PBPlayerAnswerStatus2.Name = "PBPlayerAnswerStatus2";
            this.PBPlayerAnswerStatus2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PBPlayerAnswerStatus2.Size = new System.Drawing.Size(128, 128);
            this.PBPlayerAnswerStatus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPlayerAnswerStatus2.TabIndex = 16;
            this.PBPlayerAnswerStatus2.TabStop = false;
            // 
            // PBPlayerAnswerStatus1
            // 
            this.PBPlayerAnswerStatus1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.PBPlayerAnswerStatus1.ImageRotate = 0F;
            this.PBPlayerAnswerStatus1.Location = new System.Drawing.Point(597, 185);
            this.PBPlayerAnswerStatus1.Name = "PBPlayerAnswerStatus1";
            this.PBPlayerAnswerStatus1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PBPlayerAnswerStatus1.Size = new System.Drawing.Size(128, 128);
            this.PBPlayerAnswerStatus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPlayerAnswerStatus1.TabIndex = 15;
            this.PBPlayerAnswerStatus1.TabStop = false;
            // 
            // PBThinking
            // 
            this.PBThinking.BackColor = System.Drawing.Color.Transparent;
            this.PBThinking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.PBThinking.ImageRotate = 0F;
            this.PBThinking.Location = new System.Drawing.Point(17, 17);
            this.PBThinking.Name = "PBThinking";
            this.PBThinking.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PBThinking.Size = new System.Drawing.Size(53, 53);
            this.PBThinking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBThinking.TabIndex = 17;
            this.PBThinking.TabStop = false;
            this.PBThinking.UseTransparentBackground = true;
            // 
            // IBTNNext
            // 
            this.IBTNNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBTNNext.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBTNNext.Image = global::Math_Game.Properties.Resources.Next;
            this.IBTNNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.IBTNNext.ImageRotate = 0F;
            this.IBTNNext.Location = new System.Drawing.Point(343, 341);
            this.IBTNNext.Name = "IBTNNext";
            this.IBTNNext.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBTNNext.Size = new System.Drawing.Size(89, 67);
            this.IBTNNext.TabIndex = 20;
            this.IBTNNext.Click += new System.EventHandler(this.IBTNNext_Click);
            // 
            // IBTNRestart
            // 
            this.IBTNRestart.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBTNRestart.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBTNRestart.Image = global::Math_Game.Properties.Resources.Restart;
            this.IBTNRestart.ImageOffset = new System.Drawing.Point(0, 0);
            this.IBTNRestart.ImageRotate = 0F;
            this.IBTNRestart.Location = new System.Drawing.Point(343, 341);
            this.IBTNRestart.Name = "IBTNRestart";
            this.IBTNRestart.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.IBTNRestart.Size = new System.Drawing.Size(89, 67);
            this.IBTNRestart.TabIndex = 21;
            this.IBTNRestart.Click += new System.EventHandler(this.IBTNRestart_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(803, 455);
            this.Controls.Add(this.pnlQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.pnlQuiz.ResumeLayout(false);
            this.CPBProblemDuration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlayerAnswerStatus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlayerAnswerStatus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBThinking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton BTNGameOptions;
        private Guna.UI2.WinForms.Guna2Panel pnlQuiz;
        private Guna.UI2.WinForms.Guna2GradientButton BTNGameResults;
        private Guna.UI2.WinForms.Guna2TextBox TXTBPlayerAnswer;
        private Guna.UI2.WinForms.Guna2TextBox TXTBMathProblem;
        private System.Windows.Forms.Timer Problem_Timer;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CPBProblemDuration;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PBThinking;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PBPlayerAnswerStatus2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PBPlayerAnswerStatus1;
        private Guna.UI2.WinForms.Guna2ImageButton IBTNStart;
        private Guna.UI2.WinForms.Guna2ImageButton IBTNNext;
        private Guna.UI2.WinForms.Guna2ImageButton IBTNRestart;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}