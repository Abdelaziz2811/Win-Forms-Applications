using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class FGameResults : Form
    {
        public FGameResults()
        {
            InitializeComponent();
        }

        private void FGameResults_Load(object sender, EventArgs e)
        {
            DisplayQuizResults();
        }

        void DisplayQuizInfo()
        {
            LBRounds.Text = Options.GameOptions.GameRounds.ToString();
            LBProblemsLevel.Text = Quiz.MathProblem.ProblemLevel.ToString();
            LBOperationsType.Text = Quiz.MathProblem.Operation.ToString();
            LBRightAnswers.Text = Quiz.Player.RightAnswers.ToString();
            LBWrongAnswers.Text = Quiz.Player.WrongAnswers.ToString();
            LBSkippedAnswers.Text = (Options.GameOptions.GameRounds - (Quiz.Player.RightAnswers + Quiz.Player.WrongAnswers)).ToString();
        }

        void PlayerFinalResult()
        {
            if (Quiz.Player.RightAnswers == Options.GameOptions.GameRounds)
            {
                PBPlayerFinalResult.Image = Properties.Resources.A_;
                Success();
            }

            if (Quiz.Player.RightAnswers >= Quiz.Player.WrongAnswers)
            {
                PBPlayerFinalResult.Image = Properties.Resources.Pass;
                Success();
            }

            if (Quiz.Player.RightAnswers < Quiz.Player.WrongAnswers)
            {
                PBPlayerFinalResult.Image = Properties.Resources.Fail;
            }

            if (Quiz.Player.SkippedAnswers == Options.GameOptions.GameRounds)
            {
                PBPlayerFinalResult.Image = Properties.Resources.Fail;
            }
        }

        void DisplayQuizResults()
        {
            DisplayQuizInfo();
            PlayerFinalResult();
        }

        void Success()
        {
            PBSuccess.Image = Properties.Resources.Success;
            PB2Success.Image = Properties.Resources.Success;
        }
    }
}
