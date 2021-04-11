using ClinicSupport.Model;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact with the Nurse table of the ClinicSupport DB
    /// </summary>
    class NurseDAL
    {
        /// <summary>
        /// Method to get the Nurse information from CS6232-g5 DB
        /// </summary>
        /// <param name = "username">the Nurse's username</param> 
        /// <returns>A new Nurse object</returns>
        public Nurse GetNurseByUsername(string username)
        {
            Nurse nurse = new Nurse();

            string selectStatement = "SELECT n.nid, n.username, n.iid, l.privilege FROM Nurse n join Login l on l.username = n.username WHERE n.username = @username;";

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
                            nurse.NurseID = (int)reader["nid"];
                            nurse.Username = reader["username"].ToString();
                            nurse.IndividualID = (int)reader["iid"];
                            nurse.Privilege = reader["privilege"].ToString();
                        }
                    }
                }
            }

            return nurse;
        }

        /// <summary>
        /// Method to update the Nurse information in the DB
        /// </summary>
        /// <param name = "nurse">the Nurse object to be passed from the controller</param> 
        /// <returns>true if Nurse is updated successfully in the DB</returns>
        public bool UpdateNurse(Nurse nurse)
        {
            string updateStatement = "UPDATE Login " +
                "SET privilege = @privilege " + 
                "WHERE username = @username;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.Add("@privilege", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@privilege"].Value = nurse.Privilege;

                    cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@username"].Value = nurse.Username;

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
