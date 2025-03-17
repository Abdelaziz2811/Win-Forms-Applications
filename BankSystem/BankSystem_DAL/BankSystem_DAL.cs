using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;

namespace BankSystem_DAL
{
    public class clsUser_DAL
    {
        public static bool Find(ref User User, string Username, string Password)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"SELECT * FROM Users
                             WHERE Username = @Username AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    User.UserID = (int)reader["UserID"];
                    User.Username = reader["Username"] as string;
                    User.Name = reader["Name"] as string;
                    User.Phone = reader["Phone"] as string;
                    User.Email = reader["Email"] as string;
                    User.Address = reader["Address"] as string;
                    User.Password = reader["Password"] as string;

                    if (reader["ManagerID"] != System.DBNull.Value)
                        User.ManagerID = (int)reader["ManagerID"];
                    
                    User.Permissions = (int)reader["Permissions"];
                    User.ImagePath = reader["ImagePath"] as string;
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool Find(ref User User, int ID)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"SELECT * FROM Users
                             WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    User.UserID = (int)reader["UserID"];
                    User.Username = reader["Username"] as string;
                    User.Name = reader["Name"] as string;
                    User.Phone = reader["Phone"] as string;
                    User.Email = reader["Email"] as string;
                    User.Address = reader["Address"] as string;
                    User.Password = reader["Password"] as string;

                    if (reader["ManagerID"] != System.DBNull.Value)
                        User.ManagerID = (int)reader["ManagerID"];

                    User.Permissions = (int)reader["Permissions"];
                    User.ImagePath = reader["ImagePath"] as string;
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int AddUser(string Name, string Username, string Password, string Phone, string Email,
            string Address, int ManagerID, int Permissions, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"INSERT INTO Users
                             VALUES (@Username, @Name, @Phone, @Email,
                             @Address, @Password, @ManagerID,
                             @Permissions, @ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@ManagerID", ManagerID);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            int UserID = -1;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    UserID = ID;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, string Name, string Password, string Phone, string Email,
            string Address, int ManagerID, int Permissions, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"UPDATE Users
                             SET Name = @Name, Phone = @Phone, Email = @Email,
                             Address = @Address, Password = @Password, ManagerID = @ManagerID,
                             Permissions = @Permissions, ImagePath = @ImagePath
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@ManagerID", ManagerID);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@UserID", UserID);

            int RowsAffected = 0;

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected != 0;
        }

        public static void AddToRemeberedUsers(string Username, string Password)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"DELETE RemeberedUsers;
                             INSERT INTO RemeberedUsers VALUES (@Username, @Password);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public static void GetRememberedUserCredentials(ref string Username, ref string Password)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"SELECT * FROM RemeberedUsers";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Username = reader["Username"] as string;
                    Password = reader["Password"] as string;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable GetUsersInfo()
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"SELECT * FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DTUsers = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DTUsers.Load(reader);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTUsers;
        }

        public static bool IsUsernameExists(string Username)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"SELECT Username FROM Users
                             WHERE Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            bool IsFound = false;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    IsFound = true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool DeleteUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"DELETE FROM Users
                             WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            int RowsAffected = 0;

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }
    }

    public class clsClient_DAL
    {
        public static DataTable GetClientsInfo()
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"SELECT * FROM Clients";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DTClients = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DTClients.Load(reader);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return DTClients;
        }

        public static bool Find(int ClientID, ref int AccountNumber, ref string Name, ref string Phone, ref string Email,
                                ref string Address, ref string Pincode, ref int ManagerID, ref decimal Balance, ref string ClientImagePath)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"SELECT * FROM Clients
                             WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Pincode", Pincode);
            command.Parameters.AddWithValue("@ManagerID", ManagerID);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@ClientImagePath", ClientImagePath);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    AccountNumber = (int)reader["AccountNumber"];
                    Name = reader["Name"] as string;
                    Phone = reader["Phone"] as string;
                    Email = reader["Email"] as string;
                    Address = reader["Address"] as string;
                    Pincode = reader["Pincode"] as string;
                    ManagerID = (int)reader["ManagerID"];
                    Balance = (decimal)reader["Balance"];
                    ClientImagePath = reader["ImagePath"] as string;
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static string GetManagerName(int ManagerID)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"SELECT DISTINCT Users.Username FROM Clients
                             INNER JOIN Users ON Clients.ManagerID = Users.UserID
                             WHERE Clients.ManagerID = @ManagerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ManagerID", ManagerID);

            string Username = string.Empty;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    Username = Result.ToString();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Username;
        }

        public static bool IsAccountNumberExists(int AccountNumber)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"SELECT * FROM Clients
                             WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            bool IsFound = false;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    IsFound = true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
    
        public static int AddClient(int ClientID, int AccountNumber, string ClientName, string ClientPhone, string ClientEmail,
                          string ClientAddress, string Pincode, int CManagerID, decimal Balance, string ClientImagePath)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"INSERT INTO Clients VALUES 
                             (@AccountNumber, @ClientName, @ClientEmail, @ClientPhone, @ClientAddress, @Balance, @Pincode,  
                             @ClientImagePath, @CManagerID);  
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@ClientName", ClientName);
            command.Parameters.AddWithValue("@ClientPhone", ClientPhone);
            command.Parameters.AddWithValue("@ClientEmail", ClientEmail);
            command.Parameters.AddWithValue("@ClientAddress", ClientAddress);
            command.Parameters.AddWithValue("@Pincode", Pincode);
            command.Parameters.AddWithValue("@CManagerID", CManagerID);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@ClientImagePath", ClientImagePath);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    ClientID = ID;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return ClientID;
        }

        public static bool UpdateClient(int ClientID, string Name, string Phone, string Email, string Address, string Pincode,
                           int ManagerID, decimal Balance, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"UPDATE Clients SET 
                             Name = @Name, Email = @Email, Phone = @Phone, Address = @Address,
                             Balance = @Balance, Pincode = @Pincode, ImagePath = @ImagePath,
                             ManagerID = @ManagerID
                             WHERE ClientID = @ClientID;";
            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Pincode", Pincode);
            command.Parameters.AddWithValue("@ManagerID", ManagerID);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            int RowsAffected = 0;

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected != 0;
        }

        public static bool DeleteClient(int ClientID)
        {
            SqlConnection connection = new SqlConnection(DALSettings.ConnectionString);

            string query = @"DELETE FROM Clients
                             WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            int RowsAffected = 0;

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }
    }
}
