using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        bool IsFieldsSelected()
        {
            if (CBLowercaseletters.Checked || CBNumbers.Checked || CBUppercaseletters.Checked || CBSymbols.Checked)
                return true;
            else
            {
                MessageBox.Show("Please select at least one option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        string GetSelectedChars(bool IsLowercaseLettersSelected, bool IsUppercaseLettersSelected, bool IsNumbersSelected, bool IsSymbolsSelected)
        {
            string SelectedChars = string.Empty;

            if (IsLowercaseLettersSelected)
                SelectedChars += "abcdefghijklmnopqrstuvwxyz";
            if (IsUppercaseLettersSelected)
                SelectedChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (IsNumbersSelected)
                SelectedChars += "0123456789";
            if (IsSymbolsSelected)
                SelectedChars += "!@#$%^&*()_+";

            return SelectedChars;
        }

        string GetPassword(byte PasswordLength, string SelectedChars)
        {
            Random RndNum = new Random();
            char Char;
            string Password = string.Empty;

            for (byte i = 1; i <= PasswordLength; i++)
            {
                Char = SelectedChars[RndNum.Next(0, SelectedChars.Length - 1)];
                Password += Char;
            }

            return Password;
        }

        private void BTNGenerate_Click(object sender, EventArgs e)
        {
            if (!IsFieldsSelected())
                return;

            string SelectedChars = GetSelectedChars(CBLowercaseletters.Checked, CBUppercaseletters.Checked
                , CBNumbers.Checked, CBSymbols.Checked);

            TXTBGeneratedCode.Text = GetPassword(Convert.ToByte(NUDPasswordLength.Value), SelectedChars);
        }

        private void BTNCopy_Click(object sender, EventArgs e)
        {
            if (TXTBGeneratedCode.Text == string.Empty)
                MessageBox.Show("There is no password to copy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Clipboard.SetText(TXTBGeneratedCode.Text);
        }
    }
}
