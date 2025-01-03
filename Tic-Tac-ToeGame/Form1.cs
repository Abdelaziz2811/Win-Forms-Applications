using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_ToeGame.Properties;

namespace Tic_Tac_ToeGame
{
    public partial class TicTacToeGame : Form
    {
        public TicTacToeGame()
        {
            InitializeComponent();
        }

        private void TicTacToeGame_Paint(object sender, PaintEventArgs e)
        {
            Pen Pen = new Pen(Color.Black);
            Pen.Width = 5;

            // Set start/end cap round
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Virtical lines
            e.Graphics.DrawLine(Pen, 300, 100, 300, 400);
            e.Graphics.DrawLine(Pen, 400, 100, 400, 400);

            // Horizontal lines
            e.Graphics.DrawLine(Pen, 200, 200, 500, 200);
            e.Graphics.DrawLine(Pen, 200, 300, 500, 300);

        }

        void UpdatePlayersColorAfterPlayer1Move()
        {
            LBPlayer1Turn.BackColor = Color.DarkGray;
            LBPlayer2Turn.BackColor = Color.DarkSeaGreen;
        }

        void UpdatePlayersColorAfterPlayer2Move()
        {
            LBPlayer2Turn.BackColor = Color.DarkGray;
            LBPlayer1Turn.BackColor = Color.DarkSeaGreen;
        }

        bool IsEmptyButton(string ButtonChar)
        {
            if (ButtonChar == "x" || ButtonChar == "o")
            {
                MessageBox.Show("The Choice is already taken", "Wrong Choice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        char GetWinnerChar()
        {
            if (button1.Tag == button2.Tag && button1.Tag == button3.Tag && Convert.ToString(button1.Tag) != "")
            {
                button1.BackColor = Color.DarkSeaGreen;
                button2.BackColor = Color.DarkSeaGreen;
                button3.BackColor = Color.DarkSeaGreen;

                return Convert.ToChar(button1.Tag);
            }
            if (button4.Tag == button5.Tag && button4.Tag == button6.Tag && Convert.ToString(button4.Tag) != "")
            {
                button4.BackColor = Color.DarkSeaGreen;
                button5.BackColor = Color.DarkSeaGreen;
                button6.BackColor = Color.DarkSeaGreen;

                return Convert.ToChar(button4.Tag);
            }
            if (button7.Tag == button8.Tag && button7.Tag == button9.Tag && Convert.ToString(button7.Tag) != "")
            {
                button7.BackColor = Color.DarkSeaGreen;
                button8.BackColor = Color.DarkSeaGreen;
                button9.BackColor = Color.DarkSeaGreen;

                return Convert.ToChar(button7.Tag);
            }
            if (button1.Tag == button4.Tag && button1.Tag == button7.Tag && Convert.ToString(button1.Tag) != "")
            {
                button1.BackColor = Color.DarkSeaGreen;
                button4.BackColor = Color.DarkSeaGreen;
                button7.BackColor = Color.DarkSeaGreen;

                return Convert.ToChar(button1.Tag);
            }
            if (button2.Tag == button5.Tag && button2.Tag == button8.Tag && Convert.ToString(button2.Tag) != "")
            {
                button2.BackColor = Color.DarkSeaGreen;
                button5.BackColor = Color.DarkSeaGreen;
                button8.BackColor = Color.DarkSeaGreen;

                return Convert.ToChar(button2.Tag);
            }
            if (button3.Tag == button6.Tag && button3.Tag == button9.Tag && Convert.ToString(button3.Tag) != "")
            {
                button3.BackColor = Color.DarkSeaGreen;
                button6.BackColor = Color.DarkSeaGreen;
                button9.BackColor = Color.DarkSeaGreen;

                return Convert.ToChar(button3.Tag);
            }
            if (button1.Tag == button5.Tag && button1.Tag == button9.Tag && Convert.ToString(button1.Tag) != "")
            {
                button1.BackColor = Color.DarkSeaGreen;
                button5.BackColor = Color.DarkSeaGreen;
                button9.BackColor = Color.DarkSeaGreen;

                return Convert.ToChar(button1.Tag);
            }
            if (button3.Tag == button5.Tag && button3.Tag == button7.Tag && Convert.ToString(button3.Tag) != "")
            {
                button3.BackColor = Color.DarkSeaGreen;
                button5.BackColor = Color.DarkSeaGreen;
                button7.BackColor = Color.DarkSeaGreen;

                return Convert.ToChar(button3.Tag);
            }
            if (Convert.ToString(button1.Tag) != "" && Convert.ToString(button2.Tag) != "" && Convert.ToString(button3.Tag) != ""
            && Convert.ToString(button4.Tag) != "" && Convert.ToString(button5.Tag) != "" && Convert.ToString(button6.Tag) != ""
            && Convert.ToString(button7.Tag) != "" && Convert.ToString(button8.Tag) != "" && Convert.ToString(button9.Tag) != "")
            {
                return 'T';
            }
            else
                return ' ';
        }

        bool IsSomePlayerWin(char WinnerChar)
        {
            if (WinnerChar == 'x')
            {
                MessageBox.Show("Player 1 Win", "Player 1", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LBIsWinnerPlayer1.Text = "Player 1 Win";
                LBIsWinnerPlayer1.BackColor = Color.DarkSeaGreen;
                LBIsWinnerPlayer2.Text = "Player 2 Lose";
                LBIsWinnerPlayer2.BackColor = Color.IndianRed;

                LBPlayer1WinTimes.Text = Convert.ToString(Convert.ToByte(LBPlayer1WinTimes.Text) + 1);
                return true;
            }
            else if (WinnerChar == 'o')
            {
                MessageBox.Show("Player 2 Win", "Player 2", MessageBoxButtons.OK,MessageBoxIcon.Information);

                LBIsWinnerPlayer1.Text = "Player 1 Lose";
                LBIsWinnerPlayer1.BackColor = Color.IndianRed;
                LBIsWinnerPlayer2.Text = "Player 2 Win";
                LBIsWinnerPlayer2.BackColor = Color.DarkSeaGreen;

                LBPlayer2WinTimes.Text = Convert.ToString(Convert.ToByte(LBPlayer2WinTimes.Text) + 1); 
                return true;
            }
            else if (WinnerChar == 'T')
            {
                MessageBox.Show("No Body's Win", "Tie", MessageBoxButtons.OK,MessageBoxIcon.Information);

                LBIsWinnerPlayer1.Text = "It's a Tie";
                LBIsWinnerPlayer1.BackColor = Color.DarkGray;
                LBIsWinnerPlayer2.Text = "It's a Tie";
                LBIsWinnerPlayer2.BackColor = Color.DarkGray;
                return true;
            }
            else
                return false;
        }

        void DisablePlayButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void ButtonClick(Button BTN)
        {
            if (LBPlayer1Turn.BackColor == Color.DarkSeaGreen)
            {
                if (!IsEmptyButton(Convert.ToString(BTN.Tag)))
                    return;

                BTN.BackgroundImage = Resources.Blaxk_x;
                BTN.Tag = LBPlayer1Turn.Tag;

                if (IsSomePlayerWin(GetWinnerChar()))
                {
                    LBPlayer1Turn.BackColor = Color.DarkGray;
                    DisablePlayButtons();
                    return;
                }

                UpdatePlayersColorAfterPlayer1Move();
            }
            else
            {
                if (!IsEmptyButton(Convert.ToString(BTN.Tag)))
                    return;

                BTN.BackgroundImage = Resources.Black_o;
                BTN.Tag = LBPlayer2Turn.Tag;

                if (IsSomePlayerWin(GetWinnerChar()))
                {
                    LBPlayer2Turn.BackColor = Color.DarkGray;
                    DisablePlayButtons();
                    return;
                }

                UpdatePlayersColorAfterPlayer2Move();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            ButtonClick((Button)sender);
            // object sender: This parameter represents the source of the event, which is the button that was clicked.
            /* (Button)sender: This casts the sender object to a Button type.
            The sender parameter is of type object,
            so it needs to be cast to Button to access button-specific properties and methods.
            */
        }

        void ResetButtons(Button BTN)
        {
            // Reset Play Buttons
            BTN.BackgroundImage= Resources.icon_1332777_1920;

            // Reset Buttons Back Color to DarkGray
            BTN.BackColor = Color.DarkGray;

            // Enable Play Buttons 
            BTN.Enabled = true;

            // Reset Button Tags
            BTN.Tag = "";
        }

        void ResetWinnerLabels(Label LB)
        {
            // Reset Winner Label
            LB.Text = "In Progress";
            LB.BackColor = Color.DarkGray;
        }

        void ResetPlayerWinTimesNumberAndLabelBackColor(Label LB)
        {
            // Reset Player Win Times
            LB.Text = "0";
            // Reset Label BackColor 
            LB.BackColor = Color.DarkGray;
        }

        private void BTNRestart_Click(object sender, EventArgs e)
        {
            // Reset Buttons
            ResetButtons(button1);
            ResetButtons(button2);
            ResetButtons(button3);
            ResetButtons(button4);
            ResetButtons(button5);
            ResetButtons(button6);
            ResetButtons(button7);
            ResetButtons(button8);
            ResetButtons(button9);

            // Reset Winner Labels
            ResetWinnerLabels(LBIsWinnerPlayer1);
            ResetWinnerLabels(LBIsWinnerPlayer2);

            // Reset Default Color for LBPlayer1Turn and LBPlayer2Turn
            LBPlayer1Turn.BackColor = Color.DarkSeaGreen;
            LBPlayer2Turn.BackColor = Color.DarkGray;

            // Reset Players Win Times
            ResetPlayerWinTimesNumberAndLabelBackColor(LBPlayer1WinTimes);
            ResetPlayerWinTimesNumberAndLabelBackColor(LBPlayer2WinTimes);

        }

        private void BTNReplay_Click(object sender, EventArgs e)
        {
            // Reset Buttons
            ResetButtons(button1);
            ResetButtons(button2);
            ResetButtons(button3);
            ResetButtons(button4);
            ResetButtons(button5);
            ResetButtons(button6);
            ResetButtons(button7);
            ResetButtons(button8);
            ResetButtons(button9);

            // Reset Winner Labels
            ResetWinnerLabels(LBIsWinnerPlayer1);
            ResetWinnerLabels(LBIsWinnerPlayer2);

            // Reset Default Color for LBPlayer1Turn and LBPlayer2Turn
            LBPlayer1Turn.BackColor = Color.DarkSeaGreen;
            LBPlayer2Turn.BackColor = Color.DarkGray;

            // Set Win Times Number Color for each players
            if (Convert.ToByte(LBPlayer1WinTimes.Text) > Convert.ToByte(LBPlayer2WinTimes.Text))
            {
                LBPlayer1WinTimes.BackColor = Color.DarkSeaGreen;
                LBPlayer2WinTimes.BackColor = Color.IndianRed;
            }
            else if (Convert.ToByte(LBPlayer1WinTimes.Text) < Convert.ToByte(LBPlayer2WinTimes.Text))
            {
                LBPlayer2WinTimes.BackColor = Color.DarkSeaGreen;
                LBPlayer1WinTimes.BackColor = Color.IndianRed;
            }
            else
            {
                LBPlayer2WinTimes.BackColor = Color.LightYellow;
                LBPlayer1WinTimes.BackColor = Color.LightYellow;
            }
        }

        private void BTNEndGame_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(LBPlayer1WinTimes.Text) > Convert.ToByte(LBPlayer2WinTimes.Text))
            {
                MessageBox.Show("Player 1 Won The Game", "Final Winner", MessageBoxButtons.OK);
                this.Close();
            }
            else if (Convert.ToByte(LBPlayer1WinTimes.Text) < Convert.ToByte(LBPlayer2WinTimes.Text))
            {
                MessageBox.Show("Player 2 Won The Game", "Final Winner", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("No One Won The Game", "Final Winner", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
