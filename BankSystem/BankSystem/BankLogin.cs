using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BankSystem_BLL;

namespace BankSystem
{
    public partial class BankLogin : Form
    {
        public BankLogin()
        {
            InitializeComponent();
        }

        void LoadForm(object FormObj)
        {
            if (this.MainPNL.Controls.Count > 0)
            {
                this.guna2PictureBox1.Visible = false;
                this.TXTUsername.Visible = false;
                this.TXTPassword.Visible = false;
                this.BTNLogin.Visible = false;
                this.CHBRememberme.Visible = false;
            }


            Form NewForm = FormObj as Form;
            NewForm.TopLevel = false;
            NewForm.Dock = DockStyle.Fill;
            this.MainPNL.Controls.Add(NewForm);
            NewForm.Show();
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            clsUser_BLL User = clsUser_BLL.Find(TXTUsername.Text, TXTPassword.Text);

            if (User != null)
            {
                BankSystem banksystem = new BankSystem(User, ref guna2PictureBox1, ref TXTUsername,
                    ref TXTPassword, ref BTNLogin, ref CHBRememberme);
                LoadForm(banksystem);

                if (CHBRememberme.Checked)
                {
                    User.AddToRemeberedUsers();
                }
            }
            else
            {
                TXTUsername.BorderColor = Color.Red;
                TXTPassword.BorderColor = Color.Red;
            }
        }

        private void TXTUserCredentials_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTUsername.Text) && string.IsNullOrWhiteSpace(TXTPassword.Text))
            {
                string Username = string.Empty, Password = string.Empty;
                clsUser_BLL.GetRememberedUserCredentials(ref Username, ref Password);

                TXTUsername.Text = Username;
                TXTPassword.Text = Password;
            }
        }
    }
}
