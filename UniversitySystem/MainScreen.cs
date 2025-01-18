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

namespace UniversitySystem
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        struct StStudents
        {
            public string FirstName;
            public string LastName;
            public string BirthDate;
            public char Gender;
            public string City;
            public string State;
            public string PostalCode;
            public string Country;

            public string Phone;
            public string Email;
            public string ID;
            public string Major;
            public string YearOfStudy;
            public string GPA;
            public double CreditsEarned;
            public string Achievements;
            public bool MarkForDelete;
        }

        StStudents GetStudentRecord(string[] StudentInfo)
        {
            StStudents Student;

            Student.FirstName = StudentInfo[0];
            Student.LastName = StudentInfo[1];
            Student.BirthDate = StudentInfo[2];
            Student.Gender = Convert.ToChar(StudentInfo[3]);
            Student.City = StudentInfo[4];
            Student.State = StudentInfo[5];
            Student.PostalCode = StudentInfo[6];
            Student.Country = StudentInfo[7];
            Student.Phone = StudentInfo[8];
            Student.Email = StudentInfo[9];
            Student.ID = StudentInfo[10];
            Student.Major = StudentInfo[11];
            Student.YearOfStudy = StudentInfo[12];
            Student.GPA = StudentInfo[13];
            Student.CreditsEarned = Convert.ToDouble(StudentInfo[14]);
            Student.Achievements = StudentInfo[15];
            Student.MarkForDelete = false;

            return Student;
        }

        List<StStudents> GetStudentsRecords()
        {
            StreamReader Reader = new StreamReader(@"C:\Users\Abdelaziz\source\repos\UniversitySystem\Students.txt");
            string DataLine;
            string[] StudentInfo;
            
            StStudents Student;
            List <StStudents> StudentsRecords = new List<StStudents>();

            while ((DataLine = Reader.ReadLine()) != null)
            {
                StudentInfo = DataLine.Split('#');
                Student = GetStudentRecord(StudentInfo);
                StudentsRecords.Add(Student);
            }
            Reader.Close();
            return StudentsRecords;
        }

        List<StStudents> LStudentsRecords = new List<StStudents>();

        private void MainScreen_Load(object sender, EventArgs e)
        {
            LStudentsRecords = GetStudentsRecords();
        }

        void SetColumnsForStudentsList()
        {
            LVStudentsList.Columns.Add(Text = "ID", Width = 100);
            LVStudentsList.Columns.Add(Text = "First Name", Width = 109);
            LVStudentsList.Columns.Add(Text = "Last Name", Width = 110);
            LVStudentsList.Columns.Add(Text = "Gender", Width = 100);
            LVStudentsList.Columns.Add(Text = "Email", Width = 200);

            this.Width = 816;
            this.Height = 489;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVStudentsList.SelectedItems.Count > 0)
                TCStudentsOP.SelectTab(4);
            else
                MessageBox.Show("Please select a student to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVStudentsList.SelectedItems.Count > 0)
                TCStudentsOP.SelectTab(6);
            else
                MessageBox.Show("Please select a student to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void SaveChangesToFile()
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVStudentsList.SelectedItems.Count == 1)
            {
                
                if (MessageBox.Show("Do you want to save the changes to file", "Save Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    SaveChangesToFile();
                    MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Saving changes is canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LVStudentsList.SelectedItems[0].Remove();
            }
            else if (LVStudentsList.SelectedItems.Count > 1)
            {
                foreach (ListViewItem Item in LVStudentsList.SelectedItems)
                {
                    Item.Remove();
                }
                if (MessageBox.Show("Do you want to save the changes to file", "Save Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    SaveChangesToFile();
                    MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Saving changes is canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
        }

        void ShowStudentsList()
        {
            foreach (StStudents Student in LStudentsRecords)
            {
                ListViewItem Item = new ListViewItem(Student.ID);

                Item.SubItems.Add(Student.FirstName);
                Item.SubItems.Add(Student.LastName);
                Item.SubItems.Add(Convert.ToString(Student.Gender));
                Item.SubItems.Add(Student.Email);

                if (Student.Gender == 'M')
                    Item.ImageIndex = 0;
                else if (Student.Gender == 'F')
                    Item.ImageIndex = 1;

                LVStudentsList.Items.Add(Item);
            }
        }

        bool IsLVStudentsEmpty()
        {
            if (LVStudentsList.Items.Count > 0)
                return false;
            else
                return true;
        }

        void SetColumnsForStudentsAcademicInfo()
        {
            LVAcademicInfo.Columns.Add(Text = "ID", Width = 100);
            LVAcademicInfo.Columns.Add(Text = "First Name", Width = 75);
            LVAcademicInfo.Columns.Add(Text = "Last Name", Width = 75);
            LVAcademicInfo.Columns.Add(Text = "Major", Width = 100);
            LVAcademicInfo.Columns.Add(Text = "Year of Study", Width = 100);
            LVAcademicInfo.Columns.Add(Text = "GPA", Width = 75);
            LVAcademicInfo.Columns.Add(Text = "Credits Earned", Width = 100);
            LVAcademicInfo.Columns.Add(Text = "Achievement", Width = 200);
            
            this.Width = 816;
            this.Height = 489;
        }

        void ShowStudentsAcademicInfo()
        {
            foreach (StStudents Student in LStudentsRecords)
            {
                ListViewItem Item = new ListViewItem(Student.ID);

                Item.SubItems.Add(Student.FirstName);
                Item.SubItems.Add(Student.LastName);
                Item.SubItems.Add(Student.Major);
                Item.SubItems.Add(Student.YearOfStudy);
                Item.SubItems.Add(Student.GPA);
                Item.SubItems.Add(Convert.ToString(Student.CreditsEarned));
                Item.SubItems.Add(Student.Achievements);

                if (Student.Gender == 'M')
                    Item.ImageIndex = 0;
                else if (Student.Gender == 'F')
                    Item.ImageIndex = 1;

                LVAcademicInfo.Items.Add(Item);
            }
        }

        bool IsLVAcademicInfoEmpty()
        {
            if (LVAcademicInfo.Items.Count > 0)
                return false;
            else 
                return true;
        }

        void SetColumnsForStudentsPersonalInfo()
        {
            LVPersonalInfo.Columns.Add(Text = "ID", Width = 100);
            LVPersonalInfo.Columns.Add(Text = "First Name", Width = 75);
            LVPersonalInfo.Columns.Add(Text = "Last Name", Width = 75);
            LVPersonalInfo.Columns.Add(Text = "Bith Date", Width = 100);
            LVPersonalInfo.Columns.Add(Text = "Gender", Width = 92);
            LVPersonalInfo.Columns.Add(Text = "City", Width = 75);
            LVPersonalInfo.Columns.Add(Text = "Country", Width = 100);

            this.Width = 816;
            this.Height = 489;
        }

        bool IsLVPersonalInfoEmpty()
        {
            if (LVPersonalInfo.Items.Count > 0)
                return false;
            else
                return true;
        }

        void ShowStudentsPersonalInfo()
        {
            foreach (StStudents Student in LStudentsRecords)
            {
                ListViewItem Item = new ListViewItem(Student.ID);

                Item.SubItems.Add(Student.FirstName);
                Item.SubItems.Add(Student.LastName);
                Item.SubItems.Add(Student.BirthDate);
                Item.SubItems.Add(Convert.ToString(Student.Gender));
                Item.SubItems.Add(Student.City);
                Item.SubItems.Add(Student.Country);

                if (Student.Gender == 'M')
                    Item.ImageIndex = 0;
                else if (Student.Gender == 'F')
                    Item.ImageIndex = 1;

                LVPersonalInfo.Items.Add(Item);
            }
        }

        void SetColumnsForStudentsContactInfo()
        {
            LVContactInfo.Columns.Add(Text = "ID", Width = 100);
            LVContactInfo.Columns.Add(Text = "First Name", Width = 75);
            LVContactInfo.Columns.Add(Text = "Last Name", Width = 75);
            LVContactInfo.Columns.Add(Text = "Phone", Width = 125);
            LVContactInfo.Columns.Add(Text = "Email", Width = 150);
            LVContactInfo.Columns.Add(Text = "State", Width = 100);
            LVContactInfo.Columns.Add(Text = "Postal Code", Width = 75);

            this.Width = 816;
            this.Height = 489;
        }

        bool IsLVContactInfoEmpty()
        {
            if (LVContactInfo.Items.Count > 0)
                return false;
            else
                return true;
        }

        void ShowStudentsContactInfo()
        {
            foreach (StStudents Student in LStudentsRecords)
            {
                ListViewItem Item = new ListViewItem(Student.ID);

                Item.SubItems.Add(Student.FirstName);
                Item.SubItems.Add(Student.LastName);
                Item.SubItems.Add(Student.Phone);
                Item.SubItems.Add(Student.Email);
                Item.SubItems.Add(Student.State);
                Item.SubItems.Add(Student.PostalCode);

                if (Student.Gender == 'M')
                    Item.ImageIndex = 0;
                else if (Student.Gender == 'F')
                    Item.ImageIndex = 1;

                LVContactInfo.Items.Add(Item);
            }
        }

        bool IsSomeItemSelected()
        {
            if (LVStudentsList.SelectedItems.Count == 1)
                return true;
            else 
                return false;
        }

        void GetStudentsMainInfo()
        {
            if (LVStudentsList.SelectedItems[0].SubItems[3].Text == "M")
                PBStudentImage.Image = Resources.man;
            else
                PBStudentImage.Image = Resources.woman;

            foreach (StStudents Student in LStudentsRecords)
            {
                if (Student.ID == LVStudentsList.SelectedItems[0].SubItems[0].Text)
                {
                    LBFirstName.Text = Student.FirstName;
                    LBLastName.Text = Student.LastName;
                    LBBirthDate.Text = Student.BirthDate;
                    LBGender.Text = Student.Gender.ToString();

                    LBStudentID.Text = Student.ID;
                    LBYearOfStudy.Text = Student.YearOfStudy;
                    LBMajor.Text = Student.Major;
                    LBCredits.Text = Student.CreditsEarned.ToString();
                    LBAchievements.Text = Student.Achievements;
                    LBGPA.Text = Student.GPA;
                    
                }
            }
        }

        private void TCStudentsOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TCStudentsOP.SelectedTab.Text)
            {
                case "Students List":

                    if (!IsLVStudentsEmpty())
                        return;

                    SetColumnsForStudentsList();
                    ShowStudentsList();

                    break;
                case "Academic Info":

                    if (!IsLVAcademicInfoEmpty())
                        return;

                    SetColumnsForStudentsAcademicInfo();
                    ShowStudentsAcademicInfo();

                    break;
                case "Personal Info":

                    if (!IsLVPersonalInfoEmpty())
                        return;

                    SetColumnsForStudentsPersonalInfo();
                    ShowStudentsPersonalInfo();

                    break;
                case "Contact Info":

                    if (!IsLVContactInfoEmpty())
                        return;

                    SetColumnsForStudentsContactInfo();
                    ShowStudentsContactInfo();

                    break;
                case "View":

                    if (!IsSomeItemSelected())
                        return;

                    GetStudentsMainInfo();

                    break;
                case "Add":

                    MessageBox.Show("Add");

                    break;
                case "Update":

                    MessageBox.Show("Update");

                    break;
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LVStudentsList.Clear();
            SetColumnsForStudentsList();
            ShowStudentsList();
        }


    }
}
