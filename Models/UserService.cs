using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketBookingManagementSystem.Config;
using System.Data.SqlClient;

namespace MovieTicketBookingManagementSystem.Models
{
    public static class UserService
    {
        private static readonly string conn = DatabaseConfig.ConnectionString;
        public static bool IsUsernameTaken(string username)
        {
            using (SqlConnection connect = new SqlConnection(conn)) {
                string query = "SELECT COUNT(*) FROM users WHERE Username = @Username";
                using (SqlCommand cmd= new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    connect.Open();
                    int count = (int)cmd.ExecuteScalar();
                    connect.Close();
                    return count > 0;
                }
            }
        }
        public static bool RegisterUser(Users user)
        {
            DateTime today = DateTime.Today;
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query= @"INSERT INTO users(Username,Password,Firstname,Lastname,Gender,Birthdate,Email,Phone,Address,CreatedAt)
                                 VALUES(@usern, @pw,@fname,@lname,@gender,@birthdate,@email,@phone,@address,@createdat)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", user.Username);
                    cmd.Parameters.AddWithValue("@pw", user.Password);
                    cmd.Parameters.AddWithValue("@fname", user.Firstname);
                    cmd.Parameters.AddWithValue("@lname", user.Lastname);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@birthdate", user.Birthdate);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@phone", user.Phone);
                    cmd.Parameters.AddWithValue("@address", user.Address);
                    cmd.Parameters.AddWithValue("@createdat", today);
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rowsAffected > 0; // Returns true if the user was successfully registered
                }
            }
        }
        public static bool AuthenticateUser(string username, string password, out string role)
        {
            role = null;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT UserID, Password, Role FROM users WHERE Username = @Username AND IsActive = 1";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username.Trim());
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string hashedPassword = reader["Password"].ToString();
                        role = reader["Role"].ToString();
                        // Verify the password
                        if (PasswordHasher.VerifyPassword(password, hashedPassword))
                        {
                            SessionManager.Username = username;
                            SessionManager.Role = role;
                            SessionManager.UserID = Convert.ToInt32(reader["UserID"]);
                            return true; // Authentication successful
                        }
                    }
                }
            }
            return false; // Authentication failed
        }
    }
}

