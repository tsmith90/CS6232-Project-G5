using ClinicSupport.Model;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact with the DB directly for the Admin table
    /// </summary>
    class AdministratorDAL
    {

        /// <summary>
        /// Method to get the Administrator information from CS6232-g5 DB
        /// </summary>
        /// <param name = "username">the Admin's username</param> 
        /// <returns>A new Administrator object</returns>
        public Administrator GetAdminByUsername(string username)
        {
            Administrator admin = new Administrator();

            string selectStatement =
                "SELECT a.aid, a.username, a.iid, l.privilege, i.lname as last, i.fname as first " +
                "FROM Administrator a join Login l on l.username = a.username " +
                "join Individual i on a.iid = i.iid " +
                "WHERE a.username = @username;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@username"].Value = username;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            admin.AdministratorID = (int)reader["aid"];
                            admin.Username = reader["username"].ToString();
                            admin.IndividualID = (int)reader["iid"];
                            admin.Privilege = reader["privilege"].ToString();
                            admin.LastName = reader["last"].ToString();
                            admin.FirstName = reader["first"].ToString();
                        }
                    }
                }
            }

            return admin;
        }
    }
}
