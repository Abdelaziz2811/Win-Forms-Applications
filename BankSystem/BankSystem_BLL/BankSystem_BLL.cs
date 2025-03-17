using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using BankSystem_DAL;

namespace BankSystem_BLL
{
    public enum enMode { Add, Update };

    public class clsUser_BLL
    {
        public int UserID { set; get; }
        public string Name { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public int ManagerID { set; get; }
        public int Permissions { set; get; }
        public string ImagePath { set; get; }
        public enMode UMode { set; get; }

        public clsUser_BLL()
        {
            this.UserID = -1;
            this.Name = string.Empty;
            this.Username = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.Address = string.Empty;
            this.Password = string.Empty;
            this.ManagerID = 0;
            this.Permissions = 0;
            this.ImagePath = string.Empty;
            UMode = enMode.Add;
        }

        private clsUser_BLL(int UserID, string Name, string Username, string Phone, string Email,
        string Address, string Password, int ManagerID, int Permissions, string ImagePath)
        {
            this.UserID = UserID;
            this.Name = Name;
            this.Username = Username;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.Password = Password;
            this.ManagerID = ManagerID;
            this.Permissions = Permissions;
            this.ImagePath = ImagePath;
            UMode = enMode.Update;
        }

        private bool _AddUser()
        {
            this.UserID = clsUser_DAL.AddUser(this.Name, this.Username, this.Password, this.Phone, this.Email,
                                       this.Address, this.ManagerID, this.Permissions, this.ImagePath);
            return this.UserID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUser_DAL.UpdateUser(this.UserID, this.Name, this.Password, this.Phone, this.Email,
                                       this.Address, this.ManagerID, this.Permissions, this.ImagePath);
        }

        public static clsUser_BLL Find(string Username, string Password)
        {
            User User = new User { UserID = -1, Name = string.Empty, Username = string.Empty,
                                   Password = string.Empty, Phone = string.Empty, Email = string.Empty,
                                   Address = string.Empty, ManagerID = -1, Permissions = 0, ImagePath = string.Empty };

            if (clsUser_DAL.Find(ref User, Username, Password))
            {
                return new clsUser_BLL(User.UserID, User.Name, User.Username, User.Phone, User.Email, User.Address,
                                       User.Password, User.ManagerID, User.Permissions, User.ImagePath);
            }
            else
                return null;
        }

        public static clsUser_BLL Find(int ID)
        {
            User User = new User { UserID = -1, Name = string.Empty, Username = string.Empty,
                                   Password = string.Empty, Phone = string.Empty, Email = string.Empty,
                                   Address = string.Empty, ManagerID = -1, Permissions = 0, ImagePath = string.Empty };

            if (clsUser_DAL.Find(ref User, ID))
            {
                return new clsUser_BLL(User.UserID, User.Name, User.Username, User.Phone, User.Email, User.Address,
                                       User.Password, User.ManagerID, User.Permissions, User.ImagePath);
            }
            else
                return null;
        }
    
        public bool Save()
        {
            switch (UMode)
            {
                case enMode.Add:

                    return _AddUser();
                
                case enMode.Update:

                    return _UpdateUser();
                
                default:
                    return false;
            }
        }

        public void AddToRemeberedUsers()
        {
            clsUser_DAL.AddToRemeberedUsers(this.Username, this.Password);
        }

        public static void GetRememberedUserCredentials(ref string Username, ref string Password)
        {
            clsUser_DAL.GetRememberedUserCredentials(ref Username, ref Password);
        }

        public static DataTable GetUsersInfo()
        {
            return clsUser_DAL.GetUsersInfo();
        }

        public static bool IsUsernameExists(string Username)
        {
            return clsUser_DAL.IsUsernameExists(Username);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUser_DAL.DeleteUser(UserID);
        }
    }

    public class clsClient_BLL
    {
        public int ClientID { set; get; }                       
        public int AccountNumber { set; get; }
        public string ClientName { set; get; }
        public string ClientPhone { set; get; }
        public string ClientEmail { set; get; }
        public string ClientAddress { set; get; }
        public int CManagerID { set; get; }
        public decimal Balance { set; get; }
        public string Pincode { set; get; }
        public string ClientImagePath { set; get; }
        public enMode CMode { set; get; }

        public clsClient_BLL()
        {
            this.ClientID = -1;
            this.AccountNumber = 0;
            this.ClientName = string.Empty;            
            this.ClientPhone = string.Empty;
            this.ClientEmail = string.Empty;
            this.ClientAddress = string.Empty;
            this.Pincode = string.Empty;
            this.CManagerID = 0;
            this.Balance = 0;
            this.ClientImagePath = string.Empty;
            CMode = enMode.Add;
        }

        private clsClient_BLL(int UserID, int AccountNumber, string ClientName, string ClientPhone, string ClientEmail,
        string ClientAddress, string Pincode, int CManagerID, decimal Balance, string ClientImagePath)
        {
            this.ClientID = UserID;
            this.AccountNumber = AccountNumber;
            this.ClientName = ClientName;
            this.ClientPhone = ClientPhone;
            this.ClientEmail = ClientEmail;
            this.ClientAddress = ClientAddress;
            this.Pincode = Pincode;
            this.CManagerID = CManagerID;
            this.Balance = Balance;
            this.ClientImagePath = ClientImagePath;
            CMode = enMode.Update;
        }

        private bool _AddClient()
        {
            this.ClientID = clsClient_DAL.AddClient(this.ClientID, this.AccountNumber, this.ClientName, this.ClientPhone, this.ClientEmail,
                                          this.ClientAddress, this.Pincode, this.CManagerID, this.Balance, this.ClientImagePath);
            return this.ClientID != -1;
        }

        private bool _UpdateClient()
        {
            return clsClient_DAL.UpdateClient(this.ClientID, this.ClientName, this.ClientPhone, this.ClientEmail, this.ClientAddress,
                                 this.Pincode, this.CManagerID, this.Balance, this.ClientImagePath);
        }
       
        public static clsClient_BLL Find(int ClientID)
        {
            int AccountNumber = 0;
            string Name = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            string Address = string.Empty;
            string Pincode = string.Empty; 
            int ManagerID = 0;
            decimal Balance = 0;
            string ClientImagePath = string.Empty;

            if (clsClient_DAL.Find(ClientID, ref AccountNumber, ref Name, ref Phone, ref Email, ref Address, ref Pincode,
                ref ManagerID, ref Balance, ref ClientImagePath))
            {
                return new clsClient_BLL(ClientID, AccountNumber, Name, Phone, Email, Address, Pincode,
                                        ManagerID, Balance, ClientImagePath);
            }
            else
                return null;
        }

        public static string GetManagerName(int ManagerID)
        {
            return clsClient_DAL.GetManagerName(ManagerID);
        }

        public static DataTable GetClientsInfo()
        {
            return clsClient_DAL.GetClientsInfo();
        }

        public static bool IsAccountNumberExists(int AccountNumber)
        {
            return clsClient_DAL.IsAccountNumberExists(AccountNumber);
        }

        public static bool DeleteClient(int ClientID)
        {
            return clsClient_DAL.DeleteClient(ClientID);
        }

        public bool Save()
        {
            switch (CMode)
            {
                case enMode.Add:

                    return _AddClient();

                case enMode.Update:

                    return _UpdateClient();

                default:
                    return false;
            }
        }
    }
}
