using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Math_Game.Options;

namespace Math_Game
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            if (MathProblem.Rounds == 0)
            {
                Problem.ResetPropertiesValuesToGameOptionsValues();
                MathProblem.Rounds = GameOptions.GameRounds;
            }
        }

        void LoadForm(object FormObj)
        {
            if (this.pnlQuiz.Controls.Count > 0)
            {
                this.pnlQuiz.Controls.Clear();
            }
            
            Form NewForm = FormObj as Form;
            NewForm.TopLevel = false;
            NewForm.Dock = DockStyle.Fill;
            NewForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlQuiz.Controls.Add(NewForm);
            NewForm.Show();
        }

        private void BTNGameOptions_Click(object sender, EventArgs e)
        {
            Problem_Timer.Stop();
            Options options = new Options();
            LoadForm(options);
        }

        public enum enProblemLevel { Easy, Medium, Hard, Mix }
        public enum enOperation { Addition, Abstraction, Multiplication, Division, Mix }

        public class MathProblem : Options.GameOptions
        {
            Random random = new Random();
            
            public static enProblemLevel ProblemLevel { get; set; } = (enProblemLevel)GameLevel;
            public static enOperation Operation { get; set; } = (enOperation)OperationType;
            public static byte Rounds { get; set; } = GameRounds;
            public byte ProblemDuration { get; set; }
            public int Number1 { get; set; }
            public int Number2 { get; set; }
            public char OperationSymbol { get; set; }
            public string ProblemText { get; set; }

            public int RightAnswer { get; set; }
            public int PlayerAnswer { get; set; }

            public void GenerateMathProblem()
            {
                switch(ProblemLevel.ToString())
                {
                    case "Easy":

                        Number1 = random.Next(1, 10);
                        Number2 = random.Next(1, 10);

                        ProblemDuration = 60;

                        Calculator(Number1, Number2);

                        break;
                    case "Medium":

                        Number1 = random.Next(10, 50);
                        Number2 = random.Next(10, 50);

                        ProblemDuration = 35;

                        Calculator(Number1, Number2);

                        break;
                    case "Hard":

                        Number1 = random.Next(50, 1000);
                        Number2 = random.Next(50, 1000);

                        ProblemDuration = 20;

                        Calculator(Number1, Number2);

                        break;
                    case "Mix":

                        ProblemLevel = (enProblemLevel)random.Next(0, 2);
                        GenerateMathProblem();

                        break;
                }
            }

            public void Calculator(int Number1, int Number2)
            {
                switch(Operation.ToString())
                {
                    case "Addition":
                        
                        RightAnswer = Number1 + Number2;
                        OperationSymbol = '+';
                        SetProblemToText();

                        break;
                    case "Abstraction":

                        RightAnswer = Number1 - Number2;
                        OperationSymbol = '-';
                        SetProblemToText();

                        break;
                    case "Multiplication":

                        RightAnswer = Number1 * Number2;
                        OperationSymbol = '×';
                        SetProblemToText();

                        break;
                    case "Division":

                        RightAnswer = Number1 / Number2;
                        OperationSymbol = '÷';
                        SetProblemToText();

                        break;
                    case "Mix":

                        Operation = (enOperation)random.Next(0, 3);
                        Calculator(Number1, Number2);
                        
                        break;
                }
            }

            public void SetProblemToText()
            {
                ProblemText = Number1.ToString() + ' ' + OperationSymbol + ' ' + Number2.ToString();
            }

            public bool CheckAnswer(MathProblem Problem)
            {
                return Player.PlayerAnswer == Problem.RightAnswer;
            }

            public void ResetPropertiesValuesToGameOptionsValues()
            {
                ProblemLevel = (enProblemLevel)GameLevel;
                Operation = (enOperation)OperationType;
            }
        }

        public static class Player
        {
            public static int PlayerAnswer { get; set; }
            public static int RightAnswers { get; set; } = 0;
            public static int WrongAnswers { get; set; } = 0;
            public static int SkippedAnswers { get; set; } = 0;
        }

        MathProblem Problem = new MathProblem();

        void SetButtonsProperties()
        {
            IBTNStart.Visible = false;
            IBTNNext.Visible = true;
            // Enable the TXT Player Answer after restart the game
            if (TXTBPlayerAnswer.Enabled == false) TXTBPlayerAnswer.Enabled = true;
        }

        void DisplayMathProblems()
        {
            TXTBMathProblem.Text = Problem.ProblemText;
        }

        void EnableProblemTimer()
        {
            Problem_Timer.Enabled = true;
        }

        void SetCPBValues()
        {
            // set Maximum value of circle progress bar
            CPBProblemDuration.Maximum = Problem.ProblemDuration;
            CPBProblemDuration.Value = Problem.ProblemDuration;
        }

        void SetIcons()
        {
            PBThinking.Image = Properties.Resources.Thinking_Time;
            PBPlayerAnswerStatus1.Image = Properties.Resources.Thinking;
            PBPlayerAnswerStatus2.Image = Properties.Resources.Thinking;
        }

        private void IBTNStart_Click(object sender, EventArgs e)
        {
            TXTBPlayerAnswer.Focus();

            SetButtonsProperties();
            SetIcons();
            Problem.GenerateMathProblem();
            DisplayMathProblems();
            EnableProblemTimer();
            SetCPBValues();
        }

        void UpdatePlayerAnswersValues()
        {
            if (Problem.CheckAnswer(Problem)) Player.RightAnswers++;
            else if (TXTBPlayerAnswer.Text == "") Player.SkippedAnswers++;
            else Player.WrongAnswers++;
        }

        private void IBTNNext_Click(object sender, EventArgs e)
        {
            UpdatePlayerAnswersValues();

            MoveToNextProblem();
        }

        void SetCPBColor()
        {
            if (CPBProblemDuration.Value <= Problem.ProblemDuration / 2)
            {
                CPBProblemDuration.ProgressColor = Color.FromArgb(255, 128, 128);
                CPBProblemDuration.ProgressColor2 = Color.FromArgb(255, 128, 128);
            }
        }

        private void Problem_Timer_Tick(object sender, EventArgs e)
        {
            CPBProblemDuration.Value--;
            SetCPBColor();
            if (CPBProblemDuration.Value == 0) MoveToNextProblem();
        }

        void ResetMathProblemPropertiesValues()
        {
            if ((enProblemLevel)GameOptions.GameLevel == enProblemLevel.Mix
             || (enOperation)GameOptions.OperationType == enOperation.Mix)
                Problem.ResetPropertiesValuesToGameOptionsValues();
        }

        void LoadIcons()
        {
            PBThinking.Image = Properties.Resources.Thinking_Time;
            PBPlayerAnswerStatus1.Image = Properties.Resources.Thinking;
            PBPlayerAnswerStatus2.Image = Properties.Resources.Thinking;
        }

        void QuizEnd()
        {
            Problem_Timer.Stop();
            
            PBThinking.Image = null;
            PBPlayerAnswerStatus1.Image = Properties.Resources.Out_Of_Time;
            PBPlayerAnswerStatus2.Image = Properties.Resources.Out_Of_Time;
            CPBProblemDuration.Value = 0;

            TXTBMathProblem.Clear();
            TXTBPlayerAnswer.Clear();

            IBTNNext.Visible = false;
            IBTNRestart.Visible = true;

            TXTBPlayerAnswer.Enabled = false;

            Problem.ResetPropertiesValuesToGameOptionsValues();
        }

        void SetTXTButtonsProperties()
        {
            TXTBMathProblem.Clear();
            TXTBPlayerAnswer.Clear();


            TXTBPlayerAnswer.Focus();
        }

        void ResetTimerColor()
        {
            Problem_Timer.Start();
            CPBProblemDuration.ProgressColor = Color.FromArgb(139, 201, 77);
            CPBProblemDuration.ProgressColor2 = Color.FromArgb(139, 201, 77);
        }

        void MoveToNextProblem()
        {
            ResetTimerColor();
            LoadIcons();
            SetTXTButtonsProperties();

            MathProblem.Rounds--;
            if (MathProblem.Rounds <= 0)
            { Problem_Timer.Stop(); QuizEnd(); return; }

            ResetMathProblemPropertiesValues();
            Problem.GenerateMathProblem();
            DisplayMathProblems();
            SetCPBValues();
        }

        private void TXTBPlayerAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' && TXTBPlayerAnswer.SelectionStart == 0)
                return;

            // Allow only digits and control keys (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block non-numeric input
            }

            // Check if Enter is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the beep sound

                if (int.TryParse(TXTBPlayerAnswer.Text, out int answer)) // Validate numeric input
                {
                    Player.PlayerAnswer = answer;
                    if (Problem.CheckAnswer(Problem))
                    {
                        PBPlayerAnswerStatus1.Image = Properties.Resources.True;
                        PBPlayerAnswerStatus2.Image = Properties.Resources.True;
                        
                        PBThinking.Image = null;
                        Problem_Timer.Stop();
                    }
                    else
                    {
                        PBPlayerAnswerStatus1.Image = Properties.Resources.False;
                        PBPlayerAnswerStatus2.Image = Properties.Resources.False;
                    }
                }
            }
        }

        void ResetPlayerProperties()
        {
            Player.RightAnswers = 0;
            Player.WrongAnswers = 0;
        }

        private void IBTNRestart_Click(object sender, EventArgs e)
        {
            BTNGameOptions.PerformClick();

            ResetPlayerProperties();
        }

        private void BTNGameResults_Click(object sender, EventArgs e)
        {
            Form Frm = new FGameResults();
            Frm.Show();
        }
    }
}
