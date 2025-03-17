using Guna.UI2.WinForms;
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
using System.Linq.Expressions;
using BankSystem.Properties;

namespace BankSystem
{
    public partial class BankSystem : Form
    {
        clsUser_BLL CurrentUser;

        Guna2PictureBox PB; 
        Guna2TextBox TXTBUsername;
        Guna2TextBox TXTBPassword;
        Guna2GradientButton BTNLogin; 
        Guna2CheckBox CHBRememberme;

        public BankSystem(clsUser_BLL User, ref Guna2PictureBox PB, ref Guna2TextBox TXTBUsername,
            ref Guna2TextBox TXTBPassword, ref Guna2GradientButton BTNLogin, ref Guna2CheckBox CHB)
        {
            InitializeComponent();

            this.CurrentUser = User;

            this.PB = PB;
            this.TXTBUsername = TXTBUsername;
            this.TXTBPassword = TXTBPassword;
            this.BTNLogin = BTNLogin;
            this.CHBRememberme = CHB;
        }

        string _UserImagePath_Add = string.Empty;
        string _UserImagePath_Update = string.Empty;
        string _ClientImagePath_Add = string.Empty;
        string _ClientImagePath_Update = string.Empty;

        private void BankSystem_Load(object sender, EventArgs e)
        {
            SetDefaultTabs();
            
            GetUsersInfo();

            GetCurrentUserInfo();

            GetClientsInfo();
        }

        void SetAllCurrentUserPermissions(bool Check)
        {
            CHBL_ViewClient.Checked = Check;
            CHBL_FindClient.Checked = Check;
            CHBL_AddClient.Checked = Check;
            CHBL_UpdateClient.Checked = Check;
            CHBL_DeleteClient.Checked = Check;
            CHBL_ManageUsers.Checked = Check;
            CHBL_Transactions.Checked = Check;
            CHBL_LoginRegister.Checked = Check;
        }

        void GetCurrentUserPermissions(int Permissions)
        {
            if (Permissions == -1)
            {
                CHBL_FullAccess.Checked = true;
                SetAllCurrentUserPermissions(true);
                return;
            }

            if ((Convert.ToInt32(CHBL_ViewClient.Tag) & Permissions) == Convert.ToInt32(CHBL_ViewClient.Tag)) CHBL_ViewClient.Checked = true;
            if ((Convert.ToInt32(CHBL_FindClient.Tag) & Permissions) == Convert.ToInt32(CHBL_FindClient.Tag)) CHBL_FindClient.Checked = true;
            if ((Convert.ToInt32(CHBL_AddClient.Tag) & Permissions) == Convert.ToInt32(CHBL_AddClient.Tag)) CHBL_AddClient.Checked = true;
            if ((Convert.ToInt32(CHBL_UpdateClient.Tag) & Permissions) == Convert.ToInt32(CHBL_UpdateClient.Tag)) CHBL_UpdateClient.Checked = true;
            if ((Convert.ToInt32(CHBL_DeleteClient.Tag) & Permissions) == Convert.ToInt32(CHBL_DeleteClient.Tag)) CHBL_DeleteClient.Checked = true;
            if ((Convert.ToInt32(CHBL_ManageUsers.Tag) & Permissions) == Convert.ToInt32(CHBL_ManageUsers.Tag)) CHBL_ManageUsers.Checked = true;
            if ((Convert.ToInt32(CHBL_Transactions.Tag) & Permissions) == Convert.ToInt32(CHBL_Transactions.Tag)) CHBL_Transactions.Checked = true;
            if ((Convert.ToInt32(CHBL_LoginRegister.Tag) & Permissions) == Convert.ToInt32(CHBL_LoginRegister.Tag)) CHBL_LoginRegister.Checked = true;
        }

        void GetCurrentUserInfo()
        {
            LBCurrentUser_Username.Text = CurrentUser.Username;
            LBCurrentUser_Name.Text = CurrentUser.Name;
            LBCurrentUser_Email.Text = CurrentUser.Email;
            LBCurrentUser_Phone.Text = CurrentUser.Phone;
            LBCurrentUser_Address.Text = CurrentUser.Address;

            PBCurrentUserImage.Load(CurrentUser.ImagePath);

            GetCurrentUserPermissions(CurrentUser.Permissions);
        }

        void SetDefaultTabs()
        {
            TCUsers.SelectedIndex = 3;
            TCClients.SelectedIndex = 3;
        }

        void GetUsersInfo()
        {
            DGVUsers.DataSource = clsUser_BLL.GetUsersInfo();
        }

        List<string> GetManagersIDs()
        {
            List<string> IDs = new List<string>();
            
            foreach (DataGridViewRow Row in DGVUsers.Rows)
            {
                IDs.Add(Row.Cells["UserID"].Value.ToString() + " - " + Row.Cells["Username"].Value.ToString());
            }
            return IDs;
        }
        
        void FillCBA_ManagersIDsWithIDs(ref Guna2ComboBox CBA_ManagersIDs)
        {
            foreach (string Manager in GetManagersIDs())
            {
                CBA_ManagersIDs.Items.Add(Manager);
            }
            if (CBA_ManagersIDs.Items.Count > 0) CBA_ManagersIDs.SelectedIndex = 0;
        }

        private void CBManagersIDs_MouseEnter(object sender, EventArgs e)
        {
                LBManagerID.Visible = false;
        }

        private void CBManagersIDs_MouseLeave(object sender, EventArgs e)
        {
            if (CBA_ManagersIDs.SelectedIndex == -1)
                LBManagerID.Visible = true;
        }

        void SetAllPermissions_ADD_CheckBoxesTo(bool Check)
        {
            CHBA_ViewClient.Checked = Check;
            CHBA_FindClient.Checked = Check;
            CHBA_AddClient.Checked = Check;
            CHBA_UpdateClient.Checked = Check;
            CHBA_DeleteClient.Checked = Check;
            CHBA_ManageUsers.Checked = Check;
            CHBA_Transactions.Checked = Check;
            CHBA_LoginRegister.Checked = Check;
        }

        private void CHBFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBA_FullAccess.Checked)
            {
                SetAllPermissions_ADD_CheckBoxesTo(true);
            }
            else
                SetAllPermissions_ADD_CheckBoxesTo(false);
        }
        
        private void BTNASetImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose PNG File";
                openFileDialog.Filter = "PNG Files (*.png)|*.png";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PBA_UserImage.Load(openFileDialog.FileName);
                    _UserImagePath_Add = openFileDialog.FileName;
                    BTNA_SetImage.Visible = false;
                }
            }
        }

        private void BTNRemoveImage_Click(object sender, EventArgs e)
        {
            if (PBA_UserImage.Image != null)
            {
                PBA_UserImage.Image = null;
                BTNA_SetImage.Visible = true;
            }
        }

        int SetUserPermissionsToAdd()
        {
            int Permissions = 0;
            if (CHBA_ViewClient.Checked) Permissions += Convert.ToInt32(CHBA_ViewClient.Tag);
            if (CHBA_FindClient.Checked) Permissions += Convert.ToInt32(CHBA_FindClient.Tag);
            if (CHBA_AddClient.Checked) Permissions += Convert.ToInt32(CHBA_AddClient.Tag);
            if (CHBA_DeleteClient.Checked) Permissions += Convert.ToInt32(CHBA_DeleteClient.Tag);
            if (CHBA_UpdateClient.Checked) Permissions += Convert.ToInt32(CHBA_UpdateClient.Tag);
            if (CHBA_ManageUsers.Checked) Permissions += Convert.ToInt32(CHBA_ManageUsers.Tag);
            if (CHBA_Transactions.Checked) Permissions += Convert.ToInt32(CHBA_Transactions.Tag);
            if (CHBA_LoginRegister.Checked) Permissions += Convert.ToInt32(CHBA_LoginRegister.Tag);
            return Permissions;
        }

        bool SetUserInfoToAdd(clsUser_BLL User)
        {
            if (string.IsNullOrWhiteSpace(TXTBA_Username.Text) || string.IsNullOrWhiteSpace(TXTBA_Password.Text)
                || string.IsNullOrWhiteSpace(TXTBA_Name.Text) || string.IsNullOrWhiteSpace(TXTBA_Email.Text)
                || string.IsNullOrWhiteSpace(TXTBA_Address.Text) || string.IsNullOrWhiteSpace(TXTBA_Phone.Text)
                || CBA_ManagersIDs.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter User info", "Operation Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                
            User.Username = TXTBA_Username.Text;
            User.Password = TXTBA_Password.Text;
            User.Name = TXTBA_Name.Text;
            User.Email = TXTBA_Email.Text;
            User.Address = TXTBA_Address.Text;
            User.Phone = TXTBA_Phone.Text;
            User.ManagerID = Convert.ToInt32(CBA_ManagersIDs.SelectedItem.ToString().Split(' ')[0]);
            User.ImagePath = _UserImagePath_Add;

            if (CHBA_FullAccess.Checked)
            {
                User.Permissions = Convert.ToInt32(CHBA_FullAccess.Tag);
                return true;
            }
            else if (CHBA_ViewClient.Checked || CHBA_FindClient.Checked
                     || CHBA_AddClient.Checked || CHBA_DeleteClient.Checked
                     || CHBA_UpdateClient.Checked || CHBA_ManageUsers.Checked
                     || CHBA_Transactions.Checked || CHBA_LoginRegister.Checked)
            {
                User.Permissions = SetUserPermissionsToAdd();
                return true;
            }
            else
            {
                MessageBox.Show("Select user permissions", "Operation Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void ResetControlsValues_Add()
        {
            TXTBA_Username.Clear();
            TXTBA_Password.Clear();
            TXTBA_Name.Clear();
            TXTBA_Email.Clear();
            TXTBA_Address.Clear();
            TXTBA_Phone.Clear();

            _UserImagePath_Add = string.Empty;
            PBA_UserImage.Image = null;

            CHBA_FullAccess.Checked = false;
            CHBA_ViewClient.Checked = false;
            CHBA_FindClient.Checked = false;
            CHBA_AddClient.Checked = false;
            CHBA_DeleteClient.Checked = false;
            CHBA_UpdateClient.Checked = false;
            CHBA_ManageUsers.Checked = false;
            CHBA_Transactions.Checked = false;
            CHBA_LoginRegister.Checked = false;
        }

        private void BTNAddUser_Click(object sender, EventArgs e)
        {
            if (clsUser_BLL.IsUsernameExists(TXTBA_Username.Text))
            {
                MessageBox.Show($"Username {TXTBA_Username.Text} already exists", "Operation Failled", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsUser_BLL User = new clsUser_BLL();

            if (!SetUserInfoToAdd(User)) return;

            if (User.Save())
            {
                MessageBox.Show($"{TXTBA_Username.Text} Added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetUsersInfo();
                ResetControlsValues_Add();
            }
        }

        void FillCBU_ManagersIDsWithIDs(ref Guna2ComboBox CBU_ManagersIDs)
        {
            foreach (string ID in GetManagersIDs())
            {
                CBU_ManagersIDs.Items.Add(ID);
            }
        }

        void SetAllPermissions_Update_CheckBoxesTo(bool Check)
        {
            CHBU_ViewClient.Checked = Check;
            CHBU_FindClient.Checked = Check;
            CHBU_AddClient.Checked = Check;
            CHBU_UpdateClient.Checked = Check;
            CHBU_DeleteClient.Checked = Check;
            CHBU_ManageUsers.Checked = Check;
            CHBU_Transactions.Checked = Check;
            CHBU_LoginRegister.Checked = Check;
        }

        void GetUserPermissions(int Permissions)
        {
            if (Permissions == -1)
            {
                CHBU_FullAccess.Checked = true;
                SetAllPermissions_Update_CheckBoxesTo(true);
                return;
            }

            if ((Convert.ToInt32(CHBU_ViewClient.Tag) & Permissions) == Convert.ToInt32(CHBU_ViewClient.Tag)) CHBU_ViewClient.Checked = true;
            if ((Convert.ToInt32(CHBU_FindClient.Tag) & Permissions) == Convert.ToInt32(CHBU_FindClient.Tag)) CHBU_FindClient.Checked = true;
            if ((Convert.ToInt32(CHBU_AddClient.Tag) & Permissions) == Convert.ToInt32(CHBU_AddClient.Tag)) CHBU_AddClient.Checked = true;
            if ((Convert.ToInt32(CHBU_UpdateClient.Tag) & Permissions) == Convert.ToInt32(CHBU_UpdateClient.Tag)) CHBU_UpdateClient.Checked = true;
            if ((Convert.ToInt32(CHBU_DeleteClient.Tag) & Permissions) == Convert.ToInt32(CHBU_DeleteClient.Tag)) CHBU_DeleteClient.Checked = true;
            if ((Convert.ToInt32(CHBU_ManageUsers.Tag) & Permissions) == Convert.ToInt32(CHBU_ManageUsers.Tag)) CHBU_ManageUsers.Checked = true;
            if ((Convert.ToInt32(CHBU_Transactions.Tag) & Permissions) == Convert.ToInt32(CHBU_Transactions.Tag)) CHBU_Transactions.Checked = true;
            if ((Convert.ToInt32(CHBU_LoginRegister.Tag) & Permissions) == Convert.ToInt32(CHBU_LoginRegister.Tag)) CHBU_LoginRegister.Checked = true;            
        }

        void GetUserInfoToUpdate()
        {
            string Username = (string)DGVUsers.CurrentRow.Cells[1].Value;
            string Password = (string)DGVUsers.CurrentRow.Cells[6].Value;

            clsUser_BLL User = clsUser_BLL.Find(Username, Password);

            if (User == null) return;

            TXTBU_Password.Text = User.Password;
            TXTBU_Name.Text = User.Name;
            TXTBU_Email.Text = User.Email;
            TXTBU_Address.Text = User.Address;
            TXTBU_Phone.Text = User.Phone;
            
            CBU_ManagersIDs.SelectedIndex = CBU_ManagersIDs.FindString(User.UserID.ToString() + " - " + User.Username);

            BTNU_SetImage.Visible = User.ImagePath == string.Empty; // if the user has no picture we set the visibility of set image button to true

            if (User.ImagePath != string.Empty)
            {
                PBU_UserImage.Load(User.ImagePath);
                BTNU_SetImage.Visible = false;
            }
            else PBU_UserImage.Image = null;

            GetUserPermissions(User.Permissions);
        }

        void ResetControlsValues_View()
        {
            CHBV_FullAccess.Checked = false;
            CHBV_ViewClient.Checked = false;
            CHBV_FindClient.Checked = false;
            CHBV_AddClient.Checked = false;
            CHBV_DeleteClient.Checked = false;
            CHBV_UpdateClient.Checked = false;
            CHBV_ManageUsers.Checked = false;
            CHBV_Transactions.Checked = false;
            CHBV_LoginRegister.Checked = false;
        }

        private void TCUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TCUsers.SelectedTab.Text)
            {
                case "Add User":

                    ResetControlsValues_Add();
                    
                    if (CBA_ManagersIDs.Items.Count != 0)
                        return;

                    FillCBA_ManagersIDsWithIDs(ref CBA_ManagersIDs);

                    break;
                case "Update User":

                    ResetControlsValues_Update();

                    if (DGVUsers.SelectedRows.Count == 0)
                        return;

                    if (CBU_ManagersIDs.Items.Count == 0)
                        FillCBU_ManagersIDsWithIDs(ref CBU_ManagersIDs);

                    SetAllPermissions_Update_CheckBoxesTo(false);
                    GetUserInfoToUpdate();

                    break;
            }
        }

        private void CHBU_FullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBU_FullAccess.Checked)
                SetAllPermissions_Update_CheckBoxesTo(true);
            else
                SetAllPermissions_Update_CheckBoxesTo(false);
        }

        private void BTNU_SetImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose PNG File";
                openFileDialog.Filter = "PNG Files (*.png)|*.png";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PBU_UserImage.Load(openFileDialog.FileName);
                    _UserImagePath_Update = openFileDialog.FileName;
                    BTNU_SetImage.Visible = false;
                }
            }
        }

        private void BTNU_Remove_Click(object sender, EventArgs e)
        {
            if (PBU_UserImage.Image != null)
            {
                PBU_UserImage.Image = null;
                BTNU_SetImage.Visible = true;
            }
        }

        int SetUserPermissionsToUpdate()
        {
            int Permissions = 0;
            if (CHBU_ViewClient.Checked) Permissions += Convert.ToInt32(CHBU_ViewClient.Tag);
            if (CHBU_FindClient.Checked) Permissions += Convert.ToInt32(CHBU_FindClient.Tag);
            if (CHBU_AddClient.Checked) Permissions += Convert.ToInt32(CHBU_AddClient.Tag);
            if (CHBU_DeleteClient.Checked) Permissions += Convert.ToInt32(CHBU_DeleteClient.Tag);
            if (CHBU_UpdateClient.Checked) Permissions += Convert.ToInt32(CHBU_UpdateClient.Tag);
            if (CHBU_ManageUsers.Checked) Permissions += Convert.ToInt32(CHBU_ManageUsers.Tag);
            if (CHBU_Transactions.Checked) Permissions += Convert.ToInt32(CHBU_Transactions.Tag);
            if (CHBU_LoginRegister.Checked) Permissions += Convert.ToInt32(CHBU_LoginRegister.Tag);
            return Permissions;
        }

        bool SetUserInfoToUpdate(clsUser_BLL User)
        {
            if (string.IsNullOrWhiteSpace(TXTBU_Password.Text) || string.IsNullOrWhiteSpace(TXTBU_Name.Text)
                || string.IsNullOrWhiteSpace(TXTBU_Email.Text) || string.IsNullOrWhiteSpace(TXTBU_Address.Text) 
                || string.IsNullOrWhiteSpace(TXTBU_Phone.Text) || CBU_ManagersIDs.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter User info to update", "Operation Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            User.Password = TXTBU_Password.Text;
            User.Name = TXTBU_Name.Text;
            User.Email = TXTBU_Email.Text;
            User.Address = TXTBU_Address.Text;
            User.Phone = TXTBU_Phone.Text;
            User.ManagerID = Convert.ToInt32(CBU_ManagersIDs.SelectedItem.ToString().Split(' ')[0]);
            
            if (_UserImagePath_Update == string.Empty && PBU_UserImage.Image == null) User.ImagePath = string.Empty;
                                                                            
            if (_UserImagePath_Update == string.Empty && PBU_UserImage.Image != null) User.ImagePath = DGVUsers.CurrentRow.Cells[9].Value.ToString();
                                                                 
            if (_UserImagePath_Update != string.Empty && PBU_UserImage.Image != null) User.ImagePath = _UserImagePath_Update;

            if (CHBU_FullAccess.Checked)
            {
                User.Permissions = Convert.ToInt32(CHBU_FullAccess.Tag);
                return true;
            }
            else if (CHBU_ViewClient.Checked || CHBU_FindClient.Checked
                     || CHBU_AddClient.Checked || CHBU_DeleteClient.Checked
                     || CHBU_UpdateClient.Checked || CHBU_ManageUsers.Checked
                     || CHBU_Transactions.Checked || CHBU_LoginRegister.Checked)
            {
                User.Permissions = SetUserPermissionsToUpdate();
                return true;
            }
            else
            {
                MessageBox.Show("Select user permissions", "Operation Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void ResetControlsValues_Update()
        {
            TXTBU_Password.Clear();
            TXTBU_Name.Clear();
            TXTBU_Email.Clear();
            TXTBU_Address.Clear();
            TXTBU_Phone.Clear();

            PBU_UserImage.Image = null;
            _UserImagePath_Update = string.Empty;

            CHBU_FullAccess.Checked = false;
            CHBU_ViewClient.Checked = false;
            CHBU_FindClient.Checked = false;
            CHBU_AddClient.Checked = false;
            CHBU_DeleteClient.Checked = false;
            CHBU_UpdateClient.Checked = false;
            CHBU_ManageUsers.Checked = false;
            CHBU_Transactions.Checked = false;
            CHBU_LoginRegister.Checked = false;
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            clsUser_BLL User = clsUser_BLL.Find((int)DGVUsers.CurrentRow.Cells[0].Value);

            if (!SetUserInfoToUpdate(User) || User == null) return;

            if (User.Save())
            {
                MessageBox.Show($"{User.Username} Updated successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControlsValues_Update();
                GetUsersInfo();
            }
            else
                MessageBox.Show($"Operation Failled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void SetAllPermissions_View_CheckBoxesTo(bool Check)
        {
            CHBV_ViewClient.Checked = Check;
            CHBV_FindClient.Checked = Check;
            CHBV_AddClient.Checked = Check;
            CHBV_UpdateClient.Checked = Check;
            CHBV_DeleteClient.Checked = Check;
            CHBV_ManageUsers.Checked = Check;
            CHBV_Transactions.Checked = Check;
            CHBV_LoginRegister.Checked = Check;
        }

        void GetUserPermissions_View(int Permissions)
        {
            if (Permissions == -1)
            {
                CHBV_FullAccess.Checked = true;
                SetAllPermissions_View_CheckBoxesTo(true);
                return;
            }

            if ((Convert.ToInt32(CHBV_ViewClient.Tag) & Permissions) == Convert.ToInt32(CHBU_ViewClient.Tag)) CHBV_ViewClient.Checked = true;
            if ((Convert.ToInt32(CHBV_FindClient.Tag) & Permissions) == Convert.ToInt32(CHBV_FindClient.Tag)) CHBV_FindClient.Checked = true;
            if ((Convert.ToInt32(CHBV_AddClient.Tag) & Permissions) == Convert.ToInt32(CHBV_AddClient.Tag)) CHBV_AddClient.Checked = true;
            if ((Convert.ToInt32(CHBV_UpdateClient.Tag) & Permissions) == Convert.ToInt32(CHBV_UpdateClient.Tag)) CHBV_UpdateClient.Checked = true;
            if ((Convert.ToInt32(CHBV_DeleteClient.Tag) & Permissions) == Convert.ToInt32(CHBV_DeleteClient.Tag)) CHBV_DeleteClient.Checked = true;
            if ((Convert.ToInt32(CHBV_ManageUsers.Tag) & Permissions) == Convert.ToInt32(CHBV_ManageUsers.Tag)) CHBV_ManageUsers.Checked = true;
            if ((Convert.ToInt32(CHBV_Transactions.Tag) & Permissions) == Convert.ToInt32(CHBV_Transactions.Tag)) CHBV_Transactions.Checked = true;
            if ((Convert.ToInt32(CHBV_LoginRegister.Tag) & Permissions) == Convert.ToInt32(CHBV_LoginRegister.Tag)) CHBV_LoginRegister.Checked = true;
        }

        void GetUserInfoToView(clsUser_BLL User)
        {
            LBVUserID.Text = User.UserID.ToString();
            LBVUsername.Text = User.Username;
            LBVEmail.Text = User.Email;
            LBVAddress.Text = User.Address;
            LBVName.Text = User.Name;
            LBVManagerID.Text = User.ManagerID.ToString();
            LBVPhone.Text = User.Phone;

            GetUserPermissions_View(User.Permissions);

            PBV_UserImage.Load(User.ImagePath);
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TXTSUserID.Text))
            {
                ResetControlsValues_View();

                clsUser_BLL User = clsUser_BLL.Find(Convert.ToInt32(TXTSUserID.Text));

                if (User != null)
                {
                    GetUserInfoToView(User);
                }
                else MessageBox.Show($"User with ID {TXTSUserID.Text} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TXTSUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block non-numeric input
            }
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            this.PB.Visible = true;
            this.TXTBUsername.Visible = true;
            this.TXTBPassword.Visible = true;
            this.TXTBUsername.Clear();
            this.TXTBPassword.Clear();
            this.BTNLogin.Visible = true;
            this.CHBRememberme.Visible = true;
        }

        private void TSMIUpdateUsers_Click(object sender, EventArgs e)
        {
            TCUsers.SelectedIndex = 2;
        }

        private void TSMIDeleteUsers_Click(object sender, EventArgs e)
        {
            int UserID = (int)DGVUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you Sure you want to Delete User with ID {UserID}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (clsUser_BLL.DeleteUser(UserID))
                {
                    GetUsersInfo();
                    MessageBox.Show($"User with ID {UserID} Deleted successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Operation Failled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Operation has been Canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSMIRefreshUsers_Click(object sender, EventArgs e)
        {
            GetUsersInfo();
        }

        private void TCClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TCClients.SelectedTab.Text)
            {
                case "Add Client":

                    if (CBA_ClientManagersIDs.Items.Count != 0)
                        return;
                    
                    FillCBA_ManagersIDsWithIDs(ref CBA_ClientManagersIDs);

                    break;

                case "Update Client":

                    if (CBU_ClientManagersIDs.Items.Count == 0)
                        FillCBU_ManagersIDsWithIDs(ref CBU_ClientManagersIDs);
                    
                    GetClientInfoToUpdate();

                    break;
            }
        }

        void GetClientsInfo()
        {
            DGVClients.DataSource = clsClient_BLL.GetClientsInfo();
        }

        private void CBA_ClientManagersIDs_MouseEnter(object sender, EventArgs e)
        {
            LBClientManagerID.Visible = false;
        }

        private void CBA_ClientManagersIDs_MouseLeave(object sender, EventArgs e)
        {
            if (CBA_ManagersIDs.SelectedIndex == -1)
                LBClientManagerID.Visible = true;
        }

        bool SetClientInfoToAdd(clsClient_BLL Client)
        {
            if (string.IsNullOrWhiteSpace(TXTBA_AccountNumber.Text) || string.IsNullOrWhiteSpace(TXTBA_Pincode.Text)
                || string.IsNullOrWhiteSpace(TXTBA_ClientEmail.Text) || string.IsNullOrWhiteSpace(TXTBA_ClientPhone.Text)
                || string.IsNullOrWhiteSpace(TXTBA_ClientName.Text) || string.IsNullOrWhiteSpace(TXTBA_Balance.Text)
                || string.IsNullOrWhiteSpace(TXTBA_ClientAddress.Text) || CBA_ClientManagersIDs.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Client info", "Operation Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Client.AccountNumber = Convert.ToInt32(TXTBA_AccountNumber.Text);
            Client.Pincode = TXTBA_Pincode.Text;
            Client.ClientEmail = TXTBA_ClientEmail.Text;
            Client.ClientPhone = TXTBA_ClientPhone.Text;
            Client.ClientName = TXTBA_ClientName.Text;
            Client.Balance = Convert.ToDecimal(TXTBA_Balance.Text);
            Client.ClientAddress = TXTBA_ClientAddress.Text;
            Client.CManagerID = Convert.ToInt32(CBA_ClientManagersIDs.SelectedItem.ToString().Split(' ')[0]);
            Client.ClientImagePath = _ClientImagePath_Add;

            return true;
        }

        void ResetControlsValues_AddClient()
        {
            TXTBA_AccountNumber.Clear();
            TXTBA_ClientEmail.Clear();
            TXTBA_ClientName.Clear();
            TXTBA_ClientAddress.Clear();
            TXTBA_Pincode.Clear();
            TXTBA_ClientPhone.Clear();
            TXTBA_Balance.Clear();

            PBA_ClientImage.Image = null;
        }

        private void BTNAddClient_Click(object sender, EventArgs e)
        {
            if (clsClient_BLL.IsAccountNumberExists(Convert.ToInt32(TXTBA_AccountNumber.Text)))
            {
                MessageBox.Show($"Client with Account Number '{TXTBA_AccountNumber.Text}' already exists", "Operation Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsClient_BLL Client = new clsClient_BLL();

            if (!SetClientInfoToAdd(Client)) return;

            if (Client.Save())
            {
                MessageBox.Show($"Client '{TXTBA_ClientName.Text}' With Account Number '{TXTBA_AccountNumber.Text}' Added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetClientsInfo();
                ResetControlsValues_AddClient();
            }
        }

        private void TXTBA_AccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block non-numeric input
            }
        }

        private void TXTBA_Balance_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys like backspace
            if (!char.IsControl(e.KeyChar))
            {
                // Allow digits and the decimal point (.)
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // Block non-numeric and non-decimal input
                }

                // Allow only one decimal point
                if (e.KeyChar == '.' && ((Guna2TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true; // Block additional decimal points
                }
            }
        }

        private void BTNA_SetClientImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose PNG File";
                openFileDialog.Filter = "PNG Files (*.png)|*.png";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PBA_ClientImage.Load(openFileDialog.FileName);
                    _ClientImagePath_Add = openFileDialog.FileName;
                    BTNA_SetClientImage.Visible = false;
                }
            }
        }

        private void BTNA_RemoveClientImage_Click(object sender, EventArgs e)
        {
            if (PBA_ClientImage.Image != null)
            {
                PBA_ClientImage.Image = null;
                BTNA_SetClientImage.Visible = true;
            }
        }
        
        bool SetClientInfoToUpdate(clsClient_BLL Client)
        {
            if (string.IsNullOrWhiteSpace(TXTBU_ClientName.Text) || string.IsNullOrWhiteSpace(TXTBU_Pincode.Text)
                || string.IsNullOrWhiteSpace(TXTBU_ClientEmail.Text) || string.IsNullOrWhiteSpace(TXTBU_Balance.Text)
                || string.IsNullOrWhiteSpace(TXTBU_ClientAddress.Text) || string.IsNullOrWhiteSpace(TXTBU_ClientPhone.Text)
                || CBU_ClientManagersIDs.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Client info to update", "Operation Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Client.ClientName = TXTBU_ClientName.Text;
            Client.Pincode = TXTBU_Pincode.Text;
            Client.ClientEmail = TXTBU_ClientEmail.Text;
            Client.Balance = Convert.ToDecimal(TXTBU_Balance.Text);
            Client.ClientAddress = TXTBU_ClientAddress.Text;
            Client.ClientPhone = TXTBU_ClientPhone.Text;
            Client.CManagerID = Convert.ToInt32(CBU_ClientManagersIDs.SelectedItem.ToString().Split(' ')[0]);

            if (_ClientImagePath_Update == string.Empty && PBU_ClientImage.Image == null) Client.ClientImagePath = string.Empty;
                                                                         
            if (_ClientImagePath_Update == string.Empty && PBU_ClientImage.Image != null) Client.ClientImagePath = DGVClients.CurrentRow.Cells[9].Value.ToString();
                                                                 
            if (_ClientImagePath_Update != string.Empty && PBU_ClientImage.Image != null) Client.ClientImagePath = _ClientImagePath_Update;

            return true;
        }

        void ResetControlsValues_UpdateClient()
        {
            TXTBU_ClientEmail.Clear();
            TXTBU_ClientName.Clear();
            TXTBU_ClientAddress.Clear();
            TXTBU_Pincode.Clear();
            TXTBU_ClientPhone.Clear();
            TXTBU_Balance.Clear();

            PBU_ClientImage.Image = null;
        }

        void GetClientInfoToUpdate()
        {
            int ClientID = (int)DGVClients.CurrentRow.Cells[0].Value;

            clsClient_BLL Client = clsClient_BLL.Find(ClientID);

            if (Client == null) return;

            TXTBU_Pincode.Text = Client.Pincode;
            TXTBU_ClientEmail.Text = Client.ClientEmail;
            TXTBU_ClientPhone.Text = Client.ClientPhone;
            TXTBU_ClientName.Text = Client.ClientName;
            TXTBU_Balance.Text = Client.Balance.ToString();
            TXTBU_ClientAddress.Text = Client.ClientAddress;
            
            string ManagerUsername = clsClient_BLL.GetManagerName(Client.CManagerID);

            CBU_ClientManagersIDs.SelectedIndex = CBU_ClientManagersIDs.FindString(Client.CManagerID.ToString() + " - " + ManagerUsername);

            BTNU_SetClientImage.Visible = Client.ClientImagePath == string.Empty; 

            if (Client.ClientImagePath != string.Empty)
            {
                PBU_ClientImage.Load(Client.ClientImagePath);
                BTNU_SetImage.Visible = false;
            }
            else PBU_ClientImage.Image = null;
        }

        private void BTNC_Update_Click(object sender, EventArgs e)
        {
            clsClient_BLL Client = clsClient_BLL.Find((int)DGVClients.CurrentRow.Cells[0].Value);

            if (!SetClientInfoToUpdate(Client)) return;

            if (Client.Save() || Client == null)
            {
                MessageBox.Show($"{Client.ClientName}'s info Updated successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControlsValues_UpdateClient();
                GetClientsInfo();
            }
            else
                MessageBox.Show($"Operation Failled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTNU_SetClientImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose PNG File";
                openFileDialog.Filter = "PNG Files (*.png)|*.png";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PBU_ClientImage.Load(openFileDialog.FileName);
                    _ClientImagePath_Update = openFileDialog.FileName;
                    BTNU_SetClientImage.Visible = false;
                }
            }
        }

        private void BTNU_RemoveClientImage_Click(object sender, EventArgs e)
        {
            if (PBU_ClientImage.Image != null)
            {
                PBU_ClientImage.Image = null;
                BTNU_SetClientImage.Visible = true;
            }
        }

        private void TSMIUpdateClient_Click(object sender, EventArgs e)
        {
            TCClients.SelectedIndex = 2;
        }

        private void TSMIDeleteClient_Click(object sender, EventArgs e)
        {
            int ClientID = (int)DGVClients.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you Sure you want to Delete Client with ID {ClientID}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (clsClient_BLL.DeleteClient(ClientID))
                {
                    GetClientsInfo();
                    MessageBox.Show($"Client with ID {ClientID} Deleted successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Operation Failled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Operation has been Canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSMIRefreshClient_Click(object sender, EventArgs e)
        {
            GetClientsInfo();
        }

        private void BTNCSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TXTBS_ClientID.Text))
            {
                clsClient_BLL Client = clsClient_BLL.Find(Convert.ToInt32(TXTBS_ClientID.Text));

                if (Client != null)
                {
                    GetClientInfoToView(Client);
                }
                else MessageBox.Show($"Client with ID {TXTBS_ClientID.Text} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void GetClientInfoToView(clsClient_BLL Client)
        {
            LBV_ClientID.Text = Client.ClientID.ToString();
            LBV_ClientName.Text = Client.ClientName;
            LBV_AccountNumber.Text = Client.AccountNumber.ToString();
            LBV_ClientManagerID.Text = Client.CManagerID.ToString();
            LBV_ClientPhone.Text = Client.ClientPhone;
            LBV_ClientEmail.Text = Client.ClientEmail;
            LBV_ClientBalance.Text = Client.Balance.ToString(); ;
            LBV_ClientAddress.Text = Client.ClientAddress;

            PBV_ClientImage.Load(Client.ClientImagePath);
        }

        private void BTND_FindClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TXTBD_ClientID.Text))
            {
                clsClient_BLL Client = clsClient_BLL.Find(Convert.ToInt32(TXTBD_ClientID.Text));

                if (Client != null)
                {
                    GetClientInfoToView_Deposit(Client);
                    TXTBD_DepositeAmount.Enabled = true;
                    BTNDeposit.Enabled = true;
                }
                else MessageBox.Show($"Client with ID {TXTBD_ClientID.Text} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show($"Please Enter Client ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void GetClientInfoToView_Deposit(clsClient_BLL Client)
        {
            LBD_ClientID.Text = Client.ClientID.ToString();
            LBD_ClientName.Text = Client.ClientName;
            LBD_AccountNumber.Text = Client.AccountNumber.ToString();
            LBD_ManagerID.Text = Client.CManagerID.ToString();
            LBD_ClientPhone.Text = Client.ClientPhone;
            LBD_ClientEmail.Text = Client.ClientEmail;
            LBD_ClientBalance.Text = Client.Balance.ToString(); ;
            LBD_ClientAddress.Text = Client.ClientAddress;

            PBD_ClientImage.Load(Client.ClientImagePath);
        }

        private void TXTBD_DepositeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys like backspace
            if (!char.IsControl(e.KeyChar))
            {
                // Allow digits and the decimal point (.)
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // Block non-numeric and non-decimal input
                }

                // Allow only one decimal point
                if (e.KeyChar == '.' && ((Guna2TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true; // Block additional decimal points
                }
            }
        }

        private void BTNDeposit_Click(object sender, EventArgs e)
        {

        }
    }
}
