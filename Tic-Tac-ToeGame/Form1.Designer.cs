namespace Tic_Tac_ToeGame
{
    partial class TicTacToeGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBPlayer1Turn = new System.Windows.Forms.Label();
            this.LBPlayer2Turn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBIsWinnerPlayer1 = new System.Windows.Forms.Label();
            this.LBIsWinnerPlayer2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNRestart = new System.Windows.Forms.Button();
            this.BTNReplay = new System.Windows.Forms.Button();
            this.LBPlayer1WinTimes = new System.Windows.Forms.Label();
            this.LBPlayer2WinTimes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNEndGame = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // LBPlayer1Turn
            // 
            this.LBPlayer1Turn.AutoSize = true;
            this.LBPlayer1Turn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LBPlayer1Turn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBPlayer1Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBPlayer1Turn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPlayer1Turn.Location = new System.Drawing.Point(45, 147);
            this.LBPlayer1Turn.Name = "LBPlayer1Turn";
            this.LBPlayer1Turn.Size = new System.Drawing.Size(105, 52);
            this.LBPlayer1Turn.TabIndex = 10;
            this.LBPlayer1Turn.Tag = "x";
            this.LBPlayer1Turn.Text = "Player 1 \r\n   Turn";
            // 
            // LBPlayer2Turn
            // 
            this.LBPlayer2Turn.AutoSize = true;
            this.LBPlayer2Turn.BackColor = System.Drawing.Color.DarkGray;
            this.LBPlayer2Turn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBPlayer2Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBPlayer2Turn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPlayer2Turn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LBPlayer2Turn.Location = new System.Drawing.Point(543, 147);
            this.LBPlayer2Turn.Name = "LBPlayer2Turn";
            this.LBPlayer2Turn.Size = new System.Drawing.Size(105, 52);
            this.LBPlayer2Turn.TabIndex = 11;
            this.LBPlayer2Turn.Tag = "o";
            this.LBPlayer2Turn.Text = "Player 2 \r\n   Turn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Winner";
            // 
            // LBIsWinnerPlayer1
            // 
            this.LBIsWinnerPlayer1.AutoSize = true;
            this.LBIsWinnerPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBIsWinnerPlayer1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBIsWinnerPlayer1.Location = new System.Drawing.Point(31, 251);
            this.LBIsWinnerPlayer1.Name = "LBIsWinnerPlayer1";
            this.LBIsWinnerPlayer1.Size = new System.Drawing.Size(133, 25);
            this.LBIsWinnerPlayer1.TabIndex = 13;
            this.LBIsWinnerPlayer1.Text = "In Progress";
            this.LBIsWinnerPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBIsWinnerPlayer2
            // 
            this.LBIsWinnerPlayer2.AutoSize = true;
            this.LBIsWinnerPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBIsWinnerPlayer2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBIsWinnerPlayer2.Location = new System.Drawing.Point(529, 251);
            this.LBIsWinnerPlayer2.Name = "LBIsWinnerPlayer2";
            this.LBIsWinnerPlayer2.Size = new System.Drawing.Size(133, 25);
            this.LBIsWinnerPlayer2.TabIndex = 15;
            this.LBIsWinnerPlayer2.Text = "In Progress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Winner";
            // 
            // BTNRestart
            // 
            this.BTNRestart.FlatAppearance.BorderSize = 2;
            this.BTNRestart.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BTNRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRestart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRestart.Location = new System.Drawing.Point(543, 63);
            this.BTNRestart.Name = "BTNRestart";
            this.BTNRestart.Size = new System.Drawing.Size(105, 45);
            this.BTNRestart.TabIndex = 16;
            this.BTNRestart.Text = "Restart";
            this.BTNRestart.UseVisualStyleBackColor = true;
            this.BTNRestart.Click += new System.EventHandler(this.BTNRestart_Click);
            // 
            // BTNReplay
            // 
            this.BTNReplay.FlatAppearance.BorderSize = 2;
            this.BTNReplay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNReplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BTNReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNReplay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNReplay.Location = new System.Drawing.Point(45, 63);
            this.BTNReplay.Name = "BTNReplay";
            this.BTNReplay.Size = new System.Drawing.Size(105, 45);
            this.BTNReplay.TabIndex = 17;
            this.BTNReplay.Text = "Replay";
            this.BTNReplay.UseVisualStyleBackColor = true;
            this.BTNReplay.Click += new System.EventHandler(this.BTNReplay_Click);
            // 
            // LBPlayer1WinTimes
            // 
            this.LBPlayer1WinTimes.AutoSize = true;
            this.LBPlayer1WinTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBPlayer1WinTimes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPlayer1WinTimes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBPlayer1WinTimes.Location = new System.Drawing.Point(82, 362);
            this.LBPlayer1WinTimes.Name = "LBPlayer1WinTimes";
            this.LBPlayer1WinTimes.Size = new System.Drawing.Size(25, 25);
            this.LBPlayer1WinTimes.TabIndex = 18;
            this.LBPlayer1WinTimes.Tag = "";
            this.LBPlayer1WinTimes.Text = "0";
            // 
            // LBPlayer2WinTimes
            // 
            this.LBPlayer2WinTimes.AutoSize = true;
            this.LBPlayer2WinTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBPlayer2WinTimes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPlayer2WinTimes.Location = new System.Drawing.Point(581, 362);
            this.LBPlayer2WinTimes.Name = "LBPlayer2WinTimes";
            this.LBPlayer2WinTimes.Size = new System.Drawing.Size(25, 25);
            this.LBPlayer2WinTimes.TabIndex = 19;
            this.LBPlayer2WinTimes.Tag = "";
            this.LBPlayer2WinTimes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 50);
            this.label2.TabIndex = 20;
            this.label2.Text = "Player 1 Win \r\n     Times";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 50);
            this.label3.TabIndex = 21;
            this.label3.Text = "Player 2 Win \r\n     Times";
            // 
            // BTNEndGame
            // 
            this.BTNEndGame.FlatAppearance.BorderSize = 2;
            this.BTNEndGame.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNEndGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BTNEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEndGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEndGame.Location = new System.Drawing.Point(298, 413);
            this.BTNEndGame.Name = "BTNEndGame";
            this.BTNEndGame.Size = new System.Drawing.Size(105, 45);
            this.BTNEndGame.TabIndex = 22;
            this.BTNEndGame.Text = "End Game";
            this.BTNEndGame.UseVisualStyleBackColor = true;
            this.BTNEndGame.Click += new System.EventHandler(this.BTNEndGame_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGray;
            this.button9.BackgroundImage = global::Tic_Tac_ToeGame.Properties.Resources.icon_1332777_1920;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(414, 317);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 70);
            this.button9.TabIndex = 9;
            this.button9.Text = " ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGray;
            this.button8.BackgroundImage = global::Tic_Tac_ToeGame.Properties.Resources.icon_1332777_1920;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(311, 317);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 70);
            this.button8.TabIndex = 8;
            this.button8.Text = " ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGray;
            this.button7.BackgroundImage = global::Tic_Tac_ToeGame.Properties.Resources.icon_1332777_1920;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(208, 317);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 70);
            this.button7.TabIndex = 7;
            this.button7.Text = " ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.BackgroundImage = global::Tic_Tac_ToeGame.Properties.Resources.icon_1332777_1920;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(414, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 70);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.BackgroundImage = global::Tic_Tac_ToeGame.Properties.Resources.icon_1332777_1920;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(311, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 70);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.BackgroundImage = global::Tic_Tac_ToeGame.Properties.Resources.icon_1332777_1920;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(208, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 70);
            this.button4.TabIndex = 4;
            this.button4.Text = " ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.BackgroundImage = global::Tic_Tac_ToeGame.Properties.Resources.icon_1332777_1920;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(414, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 70);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Tic_Tac_ToeGame.Properties.Resources.icon_1332777_1920;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(311, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 70);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.BackgroundImage = global::Tic_Tac_ToeGame.Properties.Resources.icon_1332777_1920;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(209, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // TicTacToeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(728, 479);
            this.Controls.Add(this.BTNEndGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBPlayer2WinTimes);
            this.Controls.Add(this.LBPlayer1WinTimes);
            this.Controls.Add(this.BTNReplay);
            this.Controls.Add(this.BTNRestart);
            this.Controls.Add(this.LBIsWinnerPlayer2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LBIsWinnerPlayer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBPlayer2Turn);
            this.Controls.Add(this.LBPlayer1Turn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "TicTacToeGame";
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TicTacToeGame_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label LBPlayer1Turn;
        private System.Windows.Forms.Label LBPlayer2Turn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBIsWinnerPlayer1;
        private System.Windows.Forms.Label LBIsWinnerPlayer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTNRestart;
        private System.Windows.Forms.Button BTNReplay;
        private System.Windows.Forms.Label LBPlayer1WinTimes;
        private System.Windows.Forms.Label LBPlayer2WinTimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNEndGame;
    }
}

