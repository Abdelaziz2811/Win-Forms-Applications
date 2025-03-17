using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_DAL
{
    public static class DALSettings
    {
        public static string ConnectionString { get; } = "Server = .; Database = Bank_SystemDB; User ID = sa; Password = 123456";
    }

    public struct User
    {
        public int UserID { set; get; }
        public string Name { set; get; }
        public string Username { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Password { set; get; }
        public int ManagerID { set; get; }
        public int Permissions { set; get; }
        public string ImagePath { set; get; }
    }

}
