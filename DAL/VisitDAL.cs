using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact with DB Visit table
    /// </summary>
    class VisitDAL
    {
        /// <summary>
        /// Method to retrieve information about visits from the Visit table
        /// </summary>
        /// <param name="id">the Patient id</param>
        /// <returns>a list of visits according to the patient id</returns>
        public List<Visit> GetVisitsByID(int id)
        {
            List<Visit> visitList = new List<Visit>();

            string selectStatement =
            "SELECT time, nid, weight, systolic, diastolic, temperature, pulse,  symptoms,  initialDiagnosis, finalDiagnosis " +
            "FROM Visit " +
            "Where pid = @id;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@id"].Value = id;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visit visit = new Visit();

                            visit.DateTime = (DateTime)reader["time"];
                            visit.NurseID = (int)reader["nid"];
                            visit.Weight = (decimal)reader["weight"];
                            visit.Systolic = (int)reader["systolic"];
                            visit.Diastolic = (int)reader["diastolic"];
                            visit.Temperature = (decimal)reader["temperature"];
                            visit.Pulse = (int)reader["pulse"];
                            visit.Symptoms = reader["symptoms"].ToString();
                            visit.InitialDiagnosis = reader["initialDiagnosis"].ToString();
                            visit.FinalDiagnosis = reader["finalDiagnosis"].ToString();
                           
                            visitList.Add(visit);
                        }
                    }
                }
            }

            return visitList;
        }
    }
}
