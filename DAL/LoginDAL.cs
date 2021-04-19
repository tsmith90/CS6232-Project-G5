using ClinicSupport.Model;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class with interact with the Login table of the CS6232-g5 DB
    /// </summary>
    class LoginDAL
    {
        /// <summary>
        /// Method to get the login information from CS6232-g5 DB
        /// </summary>
        /// <param name = "user">the user's given username</param> 
        /// <param name = "hashedPassword">the users hashed password</param> 
        /// <returns>A new User with a username and privileges</returns>
        public User GetLoginInformation(string user, string hashedPassword)
        {
            User newUser = new User();
            string selectStatement = "SELECT username, privilege FROM Login where username = @user and password = @password;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@user", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@user"].Value = user;

                    selectCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@password"].Value = hashedPassword;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            newUser.Username = reader["username"].ToString();
                            newUser.Privileges = reader["privilege"].ToString();
                        }
                    }
                }
            }
            return newUser;
        }

        /// <summary>
        /// Sets a new password in the DB for an employee
        /// </summary>
        /// <param name="username">the individual's username</param>
        /// <param name="newUsername">the individual's new username</param>
        /// <param name="password">the individual's new password</param>
        /// <returns>true if the DB successfully sets a new password</returns>
        public bool SetLoginInformation(string username, string newUsername, string password)
        {
            string updateStatement = "UPDATE dbo.Login SET username = @newUsername, password = @password WHERE username = @username;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(updateStatement, connection))
                {
                    selectCommand.Parameters.Add("@newUsername", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@newUsername"].Value = newUsername;

                    selectCommand.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@username"].Value = username;

                    selectCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@password"].Value = password;

                    int count = selectCommand.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
