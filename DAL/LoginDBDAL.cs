using ClinicSupport.Model;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class with interact with the Login table of the CS6232-g5 DB
    /// </summary>
    class LoginDBDAL
    {

        /// <summary>
        /// 0-parameter constructor for the LoginDBDAL class
        /// </summary>
        public LoginDBDAL()
        { 
        }

        /// <summary>
        /// Method to get the login information from CS6232-g5 DB
        /// </summary>
        /// <param user = "user">the user's given username</param> 
        /// <param password = "hashedPassword">the users hashed password</param> 
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
    }
}
