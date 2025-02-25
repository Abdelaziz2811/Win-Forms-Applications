﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.Properties;
using static System.Net.Mime.MediaTypeNames;

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

            return Student;
        }

        string CurrentDirectory = Directory.GetCurrentDirectory();

        List<StStudents> GetStudentsRecordsFromFile()
        {
            StreamReader Reader = new StreamReader(CurrentDirectory + "\\Data\\Students.txt");
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

        void GetCurrentUserInfo()
        {
            TXTBCurrentUserFirstName.Text = LogIn.CurrentUser.FirstName;
            TXTBCurrentUserLastName.Text = LogIn.CurrentUser.LastName;
            TXTBCurrentUser_UserName.Text = LogIn.CurrentUser.UserName;
            TXTBCurrentUserGender.Text = LogIn.CurrentUser.Gender;
            TXTBCurrentUserEmail.Text = LogIn.CurrentUser.Email;
            TXTBCurrentUserPhone.Text = LogIn.CurrentUser.Phone;

            if (LogIn.CurrentUser.Gender == "Male")
                PBUserPicture.Image = Resources.man;
            else
                PBUserPicture.Image = Resources.woman;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            TCStudentsOP.SelectedIndex = 5;
            TCProfessorsOP.SelectedIndex = 4;
            TCCoursesOp.SelectedIndex = 2;
            TCDepartementOP.SelectedIndex = 2;

            LStudentsRecords = GetStudentsRecordsFromFile();
            LProfessorsRecords = GetProfessorRecordsFromFile();
            LCourses = GetCoursesRecordsFromFile();
            LDepartements = GetDepartementsRecordFromFile();

            GetCurrentUserInfo();
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

        string ConvertStudentDataToDataLine(StStudents Student)
        {
            string DataLine = string.Empty;

            DataLine += Student.FirstName + '#';
            DataLine += Student.LastName + '#';
            DataLine += Student.BirthDate + '#';
            DataLine += Student.Gender.ToString() + '#';
            DataLine += Student.City + '#';
            DataLine += Student.State + '#';
            DataLine += Student.PostalCode + '#';
            DataLine += Student.Country + '#';
            DataLine += Student.Phone + '#';
            DataLine += Student.Email + '#';
            DataLine += Student.ID + '#';
            DataLine += Student.Major + '#';
            DataLine += Student.YearOfStudy + '#';
            DataLine += Student.GPA + '#';
            DataLine += Student.CreditsEarned.ToString() + '#';
            DataLine += Student.Achievements;

            return DataLine;
        }

        void SaveChangesToFile()
        {
            StreamWriter Writer = new StreamWriter(CurrentDirectory + "\\Data\\Students.txt");

            foreach (StStudents Student in LStudentsRecords)
            {
                if (LVStudentsList.SelectedItems[0].SubItems[0].Text != Student.ID)
                {
                    Writer.WriteLine(ConvertStudentDataToDataLine(Student));
                }
            }

            Writer.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVStudentsList.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Do you want to save the changes to file", "Save Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    SaveChangesToFile();
                    MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LVStudentsList.SelectedItems[0].Remove();
                    RefreshStudentsListsViews();
                }
                else
                    MessageBox.Show("Saving changes is canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (LVStudentsList.SelectedItems.Count > 1)
                MessageBox.Show("Multipule selection is not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void ShowStudentsList()
        {
            ListViewItem Item;

            foreach (StStudents Student in LStudentsRecords)
            {
                Item = new ListViewItem(Student.ID);

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

        void ShowStudentsAcademicInfo()
        {
            ListViewItem Item;
            foreach (StStudents Student in LStudentsRecords)
            {
                Item = new ListViewItem(Student.ID);

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

        void GetStudentsMainInfo(StStudents Student)
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

        void GetStudentsMainInfoToView()
        {
            if (LVStudentsList.SelectedItems[0].SubItems[3].Text == "M")
                PBStudentImage.Image = Resources.man;
            else
                PBStudentImage.Image = Resources.woman;

            foreach (StStudents Student in LStudentsRecords)
            {
                if (Student.ID == LVStudentsList.SelectedItems[0].SubItems[0].Text)
                {
                    GetStudentsMainInfo(Student);
                    break;
                }
            }
        }
        
        private void TXTBoxBirthDate_MouseEnter(object sender, EventArgs e)
        {
            MTXTBoxBirthDate.Visible = true;
        }

        private void TXTBoxBirthDate_Enter(object sender, EventArgs e)
        {
            MTXTBoxBirthDate.Visible = true;
        }

        void GetStudentsInfoToUpdate()
        {
            foreach (StStudents Student in LStudentsRecords)
            {
                if (Student.ID == LVStudentsList.SelectedItems[0].SubItems[0].Text)
                {
                    TXTBUpdateFirstName.Text = Student.FirstName;
                    TXTBUpdateLastName.Text = Student.LastName;
                    TXTBUpdateGPA.Text = Student.GPA.ToString();
                    TXTBUpdateCity.Text = Student.City;
                    MTXTBUpdateCreditsEarned.Text = Student.CreditsEarned.ToString();
                    TXTBUpdateEmail.Text = Student.Email;
                    TXTBUpdatePostalCode.Text = Student.PostalCode;
                    TXTBUpdateYearOfStudy.Text = Student.YearOfStudy;
                    MTXTBUpdateBirthDate.Text = Student.BirthDate;

                    if (Student.Gender == 'M')
                        CBUpdateGender.Text = "Male";
                    else if (Student.Gender == 'F')
                        CBUpdateGender.Text = "Female";

                        CBUpdateMajor.Text = Student.Major;
                    TXTBUpdateState.Text = Student.State;
                    TXTBUpdatePhone.Text = Student.Phone;
                    TXTBUpdateCountry.Text = Student.Country;
                    TXTBUpdateAchievements.Text = Student.Achievements;

                    break;
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

                    ShowStudentsList();

                    break;
                case "Academic Info":

                    if (!IsLVAcademicInfoEmpty())
                        return;

                    ShowStudentsAcademicInfo();

                    break;
                case "Personal Info":

                    if (!IsLVPersonalInfoEmpty())
                        return;

                    ShowStudentsPersonalInfo();

                    break;
                case "Contact Info":

                    if (!IsLVContactInfoEmpty())
                        return;

                    ShowStudentsContactInfo();

                    break;
                case "View":

                    if (!IsSomeItemSelected())
                        return;

                    GetStudentsMainInfoToView();

                    break;
                case "Update":

                    if (!IsSomeItemSelected())
                        return;

                    GetStudentsInfoToUpdate();

                    break;
            }
        }

        void RefreshStudentsListsViews()
        {
            LStudentsRecords = GetStudentsRecordsFromFile();

            // Refresh Students List
            LVStudentsList.Items.Clear();
            ShowStudentsList();

            // Refresh Students Acedemic Info
            LVAcademicInfo.Items.Clear();
            ShowStudentsAcademicInfo();

            // Refresh Personal Info
            LVPersonalInfo.Items.Clear();
            ShowStudentsPersonalInfo();

            // Refresh Contact Info
            LVContactInfo.Items.Clear();
            ShowStudentsContactInfo();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshStudentsListsViews();
        }

        string ConvertStudentDataToDataLine()
        {
            string StudentData = string.Empty;

            StudentData += TXTBFirstName.Text + "#";
            StudentData += TXTBLastName.Text + "#";
            StudentData += MTXTBoxBirthDate.Text + "#";

            if (CBGender.Text == "Male")
                StudentData += "M#";
            else if (CBGender.Text == "Female")
                StudentData += "F#";

            StudentData += TXTBCity.Text + "#";
            StudentData += TXTBState.Text + "#";
            StudentData += TXTBPostalCode.Text + "#";
            StudentData += TXTBCountry.Text + "#";
            StudentData += TXTBPhone.Text + "#";
            StudentData += TXTBEmail.Text + "#";
            StudentData += TXTBStudentID.Text + "#";
            StudentData += CBMajor.Text + "#";
            StudentData += "Freshman#";
            StudentData += "0/0#";
            StudentData += "0#";
            StudentData += "No Achievements Yet";

            return StudentData;
        }

        void SaveStudentInfoToFile()
        {
            File.AppendAllText(CurrentDirectory + "\\Data\\Students.txt",
                 ConvertStudentDataToDataLine() + "\n");  
        }

        void ClearTXTBoxes()
        {
            TXTBFirstName.Clear();
            TXTBLastName.Clear();
            MTXTBoxBirthDate.Clear();
            TXTBPhone.Clear();
            TXTBEmail.Clear();
            TXTBStudentID.Clear();
            TXTBCity.Clear();
            TXTBState.Clear();
            TXTBCountry.Clear();
            TXTBPostalCode.Clear();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TXTBFirstName.Text) || string.IsNullOrWhiteSpace(TXTBLastName.Text)
                || string.IsNullOrWhiteSpace(MTXTBoxBirthDate.Text) || string.IsNullOrWhiteSpace(CBGender.Text)
                || string.IsNullOrWhiteSpace(TXTBPhone.Text) || string.IsNullOrWhiteSpace(TXTBEmail.Text)
                || string.IsNullOrWhiteSpace(TXTBStudentID.Text) || string.IsNullOrWhiteSpace(CBMajor.Text)
                || string.IsNullOrWhiteSpace(TXTBCity.Text) || string.IsNullOrWhiteSpace(TXTBState.Text)
                || string.IsNullOrWhiteSpace(TXTBCountry.Text) || string.IsNullOrWhiteSpace(TXTBPostalCode.Text)))
            {
                SaveStudentInfoToFile();
                ClearTXTBoxes();
                RefreshStudentsListsViews();
                MessageBox.Show("Student added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Enter Student Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        StStudents UpdateStudentInfo(StStudents Student)
        {
            Student.FirstName = TXTBUpdateFirstName.Text;
            Student.LastName = TXTBUpdateLastName.Text;

            if (CBUpdateGender.Text == "Female")
                Student.Gender = 'F';
            else if (CBUpdateGender.Text == "Male")
                Student.Gender = 'M';

            Student.Major = CBUpdateMajor.Text;
            Student.YearOfStudy = TXTBUpdateYearOfStudy.Text;
            Student.GPA = TXTBUpdateGPA.Text;
            Student.BirthDate = MTXTBUpdateBirthDate.Text;
            Student.City = TXTBUpdateCity.Text;
            Student.State = TXTBUpdateState.Text;
            Student.CreditsEarned = Convert.ToDouble(MTXTBUpdateCreditsEarned.Text);
            Student.Phone = TXTBUpdatePhone.Text;
            Student.Email = TXTBUpdateEmail.Text;
            Student.Country = TXTBUpdateCountry.Text;
            Student.PostalCode = TXTBUpdatePostalCode.Text;
            Student.Achievements = TXTBUpdateAchievements.Text;

            return Student;
        }

        void SaveStudentInfoAfterUpdate()
        {
            StreamWriter Writer = new StreamWriter(CurrentDirectory + "\\Data\\Students.txt");

            foreach (StStudents Student in LStudentsRecords)
            {
                if (LVStudentsList.SelectedItems[0].SubItems[0].Text == Student.ID)
                {
                    Writer.WriteLine(ConvertStudentDataToDataLine(UpdateStudentInfo(Student)));
                }
                else
                    Writer.WriteLine(ConvertStudentDataToDataLine(Student));
            }

            Writer.Close();
        }

        void ClearTXTBoxes_Update()
        {
            TXTBUpdateFirstName.Clear();
            TXTBUpdateLastName.Clear();
            TXTBUpdateYearOfStudy.Clear();
            TXTBUpdateGPA.Clear();
            MTXTBUpdateBirthDate.Clear();
            TXTBUpdateCity.Clear();
            TXTBUpdateState.Clear();
            MTXTBUpdateCreditsEarned.Clear();
            TXTBUpdatePhone.Clear();
            TXTBUpdateEmail.Clear();
            TXTBUpdateCountry.Clear();
            TXTBUpdatePostalCode.Clear();
            TXTBUpdateAchievements.Clear();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TXTBUpdateFirstName.Text) || string.IsNullOrWhiteSpace(TXTBUpdateLastName.Text)
                || string.IsNullOrWhiteSpace(TXTBUpdateYearOfStudy.Text) || string.IsNullOrWhiteSpace(TXTBUpdateGPA.Text)
                || string.IsNullOrWhiteSpace(MTXTBUpdateBirthDate.Text) || string.IsNullOrWhiteSpace(TXTBUpdateCity.Text)
                || string.IsNullOrWhiteSpace(TXTBUpdateState.Text) || string.IsNullOrWhiteSpace(MTXTBUpdateCreditsEarned.Text)
                || string.IsNullOrWhiteSpace(TXTBUpdatePhone.Text) || string.IsNullOrWhiteSpace(TXTBUpdateEmail.Text)
                || string.IsNullOrWhiteSpace(TXTBUpdateCountry.Text) || string.IsNullOrWhiteSpace(TXTBUpdatePostalCode.Text)
                || string.IsNullOrWhiteSpace(TXTBUpdateAchievements.Text)))
            {
                if (!IsSomeItemSelected())
                {
                    MessageBox.Show("Please Selct a Student To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaveStudentInfoAfterUpdate();
                ClearTXTBoxes_Update();
                RefreshStudentsListsViews();
                MessageBox.Show("Student Info Has Been Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!IsSomeItemSelected())
                {
                    MessageBox.Show("Please Selct a Student To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    MessageBox.Show("Please Enter Valid Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TXTBUpdateCreditsEarned_MouseEnter(object sender, EventArgs e)
        {
            MTXTBUpdateCreditsEarned.Visible = true;
        }

        private void TXTBUpdateBirthDate_MouseEnter(object sender, EventArgs e)
        {
            MTXTBUpdateBirthDate.Visible = true;
        }

        private void TXTBUpdateBirthDate_Enter(object sender, EventArgs e)
        {
            MTXTBUpdateBirthDate.Visible = true;
        }

        private void TXTBUpdateCreditsEarned_Enter(object sender, EventArgs e)
        {
            MTXTBUpdateCreditsEarned.Visible = true;
        }

        private void CMSRefresh_Click(object sender, EventArgs e)
        {
            RefreshStudentsListsViews();
        }

        struct StProfessors
        {
            public string FirstName;
            public string LastName;
            public char Gender;
            public string ContactNumber;
            public string Email;

            public string ID;
            public string Specialization;
            public string Department;
            public string Qualifications;
            public string DateOfJoining;
        }

        StProfessors GetProfessorRecord(string[] ProfessorInfo)
        {
            StProfessors Professors;

            Professors.ID = ProfessorInfo[0];
            Professors.FirstName = ProfessorInfo[1];
            Professors.LastName = ProfessorInfo[2];
            Professors.Gender = Convert.ToChar(ProfessorInfo[3]);
            Professors.Department = ProfessorInfo[4];
            Professors.Specialization = ProfessorInfo[5];
            Professors.ContactNumber = ProfessorInfo[6];
            Professors.Email = ProfessorInfo[7];
            Professors.Qualifications = ProfessorInfo[8];
            Professors.DateOfJoining = ProfessorInfo[9];

            return Professors;
        }

        List<StProfessors> GetProfessorRecordsFromFile()
        {
            StreamReader Reader = new StreamReader(CurrentDirectory + "\\Data\\Professors.txt");
            string DataLine;
            string[] ProfessorInfo;

            StProfessors Professor;
            List<StProfessors> ProfessorsRecords = new List<StProfessors>();

            while ((DataLine = Reader.ReadLine()) != null)
            {
                ProfessorInfo = DataLine.Split('#');
                Professor = GetProfessorRecord(ProfessorInfo);
                ProfessorsRecords.Add(Professor);
            }

            Reader.Close();
            return ProfessorsRecords;
        }

        List<StProfessors> LProfessorsRecords = new List<StProfessors>();

        bool IsLVProfessorsListEmpty()
        {
            if (LVProfessorsList.Items.Count > 0)
                return false;
            else
                return true;
        }

        bool IsLVProfessorsAcademicInfoEmpty()
        {
            if (LVProfessorsAcademicInfo.Items.Count > 0)
                return false;
            else
                return true;
        }

        bool IsLVProfessorsContactInfoEmpty()
        {
            if (LVProfessorsContactInfo.Items.Count > 0)
                return false;
            else
                return true;
        }

        void ShowProfessorsList()
        {
            ListViewItem Item;

            foreach (StProfessors Professor in LProfessorsRecords)
            {
                Item = new ListViewItem(Professor.ID);

                Item.SubItems.Add(Professor.FirstName);
                Item.SubItems.Add(Professor.LastName);
                Item.SubItems.Add(Convert.ToString(Professor.Gender));
                Item.SubItems.Add(Professor.Email);

                if (Professor.Gender == 'M')
                    Item.ImageIndex = 0;
                else if (Professor.Gender == 'F')
                    Item.ImageIndex = 1;

                LVProfessorsList.Items.Add(Item);
            }
        }

        void ShowProfessorsAcademicInfo()
        {
            ListViewItem Item;
            foreach (StProfessors Professor in LProfessorsRecords)
            {
                Item = new ListViewItem(Professor.ID);

                Item.SubItems.Add(Professor.FirstName);
                Item.SubItems.Add(Professor.LastName);
                Item.SubItems.Add(Professor.Specialization);
                Item.SubItems.Add(Professor.Department);
                Item.SubItems.Add(Professor.Qualifications);
                Item.SubItems.Add(Professor.DateOfJoining);

                if (Professor.Gender == 'M')
                    Item.ImageIndex = 0;
                else if (Professor.Gender == 'F')
                    Item.ImageIndex = 1;

                LVProfessorsAcademicInfo.Items.Add(Item);
            }
        }

        void ShowProfessorsContactInfo()
        {
            ListViewItem Item;
            foreach (StProfessors Professor in LProfessorsRecords)
            {
                Item = new ListViewItem(Professor.ID);

                Item.SubItems.Add(Professor.FirstName);
                Item.SubItems.Add(Professor.LastName);
                Item.SubItems.Add(Professor.ContactNumber);
                Item.SubItems.Add(Professor.Email);

                if (Professor.Gender == 'M')
                    Item.ImageIndex = 0;
                else if (Professor.Gender == 'F')
                    Item.ImageIndex = 1;

                LVProfessorsContactInfo.Items.Add(Item);
            }
        }

        bool IsSomeItemSelectedProfsSection()
        {
            if (LVProfessorsList.SelectedItems.Count == 1) return true; else return false;
        }

        void GetProfMainInfo(StProfessors Professor)
        {
            LBProfFirstName.Text = Professor.FirstName;
            LBProfLastName.Text = Professor.LastName;
            LBProfGender.Text = Professor.Gender.ToString();
            LBProfID.Text = Professor.ID;
            LBProfDepartement.Text = Professor.Department;
            LBProfEmail.Text = Professor.Email;
            LBProfSpecialization.Text = Professor.Specialization;
            LBProfDateOfJoining.Text = Professor.DateOfJoining;
            LBProfContactNumber.Text = Professor.ContactNumber;
            LBProfQualifications.Text = Professor.Qualifications;

            if (Professor.Gender == 'M')
                PBProfessorImage.Image = Resources.man;
            else if (Professor.Gender == 'F')
                PBProfessorImage.Image = Resources.woman;
        }

        void GetProfMainInfoToView()
        {
            foreach(StProfessors Professor in LProfessorsRecords)
            {
                if (Professor.ID == LVProfessorsList.SelectedItems[0].SubItems[0].Text)
                {

                    GetProfMainInfo(Professor);
                    break;
                }
            }
        }

        void GetProfessorInfoForUpdate()
        {
            foreach (StProfessors Professor in LProfessorsRecords)
            {
                if (Professor.ID == LVProfessorsList.SelectedItems[0].SubItems[0].Text)
                {
                    TXTBTNProfUFirstName.Text = Professor.FirstName;
                    TXTBTNProfULastName.Text = Professor.LastName;

                    if (Professor.Gender == 'M')
                        CBProfUGender.SelectedIndex = 0;
                    else
                        CBProfUGender.SelectedIndex = 1;

                    TXTBTNProfUEmail.Text = Professor.Email;
                    TXTBTNProfUSpecialization.Text = Professor.Specialization;
                    TXTBTNProfUQualifications.Text = Professor.Qualifications;
                    TXTBTNProfUDateOfJoining.Text = Professor.DateOfJoining;
                    TXTBTNProfUContactNumber.Text = Professor.ContactNumber;

                    CBProfUDepatement.Text = Professor.Department;

                    break;
                }
            }
        }

        private void TCProfessors_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TCProfessorsOP.SelectedTab.Text)
            {
                case "Professors List":

                    if (!IsLVProfessorsListEmpty())
                        return;

                    ShowProfessorsList();

                    break;
                case "Academic Info":

                    if (!IsLVProfessorsAcademicInfoEmpty())
                        return;

                    ShowProfessorsAcademicInfo();

                    break;
                case "Contact Info":

                    if (!IsLVProfessorsContactInfoEmpty())
                        return;

                    ShowProfessorsContactInfo();

                    break;
                case "View":

                    if (!IsSomeItemSelectedProfsSection())
                        return;

                    GetProfMainInfoToView();

                    break;
                case "Update":

                    if (!IsSomeItemSelectedProfsSection())
                        return;

                    GetProfessorInfoForUpdate();

                    break;
            }

        }

        private void TSMProfView_Click(object sender, EventArgs e)
        {
            if (LVProfessorsList.SelectedItems.Count > 0)
                TCProfessorsOP.SelectTab(3);
            else
                MessageBox.Show("Please select a Professor to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TSMProfUpdate_Click(object sender, EventArgs e)
        {
            if (LVProfessorsList.SelectedItems.Count > 0)
                TCProfessorsOP.SelectTab(5);
            else
                MessageBox.Show("Please select a Professor to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        string ConvertProfessorRecordToDataLine(StProfessors Professor)
        {
            string DataLine = string.Empty;

            DataLine += Professor.ID + '#';
            DataLine += Professor.FirstName + '#';
            DataLine += Professor.LastName + '#';
            DataLine += Professor.Gender.ToString() + '#';
            DataLine += Professor.Department + '#';
            DataLine += Professor.Specialization + '#';
            DataLine += Professor.ContactNumber + '#';
            DataLine += Professor.Email + '#';
            DataLine += Professor.Qualifications + '#';
            DataLine += Professor.DateOfJoining;

            return DataLine;
        }

        void SaveChangesToProfsFile()
        {
            StreamWriter Writer = new StreamWriter(CurrentDirectory + "\\Data\\Professors.txt");

            foreach (StProfessors Professor in LProfessorsRecords)
            {
                if (Professor.ID != LVProfessorsList.SelectedItems[0].SubItems[0].Text)
                {
                    Writer.WriteLine(ConvertProfessorRecordToDataLine(Professor));
                }
            }

            Writer.Close();
        }

        void RefreshProfessorsListsViews()
        {
            LProfessorsRecords = GetProfessorRecordsFromFile();

            // Refresh Professors List
            LVProfessorsList.Items.Clear();
            ShowProfessorsList();

            // Refresh Professors Academic Info
            LVProfessorsAcademicInfo.Items.Clear();
            ShowProfessorsAcademicInfo();

            // Refresh Professors Contact Info
            LVProfessorsContactInfo.Items.Clear();
            ShowProfessorsContactInfo();
        }

        private void TSMProfDelete_Click(object sender, EventArgs e)
        {
            if (LVProfessorsList.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Do you want to save the changes to file", "Save Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    SaveChangesToProfsFile();
                    MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LVProfessorsList.SelectedItems[0].Remove();
                    RefreshProfessorsListsViews();
                }
                else
                    MessageBox.Show("Saving changes is canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (LVProfessorsList.SelectedItems.Count > 1)
                MessageBox.Show("Multipule selection is not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Please select a Professor to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TSMProfRefresh_Click(object sender, EventArgs e)
        {
            RefreshProfessorsListsViews();
        }

        StProfessors UopdateProfessorRecord(StProfessors Professor)
        {
            Professor.FirstName = TXTBTNProfUFirstName.Text;
            Professor.LastName = TXTBTNProfULastName.Text;

            if (CBProfUGender.Text == "Male")
                Professor.Gender = 'M';
            else if (CBProfUGender.Text == "Female")
                Professor.Gender = 'F';

            Professor.Department = CBProfUDepatement.Text;
            Professor.Specialization = TXTBTNProfUSpecialization.Text;
            Professor.ContactNumber = TXTBTNProfUContactNumber.Text;
            Professor.Email = TXTBTNProfUEmail.Text;
            Professor.Qualifications = TXTBTNProfUQualifications.Text;
            Professor.DateOfJoining = TXTBTNProfUDateOfJoining.Text;

            return Professor;
        }

        void SaveProfessorInfoAfterUpdate()
        {
            StreamWriter Writer = new StreamWriter(CurrentDirectory + "\\Data\\Professors.txt");

            foreach (StProfessors Professor in LProfessorsRecords)
            {
                if (LVProfessorsList.SelectedItems[0].SubItems[0].Text == Professor.ID)
                {
                    Writer.WriteLine(ConvertProfessorRecordToDataLine(UopdateProfessorRecord(Professor)));
                }
                else
                    Writer.WriteLine(ConvertProfessorRecordToDataLine(Professor));
            }

            Writer.Close();
        }

        void ClearTXTBoxes_Update_Profs()
        {
            TXTBTNProfUFirstName.Clear();
            TXTBTNProfULastName.Clear();
            TXTBTNProfUEmail.Clear();
            TXTBTNProfUSpecialization.Clear();
            TXTBTNProfUQualifications.Clear();
            TXTBTNProfUDateOfJoining.Clear();
            TXTBTNProfUContactNumber.Clear();
        }

        private void BTNUpdateProfInfo_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TXTBTNProfUFirstName.Text) || string.IsNullOrWhiteSpace(TXTBTNProfULastName.Text)
                || string.IsNullOrWhiteSpace(TXTBTNProfUEmail.Text) || string.IsNullOrWhiteSpace(TXTBTNProfUSpecialization.Text)
                || string.IsNullOrWhiteSpace(TXTBTNProfUQualifications.Text) || string.IsNullOrWhiteSpace(TXTBTNProfUDateOfJoining.Text)
                || string.IsNullOrWhiteSpace(TXTBTNProfUContactNumber.Text)))
            {
                if (!IsSomeItemSelectedProfsSection())
                {
                    MessageBox.Show("Please Select a Prof To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaveProfessorInfoAfterUpdate();
                ClearTXTBoxes_Update_Profs();
                RefreshProfessorsListsViews();
                MessageBox.Show("Professor Info Has Been Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!IsSomeItemSelectedProfsSection())
                {
                    MessageBox.Show("Please Selct a Professor To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    MessageBox.Show("Please Enter Valid Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string ConvertProfessorRecordToDataLine()
        {
            string DataLine = string.Empty;

            DataLine += TXTBProfAID.Text + '#';
            DataLine += TXTBProfAFirstName.Text + '#';
            DataLine += TXTBProfALastName.Text + '#';

            if (CBProfAGender.Text == "Male")
                DataLine += "M#";
            else if (CBProfAGender.Text == "Female")
                DataLine += "F#";

            DataLine += CBProfADepartement.Text + '#';
            DataLine += TXTBProfASpecialization.Text + '#';
            DataLine += TXTBProfAContactNumber.Text + '#';
            DataLine += TXTBProfAEmail.Text + '#';
            DataLine += TXTBProfAQualifications.Text + '#';
            DataLine += TXTBProfADateOfJoining.Text;

            return DataLine;
        }

        void AddProfDataToFile()
        {
            File.AppendAllText(CurrentDirectory + "\\Data\\Professors.txt",
                 ConvertProfessorRecordToDataLine() + "\n");
        }

        void ClearAddProfTXTBoxes()
        {
            TXTBProfAFirstName.Clear();
            TXTBProfALastName.Clear();
            TXTBProfAID.Clear();
            TXTBProfASpecialization.Clear();
            TXTBProfAContactNumber.Clear();
            TXTBProfAEmail.Clear();
            TXTBProfAQualifications.Clear();
            TXTBProfADateOfJoining.Clear();
        }

        private void BTNAddProf_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(TXTBProfAFirstName.Text) || string.IsNullOrWhiteSpace(TXTBProfALastName.Text)
            || string.IsNullOrWhiteSpace(TXTBProfAID.Text) || string.IsNullOrWhiteSpace(TXTBProfASpecialization.Text)
            || string.IsNullOrWhiteSpace(TXTBProfAContactNumber.Text) || string.IsNullOrWhiteSpace(TXTBProfAEmail.Text)
            || string.IsNullOrWhiteSpace(TXTBProfAQualifications.Text) || string.IsNullOrWhiteSpace(TXTBProfADateOfJoining.Text)))
            {
                AddProfDataToFile();
                ClearAddProfTXTBoxes();
                RefreshProfessorsListsViews();
                MessageBox.Show("Professor added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please Enter valid Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        struct StCourses
        {
            public string ID;
            public string Name;
            public string ProfessorID;
            public string Department;
            public string Hours;
            public string Credits;
            public string Description;
        }

        StCourses GetCourseRecord(string[] CourseData)
        {
            StCourses Course;

            Course.ID = CourseData[0];
            Course.Name = CourseData[1];
            Course.ProfessorID = CourseData[2];
            Course.Department = CourseData[3];
            Course.Hours = CourseData[4];
            Course.Credits = CourseData[5];
            Course.Description = CourseData[6];

            return Course;
        }

        List<StCourses> GetCoursesRecordsFromFile()
        {
            StreamReader Reader = new StreamReader(CurrentDirectory + "\\Data\\Courses.txt");
            string DataLine;
            string[] CourseData;

            List<StCourses> CoursesRecord = new List<StCourses>();

            while ((DataLine = Reader.ReadLine()) != null)
            {
                CourseData = DataLine.Split('#');
                CoursesRecord.Add(GetCourseRecord(CourseData));
            }

            Reader.Close();
            return CoursesRecord;
        }

        List<StCourses> LCourses = new List<StCourses>();

        void ShowCoursesList()
        {
            ListViewItem Item;

            foreach(StCourses Course in LCourses)
            {
                Item = new ListViewItem(Course.ID);
                Item.SubItems.Add(Course.Name);
                Item.SubItems.Add(Course.ProfessorID);
                Item.SubItems.Add(Course.Department);
                Item.SubItems.Add(Course.Hours);
                Item.SubItems.Add(Course.Credits);

                LVCourses.Items.Add(Item);
            }

        }

        private void TCCoursesOp_Click(object sender, EventArgs e)
        {
            if (LVCourses.Items.Count > 0)
                return;

            if (TCCoursesOp.SelectedTab.Text == "Courses  List")
            {
                ShowCoursesList();
            }
        }

        void GetCourseInfoToView(StCourses Course)
        {
            LBCourseName.Text = Course.Name;
            LBProfessorID.Text = Course.ProfessorID;
            LBCourseDepartement.Text = Course.Department;
            LBCourseHours.Text = Course.Hours;
            LBCourseCredits.Text = Course.Credits;

            string[] Description = Course.Description.Split(' ');

            LBCourseDescriptionLine1.Text = string.Empty;
            LBCourseDescriptionLine2.Text = string.Empty;

            byte i;
            
            for (i = 0; i <= Description.Length / 2; i++)
                LBCourseDescriptionLine1.Text += Description[i] + ' ';

            for (byte j = i; j < Description.Length; j++)
                LBCourseDescriptionLine2.Text += Description[j] + ' ';
        }

        bool FindCourse(string CourseID)
        {
            foreach(StCourses Course in LCourses)
            {
                if (Course.ID == CourseID)
                {
                    GetCourseInfoToView(Course);
                    return true;
                }
            }

            return false;
        }

        private void BTNCourseSearch_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TXTBSCourseID.Text)))
            {
                if (!FindCourse(TXTBSCourseID.Text))
                    MessageBox.Show("Course Not Found!\nEnter a valid Course ID", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Please enter CourseID To search on", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        bool IsCourseExists(string CourseID)
        {
            foreach (StCourses Course in LCourses)
            {
                if (Course.ID == CourseID)
                    return true;
            }

            return false;
        }

        string ConvertCourseRcordToDataLine()
        {
            string DataLine = string.Empty;

            DataLine += TXTBACourseID.Text + '#';
            DataLine += TXTBACourseName.Text + '#';
            DataLine += TXTBACourseProfID.Text + '#';
            DataLine += CBACourseDepartement.Text + '#';
            DataLine += TXTBACourseHours.Text + '#';
            DataLine += TXTBACourseCredits.Text + '#';
            DataLine += TXTBADescription.Text;

            return DataLine;
        }

        void ClearCourseAddTXTBoxes()
        {
            TXTBACourseID.Clear();
            TXTBACourseName.Clear();
            TXTBACourseProfID.Clear();
            CBACourseDepartement.SelectedIndex = -1;
            TXTBACourseHours.Clear();
            TXTBACourseCredits.Clear();
            TXTBADescription.Clear();
        }

        void RefreshCoursesListView()
        {
            LCourses = GetCoursesRecordsFromFile();

            LVCourses.Items.Clear();
            ShowCoursesList();
        }

        void SaveCoursesInfoToFile()
        {
            File.AppendAllText(CurrentDirectory + "\\Data\\Courses.txt",
                ConvertCourseRcordToDataLine() + "\n");
        }

        private void BTNAddCourse_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TXTBACourseID.Text) || string.IsNullOrWhiteSpace(CBACourseDepartement.Text)
                || string.IsNullOrWhiteSpace(TXTBACourseName.Text) || string.IsNullOrWhiteSpace(TXTBACourseProfID.Text)
                || string.IsNullOrWhiteSpace(TXTBACourseHours.Text) || string.IsNullOrWhiteSpace(TXTBACourseCredits.Text)
                || string.IsNullOrWhiteSpace(TXTBADescription.Text)))
            {
                if (!IsCourseExists(TXTBACourseID.Text))
                {
                    SaveCoursesInfoToFile();
                    ClearCourseAddTXTBoxes();
                    RefreshCoursesListView();
                    MessageBox.Show("Course added successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Course with ID {TXTBACourseID.Text} is already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
                MessageBox.Show("Please enter a valid info","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTNADescription_TextChanged(object sender, EventArgs e)
        {
            TXTBADescription.PlaceholderText = string.Empty;
        }

        bool IsSomeCourseSelected()
        {
            if (LVCourses.SelectedItems.Count >= 1)
                return true;
            else
                return false;
        }

        private void TSMIViewCourse_Click(object sender, EventArgs e)
        {
            if (IsSomeCourseSelected())
            {
                foreach(StCourses Course in LCourses)
                {
                    if (Course.ID == LVCourses.SelectedItems[0].SubItems[0].Text)
                    {
                        GetCourseInfoToView(Course);
                        break;
                    }
                }

                TCCoursesOp.SelectTab(1);
            }
            else
                MessageBox.Show("Please Choose a course to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void GetCourseInfoToUpdate(StCourses Course)
        {
            TXTBUCourseName.Text = Course.Name;
            CBUCourseDepartement.Text = Course.Department;
            TXTBUCourseProfID.Text = Course.ProfessorID;
            TXTBUCourseHours.Text = Course.Hours;
            TXTBUCourseCredits.Text = Course.Credits;
            TXTBUDescription.Text = Course.Description;
        }

        private void TSMIUpdateCourse_Click(object sender, EventArgs e)
        {
            if (IsSomeCourseSelected())
            {
                foreach (StCourses Course in LCourses)
                {
                    if (Course.ID == LVCourses.SelectedItems[0].SubItems[0].Text)
                    {
                        GetCourseInfoToUpdate(Course);
                        break;
                    }
                }

                TCCoursesOp.SelectTab(3);
            }
            else
                MessageBox.Show("Please Choose a course to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        StCourses UpdateCourseData(StCourses Course)
        {
            Course.Name = TXTBUCourseName.Text;
            Course.Department = CBUCourseDepartement.Text;
            Course.ProfessorID = TXTBUCourseProfID.Text;
            Course.Hours = TXTBUCourseHours.Text;
            Course.Credits = TXTBUCourseCredits.Text;
            Course.Description = TXTBUDescription.Text;

            return Course;
        }

        string ConvertCourseRcordToDataLine_Update(StCourses Course)
        {
            string DataLine = string.Empty;

            DataLine += Course.ID + '#';
            DataLine += Course.Name + '#';
            DataLine += Course.Department + '#';
            DataLine += Course.ProfessorID + '#';
            DataLine += Course.Hours + '#';
            DataLine += Course.Credits + '#';
            DataLine += Course.Description;

            return DataLine;
        }

        void ClearUpdateCourseTXTBoxes()
        {
            TXTBUCourseName.Clear();
            TXTBUCourseProfID.Clear();
            TXTBUCourseHours.Clear();
            TXTBUCourseCredits.Clear();
            TXTBUDescription.Clear();
        }

        void SaveCourseDataToFile_Update()
        {
            StreamWriter Writer = new StreamWriter(CurrentDirectory + "\\Data\\Courses.txt");

            foreach (StCourses Course in LCourses)
            {
                if (Course.ID == LVCourses.SelectedItems[0].SubItems[0].Text)
                {
                    Writer.WriteLine(ConvertCourseRcordToDataLine_Update(UpdateCourseData(Course)));
                }
                else
                    Writer.WriteLine(ConvertCourseRcordToDataLine_Update(Course));
            }

            Writer.Close();
        }

        private void BTNUpdateCourse_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TXTBUCourseName.Text) || string.IsNullOrWhiteSpace(CBUCourseDepartement.Text)
                || string.IsNullOrWhiteSpace(TXTBUCourseProfID.Text) || string.IsNullOrWhiteSpace(TXTBUCourseHours.Text)
                || string.IsNullOrWhiteSpace(TXTBUCourseCredits.Text) || string.IsNullOrWhiteSpace(TXTBUDescription.Text)))
            {
                SaveCourseDataToFile_Update();
                ClearUpdateCourseTXTBoxes();
                RefreshCoursesListView();
                MessageBox.Show("Course Updated successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
                MessageBox.Show("Please enter a valid info","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        string ConvertCourseRcordToDataLine(StCourses Course)
        {
            string DataLine = string.Empty;

            DataLine += Course.ID + '#';
            DataLine += Course.Name + '#';
            DataLine += Course.ProfessorID + '#';
            DataLine += Course.Department + '#';
            DataLine += Course.Hours + '#';
            DataLine += Course.Credits + '#';
            DataLine += Course.Description;

            return DataLine;
        }
        void SaveCourseDataToFile_Delete()
        {
            StreamWriter Writer = new StreamWriter(CurrentDirectory + "\\Data\\Courses.txt");

            foreach (StCourses Course in LCourses)
            {
                if (Course.ID != LVCourses.SelectedItems[0].SubItems[0].Text)
                {
                    Writer.WriteLine(ConvertCourseRcordToDataLine(Course));
                }
            }

            Writer.Close();
        }

        private void TSMIDeleteCourse_Click(object sender, EventArgs e)
        {
            if (LVCourses.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Do you want to save the changes to file", "Save Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    SaveCourseDataToFile_Delete();
                    MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LVCourses.SelectedItems[0].Remove();
                    RefreshCoursesListView();
                }
                else
                    MessageBox.Show("Saving changes is canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (LVCourses.SelectedItems.Count > 1)
                MessageBox.Show("Multipule selection is not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Please select a Course to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TSMIRefreshCourse_Click(object sender, EventArgs e)
        {
            RefreshCoursesListView();
        }


        struct StDepartements
        {
            public string ID;
            public string Name;
            public string HeadOfDepartement;
            public string MembersNumber;
            public string Courses;
            public string ContactNumber;
            public string Email;
        }

        enum enDepOperationMode
        {
            Delete, Update
        }

        StDepartements GetDepartementRecord(string[] DepartementData)
        {
            StDepartements Departement;

            Departement.ID = DepartementData[0];
            Departement.Name = DepartementData[1];
            Departement.HeadOfDepartement = DepartementData[2];
            Departement.MembersNumber = DepartementData[3];
            Departement.Courses = DepartementData[4];
            Departement.ContactNumber = DepartementData[5];
            Departement.Email = DepartementData[6];

            return Departement;
        }

        List<StDepartements> GetDepartementsRecordFromFile()
        {
            StreamReader Reader = new StreamReader(CurrentDirectory + "\\Data\\Departments.txt");
            string DataLine;
            string[] DepartementData;

            List<StDepartements> DepartementsRecord = new List<StDepartements>();

            while ((DataLine = Reader.ReadLine()) != null)
            {
                DepartementData = DataLine.Split('#');
                DepartementsRecord.Add(GetDepartementRecord(DepartementData));
            }

            Reader.Close();
            return DepartementsRecord;
        }

        List<StDepartements> LDepartements = new List<StDepartements>();

        void ShowDepartementsList()
        {
            ListViewItem Item;

            foreach (StDepartements Departement in LDepartements)
            {
                Item = new ListViewItem(Departement.ID);
                Item.SubItems.Add(Departement.Name);
                Item.SubItems.Add(Departement.HeadOfDepartement);
                Item.SubItems.Add(Departement.MembersNumber);
                Item.SubItems.Add(Departement.ContactNumber);
                Item.SubItems.Add(Departement.Email);

                LVDepartements.Items.Add(Item);
            }
        }

        private void TCDepartementOP_Click(object sender, EventArgs e)
        {
            if (LVDepartements.Items.Count > 0)
                return;

            ShowDepartementsList();
        }

        void GetDepartementMainInfo(StDepartements Departement)
        {
            LBDepName.Text = Departement.Name;
            LBHeadOfDep.Text = Departement.HeadOfDepartement;
            LBDepContactNumber.Text = Departement.ContactNumber;
            LBDepMembers.Text = Departement.MembersNumber;
            LBDepEmail.Text = Departement.Email;

            string[] Courses = Departement.Courses.Split(' ');

            LBDepCoursesLine1.Text = string.Empty;
            LBDepCoursesLine2.Text = string.Empty;

            byte i;

            for (i = 0; i <= Courses.Length / 2; i++)
            {
                LBDepCoursesLine1.Text += Courses[i] + ' ';
            }

            for (byte j = i; j < Courses.Length; j++)
            {
                LBDepCoursesLine2.Text += Courses[j] + ' ';
            }
        }

        bool IsSomeDepartementSelected()
        {
            if (LVDepartements.SelectedItems.Count > 0)
                return true;
            else
                return false;
        }

        private void TSMIViewDep_Click(object sender, EventArgs e)
        {
            if (IsSomeDepartementSelected())
            {
                foreach (StDepartements Departement in LDepartements)
                {
                    if (Departement.ID == LVDepartements.SelectedItems[0].SubItems[0].Text)
                    {
                        GetDepartementMainInfo(Departement);
                        break;
                    }
                }

                TCDepartementOP.SelectTab(1);
            }
            else
                MessageBox.Show("Please select a Departement to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void GetDepartementInfoToUpdate(StDepartements Departement)
        {
            TXTBUDepName.Text = Departement.Name;
            TXTBUHeadOfDep.Text = Departement.HeadOfDepartement;
            TXTBUDepMembersNumber.Text = Departement.MembersNumber;
            TXTBUDepContactNumber.Text = Departement.ContactNumber;
            TXTBUDepEmail.Text = Departement.Email;
            TXTBUDepCourses.Text = Departement.Courses;
        }

        private void TSMIUpdateDep_Click(object sender, EventArgs e)
        {
            if (IsSomeDepartementSelected())
            {
                foreach (StDepartements Departement in LDepartements)
                {
                    if (Departement.ID == LVDepartements.SelectedItems[0].SubItems[0].Text)
                    {
                        GetDepartementInfoToUpdate(Departement);
                        break;
                    }
                }

                TCDepartementOP.SelectTab(3);
            }
            else
                MessageBox.Show("Please select a Departement to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void RefreshDepartementsListView()
        {
            LDepartements = GetDepartementsRecordFromFile();

            LVDepartements.Items.Clear();
            ShowDepartementsList();
        }

        string ConvertDepartementRecordToDataLine(StDepartements Departement)
        {
            string DataLine = string.Empty;

            DataLine += Departement.ID + '#';
            DataLine += Departement.Name + '#';
            DataLine += Departement.HeadOfDepartement + '#';
            DataLine += Departement.MembersNumber + '#';
            DataLine += Departement.Courses + '#';
            DataLine += Departement.ContactNumber + '#';
            DataLine += Departement.Email;

            return DataLine;
        }

        StDepartements UpdateDepartementInfo(StDepartements Departement)
        {
            Departement.Name = TXTBUDepName.Text;
            Departement.HeadOfDepartement = TXTBUHeadOfDep.Text;
            Departement.MembersNumber = TXTBUDepMembersNumber.Text;
            Departement.Courses = TXTBUDepCourses.Text;
            Departement.ContactNumber = TXTBUDepContactNumber.Text;
            Departement.Email = TXTBUDepEmail.Text;

            return Departement;
        }

        void SaveDepartementDataToFile(enDepOperationMode OperationMode)
        {
            StreamWriter Writer = new StreamWriter(CurrentDirectory + "\\Data\\Departments.txt");

            foreach (StDepartements Departement in LDepartements)
            {
                if (OperationMode == enDepOperationMode.Delete)
                {
                    if (Departement.ID != LVDepartements.SelectedItems[0].SubItems[0].Text)
                        Writer.WriteLine(ConvertDepartementRecordToDataLine(Departement));
                }
                else if (OperationMode == enDepOperationMode.Update)
                {
                    if (Departement.ID != LVDepartements.SelectedItems[0].SubItems[0].Text)
                        Writer.WriteLine(ConvertDepartementRecordToDataLine(Departement));
                    else
                        Writer.WriteLine(ConvertDepartementRecordToDataLine(UpdateDepartementInfo(Departement)));
                }  
            }

            Writer.Close();
        }

        private void TSMIDeleteDep_Click(object sender, EventArgs e)
        {
            if (LVDepartements.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Do you want to save the changes to file", "Save Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    SaveDepartementDataToFile(enDepOperationMode.Delete);
                    MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LVDepartements.SelectedItems[0].Remove();
                    RefreshDepartementsListView();
                }
                else
                    MessageBox.Show("Saving changes is canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (LVDepartements.SelectedItems.Count > 1)
                MessageBox.Show("Multipule selection is not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Please select a Departement to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TSMIRefreshDep_Click(object sender, EventArgs e)
        {
            RefreshDepartementsListView();
        }

        bool FindDepartement(string DepartementID)
        {
            foreach(StDepartements Departement in LDepartements)
            {
                if (Departement.ID == DepartementID)
                {
                    GetDepartementMainInfo(Departement);
                    return true;
                }
            }

            return false;
        }

        private void BTNDepSearch_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TXTBSDepartementID.Text)))
            {
                if (!FindDepartement(TXTBSDepartementID.Text))
                    MessageBox.Show("Departement Not Found!\nEnter a valid DepartementID", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Please enter DepartementID To search on", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        bool IsDepartementExists(string DepartementID)
        {
            foreach(StDepartements Departement in LDepartements)
            {
                if (Departement.ID == DepartementID)
                    return true;
            }

            return false;
        }

        private void TXTBDepCourses_TextChanged(object sender, EventArgs e)
        {
            TXTBDepCourses.PlaceholderText = string.Empty;
        }

        string ConvertDepartmentRcordToDataLine()
        {
            string DataLine = string.Empty;

            DataLine += TXTBDepID.Text + '#';
            DataLine += TXTBDepName.Text + '#';
            DataLine += TXTBHeadOfDep.Text + '#';
            DataLine += TXTBDepMembersNumber.Text + '#';
            DataLine += TXTBDepCourses.Text + '#';
            DataLine += TXTBDepContactNumber.Text + '#';
            DataLine += TXTBDepEmail.Text;

            return DataLine;
        }

        void SaveDepartmentInfoToFile()
        {
            File.AppendAllText(CurrentDirectory + "\\Data\\Departments.txt",
                ConvertDepartmentRcordToDataLine() + "\n");
        }

        void ClearDepartementTXTBoxes_Add()
        {
            TXTBDepID.Clear();
            TXTBDepName.Clear();
            TXTBHeadOfDep.Clear();
            TXTBDepMembersNumber.Clear();
            TXTBDepCourses.Clear();
            TXTBDepContactNumber.Clear();
            TXTBDepEmail.Clear();
        }

        private void BTNAddDep_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TXTBDepID.Text) || string.IsNullOrWhiteSpace(TXTBDepName.Text)
                || string.IsNullOrWhiteSpace(TXTBHeadOfDep.Text) || string.IsNullOrWhiteSpace(TXTBDepContactNumber.Text)
                || string.IsNullOrWhiteSpace(TXTBDepEmail.Text) || string.IsNullOrWhiteSpace(TXTBDepCourses.Text)
                || string.IsNullOrWhiteSpace(TXTBDepMembersNumber.Text)))
            {
                if (!IsDepartementExists(TXTBACourseID.Text))
                {
                    SaveDepartmentInfoToFile();
                    ClearDepartementTXTBoxes_Add();
                    RefreshDepartementsListView();
                    MessageBox.Show("Departement added successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Departement with ID {TXTBDepID.Text} is already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please enter a valid info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void ClearDepartmentsTXTBoxes_Update()
        {
            TXTBUDepName.Clear();
            TXTBUHeadOfDep.Clear();
            TXTBUDepMembersNumber.Clear();
            TXTBUDepCourses.Clear();
            TXTBUDepContactNumber.Clear();
            TXTBUDepEmail.Clear();
        }

        private void BTNUpdateDep_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TXTBUDepName.Text) || string.IsNullOrWhiteSpace(TXTBUHeadOfDep.Text)
                || string.IsNullOrWhiteSpace(TXTBUDepMembersNumber.Text) || string.IsNullOrWhiteSpace(TXTBUDepCourses.Text)
                || string.IsNullOrWhiteSpace(TXTBUDepContactNumber.Text) || string.IsNullOrWhiteSpace(TXTBUDepEmail.Text)))
            {
                SaveDepartementDataToFile(enDepOperationMode.Update);
                ClearDepartmentsTXTBoxes_Update();
                RefreshDepartementsListView();
                MessageBox.Show("Department Updated successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please enter a valid info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}