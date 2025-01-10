using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace QuizApp
{
    public partial class QuizApp : Form
    {
        public QuizApp()
        {
            InitializeComponent();
        }

        struct StQuestionParts
        {
            public string Question;
            public string IsTrue;
        }
        
        List<StQuestionParts> LoadDataStructureQuestions()
        {
            StreamReader Reader = new StreamReader(@"C:\Users\Abdelaziz\source\repos\QuizApp\DataStructure.txt");
            
            string Line;
            
            List <StQuestionParts> DataStructureQuestions = new List<StQuestionParts>();
            
            string[] questionParts;

            StQuestionParts QuestionParts;

            while ((Line = Reader.ReadLine()) != null)
            {
                questionParts = Line.Split('#');

                QuestionParts.Question = questionParts[0];
                QuestionParts.IsTrue = questionParts[1];

                DataStructureQuestions.Add(QuestionParts);
            }

            return DataStructureQuestions;
        }

        List<StQuestionParts> LoadDataBaseQuestions()
        {
            StreamReader Reader = new StreamReader(@"C:\Users\Abdelaziz\source\repos\QuizApp\DataBase.txt");

            string Line;

            List<StQuestionParts> DataStructureQuestions = new List<StQuestionParts>();

            string[] questionParts;

            StQuestionParts QuestionParts;

            while ((Line = Reader.ReadLine()) != null)
            {
                questionParts = Line.Split('#');

                QuestionParts.Question = questionParts[0];
                QuestionParts.IsTrue = questionParts[1];

                DataStructureQuestions.Add(QuestionParts);
            }

            return DataStructureQuestions;
        }

        static byte i = 0;
        
        void ShowQuestions(List<StQuestionParts> Questions)
        {
            if (Questions.Count != 0)
                TXTBQuestion.Text = Questions[i].Question;
        }

        bool IsSomeSectionSelected()
        {
            if (RBTNDataBaseSection.Checked || RBTNDataStructureSection.Checked)
                return true;
            else
            {
                MessageBox.Show("Select a section to start the quiz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void SetButtons()
        {
            BTNStartQuiz.Visible = false;
   
            BTNTrue.Visible = true;
            BTNFalse.Visible = true;
            LBQuestionTimer.Visible = true;
        }

        List<StQuestionParts> Questions;

        bool IsQuizStarted = false;

        private void BTNStartQuiz_Click(object sender, EventArgs e)
        {
            if (!IsSomeSectionSelected())
                return;

            IsQuizStarted = true;
            QuestionTimer = 30;

            SetButtons();

            if (RBTNDataStructureSection.Checked)
            {
                Questions = LoadDataStructureQuestions();
                ShowQuestions(Questions);
            }
            else if (RBTNDataBaseSection.Checked)
            {
                Questions = LoadDataBaseQuestions();
                ShowQuestions(Questions);
            }   
        }

        void QuizComplete()
        {
            BTNTrue.Visible = false;
            BTNFalse.Visible = false;

            BTNStartQuiz.Visible = true;
            TXTBQuestion.Text = string.Empty;

            i = 0;
            RightAnswerCount = 0;

            LBQuestionNumber.Visible = false;
            LBQuestionTimer.Visible = false;
        }

        void UpdateButtonsProperies()
        {
            BTNTrue.Enabled = true;
            BTNFalse.Enabled = true;

            BTNNextQuestion.Visible = false;
            BTNTrue.FlatAppearance.BorderColor = Color.DodgerBlue;
            BTNFalse.FlatAppearance.BorderColor = Color.DodgerBlue;
        }

        void UpdateLBQuestionNumber()
        {
            if (LBQuestionNumber.Visible == false) LBQuestionNumber.Visible = true;
            LBQuestionNumber.Text = $"{i}/{Questions.Count}";
        }

        void MoveToNextQuestion()
        {
            i++;
            QuestionTimer = 30;

            if (i < Questions.Count)
                ShowQuestions(Questions);

            UpdateButtonsProperies();

            UpdateLBQuestionNumber();

            if (i == Questions.Count)
            {
                MessageBox.Show($"Quiz Completed\nYou Scored {RightAnswerCount}/{Questions.Count}"
                    , "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuizComplete();
                return;
            }
        }

        private void BTNNextQuestion_Click(object sender, EventArgs e)
        {
            MoveToNextQuestion();
        }

        private void BTNTrue_Click(object sender, EventArgs e)
        {
            RBTNTrue.Checked = true;
            BTNCheck.Visible = true;
        }

        private void BTNFalse_Click(object sender, EventArgs e)
        {
            RBTNFalse.Checked = true;
            BTNCheck.Visible = true;
        }

        byte RightAnswerCount = 0;

        private void BTNCheck_Click(object sender, EventArgs e)
        {
            if (RBTNTrue.Checked)
            {
                if (Convert.ToBoolean(Questions[i].IsTrue))
                {
                    BTNTrue.FlatAppearance.BorderColor = Color.Lime;

                    BTNTrue.Enabled = false;
                    BTNFalse.Enabled = false;
                    RightAnswerCount++;
                }
                else
                {
                    BTNTrue.FlatAppearance.BorderColor = Color.Red;

                    BTNTrue.Enabled = false;
                    BTNFalse.Enabled = false;
                }

                BTNNextQuestion.Visible = true;
                BTNCheck.Visible = false;
            }
            else if (RBTNFalse.Checked)
            {
                if (!(Convert.ToBoolean(Questions[i].IsTrue)))
                {
                    BTNFalse.FlatAppearance.BorderColor = Color.Lime;

                    BTNTrue.Enabled = false;
                    BTNFalse.Enabled = false;
                    RightAnswerCount++;
                }
                else
                {
                    BTNFalse.FlatAppearance.BorderColor = Color.Red;

                    BTNTrue.Enabled = false;
                    BTNFalse.Enabled = false;
                }

                BTNNextQuestion.Visible = true;
                BTNCheck.Visible = false;
            }
        }

        byte QuestionTimer = 30;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!IsQuizStarted)
                return;

            QuestionTimer--;
            LBQuestionTimer.Text = QuestionTimer.ToString();

            if (QuestionTimer == 0)
            {
                MoveToNextQuestion();
            }
        }
    }
}
