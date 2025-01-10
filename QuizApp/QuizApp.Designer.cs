namespace QuizApp
{
    partial class QuizApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBQuestionNumber = new System.Windows.Forms.Label();
            this.BTNCheck = new System.Windows.Forms.Button();
            this.BTNNextQuestion = new System.Windows.Forms.Button();
            this.BTNStartQuiz = new System.Windows.Forms.Button();
            this.BTNFalse = new System.Windows.Forms.Button();
            this.TXTBQuestion = new System.Windows.Forms.TextBox();
            this.RBTNFalse = new System.Windows.Forms.RadioButton();
            this.BTNTrue = new System.Windows.Forms.Button();
            this.RBTNTrue = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RBTNDataBaseSection = new System.Windows.Forms.RadioButton();
            this.RBTNDataStructureSection = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBQuestionTimer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.LBQuestionTimer);
            this.panel1.Controls.Add(this.LBQuestionNumber);
            this.panel1.Controls.Add(this.BTNCheck);
            this.panel1.Controls.Add(this.BTNNextQuestion);
            this.panel1.Controls.Add(this.BTNStartQuiz);
            this.panel1.Controls.Add(this.BTNFalse);
            this.panel1.Controls.Add(this.TXTBQuestion);
            this.panel1.Controls.Add(this.RBTNFalse);
            this.panel1.Controls.Add(this.BTNTrue);
            this.panel1.Controls.Add(this.RBTNTrue);
            this.panel1.Location = new System.Drawing.Point(119, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 283);
            this.panel1.TabIndex = 2;
            // 
            // LBQuestionNumber
            // 
            this.LBQuestionNumber.AutoSize = true;
            this.LBQuestionNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBQuestionNumber.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBQuestionNumber.Location = new System.Drawing.Point(-5, 0);
            this.LBQuestionNumber.Name = "LBQuestionNumber";
            this.LBQuestionNumber.Size = new System.Drawing.Size(48, 28);
            this.LBQuestionNumber.TabIndex = 27;
            this.LBQuestionNumber.Text = "0/0";
            this.LBQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBQuestionNumber.Visible = false;
            // 
            // BTNCheck
            // 
            this.BTNCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNCheck.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BTNCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCheck.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCheck.Location = new System.Drawing.Point(455, 252);
            this.BTNCheck.Name = "BTNCheck";
            this.BTNCheck.Size = new System.Drawing.Size(73, 31);
            this.BTNCheck.TabIndex = 23;
            this.BTNCheck.Text = "Check";
            this.BTNCheck.UseVisualStyleBackColor = false;
            this.BTNCheck.Visible = false;
            this.BTNCheck.Click += new System.EventHandler(this.BTNCheck_Click);
            // 
            // BTNNextQuestion
            // 
            this.BTNNextQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNNextQuestion.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BTNNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNextQuestion.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNextQuestion.Location = new System.Drawing.Point(455, 252);
            this.BTNNextQuestion.Name = "BTNNextQuestion";
            this.BTNNextQuestion.Size = new System.Drawing.Size(73, 31);
            this.BTNNextQuestion.TabIndex = 21;
            this.BTNNextQuestion.Text = "Next";
            this.BTNNextQuestion.UseVisualStyleBackColor = false;
            this.BTNNextQuestion.Visible = false;
            this.BTNNextQuestion.Click += new System.EventHandler(this.BTNNextQuestion_Click);
            // 
            // BTNStartQuiz
            // 
            this.BTNStartQuiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNStartQuiz.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BTNStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNStartQuiz.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNStartQuiz.Location = new System.Drawing.Point(160, 106);
            this.BTNStartQuiz.Name = "BTNStartQuiz";
            this.BTNStartQuiz.Size = new System.Drawing.Size(200, 46);
            this.BTNStartQuiz.TabIndex = 21;
            this.BTNStartQuiz.Text = "Start Quiz";
            this.BTNStartQuiz.UseVisualStyleBackColor = false;
            this.BTNStartQuiz.Click += new System.EventHandler(this.BTNStartQuiz_Click);
            // 
            // BTNFalse
            // 
            this.BTNFalse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNFalse.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BTNFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNFalse.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFalse.Location = new System.Drawing.Point(160, 214);
            this.BTNFalse.Name = "BTNFalse";
            this.BTNFalse.Size = new System.Drawing.Size(200, 46);
            this.BTNFalse.TabIndex = 1;
            this.BTNFalse.Text = "False";
            this.BTNFalse.UseVisualStyleBackColor = false;
            this.BTNFalse.Visible = false;
            this.BTNFalse.Click += new System.EventHandler(this.BTNFalse_Click);
            // 
            // TXTBQuestion
            // 
            this.TXTBQuestion.BackColor = System.Drawing.Color.SlateGray;
            this.TXTBQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTBQuestion.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBQuestion.Location = new System.Drawing.Point(25, 30);
            this.TXTBQuestion.Multiline = true;
            this.TXTBQuestion.Name = "TXTBQuestion";
            this.TXTBQuestion.ReadOnly = true;
            this.TXTBQuestion.Size = new System.Drawing.Size(479, 122);
            this.TXTBQuestion.TabIndex = 20;
            this.TXTBQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RBTNFalse
            // 
            this.RBTNFalse.AutoSize = true;
            this.RBTNFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNFalse.Location = new System.Drawing.Point(229, 226);
            this.RBTNFalse.Name = "RBTNFalse";
            this.RBTNFalse.Size = new System.Drawing.Size(57, 22);
            this.RBTNFalse.TabIndex = 28;
            this.RBTNFalse.TabStop = true;
            this.RBTNFalse.Text = "false";
            this.RBTNFalse.UseVisualStyleBackColor = true;
            this.RBTNFalse.Visible = false;
            // 
            // BTNTrue
            // 
            this.BTNTrue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNTrue.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BTNTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNTrue.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTrue.Location = new System.Drawing.Point(160, 162);
            this.BTNTrue.Name = "BTNTrue";
            this.BTNTrue.Size = new System.Drawing.Size(200, 46);
            this.BTNTrue.TabIndex = 0;
            this.BTNTrue.Text = "True";
            this.BTNTrue.UseVisualStyleBackColor = false;
            this.BTNTrue.Visible = false;
            this.BTNTrue.Click += new System.EventHandler(this.BTNTrue_Click);
            // 
            // RBTNTrue
            // 
            this.RBTNTrue.AutoSize = true;
            this.RBTNTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNTrue.Location = new System.Drawing.Point(229, 174);
            this.RBTNTrue.Name = "RBTNTrue";
            this.RBTNTrue.Size = new System.Drawing.Size(51, 22);
            this.RBTNTrue.TabIndex = 27;
            this.RBTNTrue.TabStop = true;
            this.RBTNTrue.Text = "true";
            this.RBTNTrue.UseVisualStyleBackColor = true;
            this.RBTNTrue.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.RBTNDataBaseSection);
            this.panel2.Controls.Add(this.RBTNDataStructureSection);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(119, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 64);
            this.panel2.TabIndex = 22;
            // 
            // RBTNDataBaseSection
            // 
            this.RBTNDataBaseSection.AutoSize = true;
            this.RBTNDataBaseSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNDataBaseSection.Location = new System.Drawing.Point(273, 23);
            this.RBTNDataBaseSection.Name = "RBTNDataBaseSection";
            this.RBTNDataBaseSection.Size = new System.Drawing.Size(91, 22);
            this.RBTNDataBaseSection.TabIndex = 26;
            this.RBTNDataBaseSection.TabStop = true;
            this.RBTNDataBaseSection.Text = "DataBase";
            this.RBTNDataBaseSection.UseVisualStyleBackColor = true;
            // 
            // RBTNDataStructureSection
            // 
            this.RBTNDataStructureSection.AutoSize = true;
            this.RBTNDataStructureSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNDataStructureSection.Location = new System.Drawing.Point(383, 23);
            this.RBTNDataStructureSection.Name = "RBTNDataStructureSection";
            this.RBTNDataStructureSection.Size = new System.Drawing.Size(121, 22);
            this.RBTNDataStructureSection.TabIndex = 25;
            this.RBTNDataStructureSection.TabStop = true;
            this.RBTNDataStructureSection.Text = "Data Structure";
            this.RBTNDataStructureSection.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sections";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBQuestionTimer
            // 
            this.LBQuestionTimer.AutoSize = true;
            this.LBQuestionTimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBQuestionTimer.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBQuestionTimer.Location = new System.Drawing.Point(244, -1);
            this.LBQuestionTimer.Name = "LBQuestionTimer";
            this.LBQuestionTimer.Size = new System.Drawing.Size(36, 28);
            this.LBQuestionTimer.TabIndex = 29;
            this.LBQuestionTimer.Text = "30";
            this.LBQuestionTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBQuestionTimer.Visible = false;
            // 
            // QuizApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuizApp";
            this.Text = "Quiz App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTBQuestion;
        private System.Windows.Forms.Button BTNTrue;
        private System.Windows.Forms.Button BTNFalse;
        private System.Windows.Forms.Button BTNNextQuestion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBTNDataBaseSection;
        private System.Windows.Forms.RadioButton RBTNDataStructureSection;
        private System.Windows.Forms.Button BTNStartQuiz;
        private System.Windows.Forms.RadioButton RBTNFalse;
        private System.Windows.Forms.RadioButton RBTNTrue;
        private System.Windows.Forms.Button BTNCheck;
        private System.Windows.Forms.Label LBQuestionNumber;
        private System.Windows.Forms.Label LBQuestionTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

