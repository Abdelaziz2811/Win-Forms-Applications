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
using UniversitySystem.Properties;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace UniversitySystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        byte Trials = 3;
        byte Time = 30;

        public struct stUsers
        {
            public string UserName;
            public string Password;
            public string FirstName;
            public string LastName;
            public string Gender;
            public string Email;
            public string Phone;
            public bool RememberMe;
        }

        struct stRememberedUser
        {
            public string UserNamse;
            public string Password;
        }

        stUsers ConvertDataLineToRecord(string[] UserInfo)
        {
            stUsers User = new stUsers();

            User.UserName = UserInfo[0];
            User.Password = UserInfo[1];
            User.FirstName = UserInfo[2];
            User.LastName = UserInfo[3];
            User.Gender = UserInfo[4];
            User.Email = UserInfo[5];
            User.Phone = UserInfo[6];

            if (CBRememberMe.Checked)
                User.RememberMe = true;

            return User;
        }

        string CurrentDirectory = Directory.GetCurrentDirectory();

        List<stUsers> GetUserInfoFromFile(string Path)
        {
            List<stUsers> LUsers = new List<stUsers>();
           
            StreamReader Reader = new StreamReader(CurrentDirectory + Path);
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
        
        void CountTrials()
        {
            Trials--;
            LBTrials.Text = "You have " + Trials + " Trials left";     
        }

        public static stUsers CurrentUser;

        bool IsUserRegistered()
        {
            List<stUsers> LUsers = GetUserInfoFromFile("\\Data\\Users.txt");

            foreach (stUsers User in LUsers)
            {
                if (User.UserName == TxTBUserName.Text && TxTBPassword.Text == User.Password)
                {
                    CurrentUser = User; // This is the current user

                    if (User.RememberMe)
                    {
                        StreamWriter Writer = new StreamWriter(CurrentDirectory + "\\Data\\RememberedUsers.txt");
                        Writer.Write(User.UserName + "#" + User.Password);
                        Writer.Close();
                    }
                    return true;
                }
            }
            TxTBUserName.BorderColor = Color.Red;
            TxTBPassword.BorderColor = Color.Red;
            CountTrials();
            MessageBox.Show("Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            return false;
        }

        void RemeberedUsers()
        {
            StreamReader Reader = new StreamReader(CurrentDirectory + "\\Data\\RememberedUsers.txt");
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
            if (!IsUserRegistered())
                 return;

            TxTBUserName.Clear();
            TxTBPassword.Clear();

            Form Frm = new MainScreen();
            Frm.ShowDialog();
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

        private void BTNShowHide_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(BTNShowHide.Tag) == "show")
            {
                TxTBPassword.PasswordChar = '\0';
                BTNShowHide.Image = Resources.hide;
                BTNShowHide.Tag = "hide";
            }
            else
            {
                TxTBPassword.PasswordChar = '•';
                BTNShowHide.Image = Resources.show;
                BTNShowHide.Tag = "show";
            }
        }

        private void TxTBUserName_TextChanged(object sender, EventArgs e)
        {
            TxTBUserName.BorderColor = Color.LightSkyBlue;
            TxTBPassword.BorderColor = Color.LightSkyBlue;
        }

        private void TxTBPassword_TextChanged(object sender, EventArgs e)
        {
            TxTBUserName.BorderColor = Color.LightSkyBlue;
            TxTBPassword.BorderColor = Color.LightSkyBlue;
        }

        void EnableDisableButtons(bool Order)
        {
            BTNLogin.Enabled = Order;
            TxTBUserName.Enabled = Order;
            TxTBPassword.Enabled = Order;
            BTNShowHide.Enabled = Order;
            BTNShowHide.BackColor = Color.Gainsboro;
        }

        void ResetTrialsAndTime()
        {
            Trials = 3;
            Time = 30;
            TrialsTimer.Start();
            LBTrials.Text = "";
        }

        private void TrialsTimer_Tick(object sender, EventArgs e)
        {
            if (Trials == 0)
            {
                EnableDisableButtons(false);

                LBTrials.Location = new Point(138, 386);

                LBTrials.Text = Time.ToString();
                Time--;

                if (Time == 0)
                {
                    ResetTrialsAndTime();
                    EnableDisableButtons(true);
                    LBTrials.Location = new Point(90, 386);
                    BTNShowHide.BackColor = Color.White;
                }
            }
        }

        private void BTNCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DateTime datetime;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            LBDate.Text = datetime.ToString();
        }
    }
}
