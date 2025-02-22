using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        void LoadForm(object FormObj)
        {
            if (this.pnlOption.Controls.Count > 0)
            {
                this.pnlOption.Controls.Clear();
            }

            Form NewForm = FormObj as Form;
            NewForm.TopLevel = false;
            NewForm.Dock = DockStyle.Fill;
            this.pnlOption.Controls.Add(NewForm);
            NewForm.Show();
        }

        private void BTNNext_Click(object sender, EventArgs e)
        {
            GameOptions.GameLevel = Convert.ToByte(CBGameLevel.SelectedIndex);
            GameOptions.OperationType = Convert.ToByte(CBOperationType.SelectedIndex);
            GameOptions.GameRounds = Convert.ToByte(UPDRounds.Value);

            Quiz quiz = new Quiz();
            LoadForm(quiz);
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class GameOptions
        {
            public static byte GameLevel { get; set; }
            public static byte OperationType { get; set; }
            public static byte GameRounds { get; set; }
        }
    }
}
