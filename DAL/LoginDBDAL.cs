using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    class LoginDBDAL
    {

        public LoginDBDAL()
        { 
        }

        public string GetLoginInformation(string user, string hashedPassword)
        {
            string privileges = "";
            string selectStatement = "SELECT privilege FROM Login where username = @user and password = @password;";

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
                                privileges = reader["privilege"].ToString();
                            }
                    }
                }
            }

            return privileges;
        }
    }
}
