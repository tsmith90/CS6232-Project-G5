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
        /// <param name = "username">the Nurse username</param> 
        /// <returns>A new Nurse object</returns>
        public Nurse GetNurseByUsername(string username)
        {
            Nurse nurse = new Nurse();

            string selectStatement = "SELECT n.nid, n.username, n.iid FROM Nurse n join Login l on l.username = n.username WHERE n.username = @username;";

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
                            nurse.IndividualID= (int)reader["iid"];
                        }
                    }
                }
            }

            return nurse;
        }
    }
}
