using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        struct stUser
        {
            public string UserName;
            public string Password;
            public string FirstName;
            public string LastName;
            public string Email;
            public string Phone;
            public bool RememberMe;
        }

        struct stRememberedUser
        {
            public string UserNamse;
            public string Password;
        }

        stUser ConvertDataLineToRecord(string[] UserInfo)
        {
            stUser User = new stUser();

            User.UserName = UserInfo[0];
            User.Password = UserInfo[1];
            User.FirstName = UserInfo[2];
            User.LastName = UserInfo[3];
            User.Email = UserInfo[4];
            User.Phone = UserInfo[5];

            if (CBRememberMe.Checked)
                User.RememberMe = true;

            return User;
        }

        List<stUser> GetUserInfoFromFile(string Path)
        {
            List<stUser> LUsers = new List<stUser>();
           
            StreamReader Reader = new StreamReader(@"C:\Users\Abdelaziz\source\repos\UniversitySystem\" + Path);
            string DataLine;
            string[] UserInfo;

            while ((DataLine = Reader.ReadLine()) != null)
            {
                UserInfo = DataLine.Split('#');

                LUsers.Add(ConvertDataLineToRecord(UserInfo));
            }

            Reader.Close();

            return LUsers;
        }

        bool IsUserRegistered()
        {
            List<stUser> LUsers = GetUserInfoFromFile("Users.txt");

            foreach (stUser User in LUsers)
            {
                if (User.UserName == TxTBUserName.Text && TxTBPassword.Text == User.Password)
                {
                    if (User.RememberMe)
                    {
                        StreamWriter Writer = new StreamWriter(@"C:\Users\Abdelaziz\source\repos\UniversitySystem\RememberedUsers");
                        Writer.WriteLine(User.UserName + "#" + User.Password);
                        Writer.Close();
                    }
                    return true;
                }
            }
            MessageBox.Show("Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        void RemeberedUsers()
        {
            StreamReader Reader = new StreamReader(@"C:\Users\Abdelaziz\source\repos\UniversitySystem\RememberedUsers");
            string DataLine;
            string[] UserInfo;

            if ((DataLine = Reader.ReadLine()) != null)
            {
                UserInfo = DataLine.Split('#');

                TxTBUserName.Text = UserInfo[0];
                TxTBPassword.Text = UserInfo[1];

                Reader.Close();
            }
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            if (CBRememberMe.Checked)
            {
                if (!IsUserRegistered())
                    return;

                MessageBox.Show("User is registered");
            }
            else
            {
                if (!IsUserRegistered())
                    return;

                MessageBox.Show("User is registered");
            }
        }

        private void TxTBUserName_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxTBUserName.Text) && string.IsNullOrWhiteSpace(TxTBPassword.Text))
                RemeberedUsers();
        }

        private void TxTBPassword_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxTBUserName.Text) && string.IsNullOrWhiteSpace(TxTBPassword.Text))
                RemeberedUsers();
        }
    }
}
