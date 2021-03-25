using ClinicSupport.Model;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    class LoginDBDAL
    {

        public LoginDBDAL()
        { 
        }

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
