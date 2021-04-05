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

        /// <summary>
        /// Method to get visit information from the DAL by patient NurseID and datetime
        /// </summary>
        /// <param name="time">the datetime of the appointment</param> 
        /// <param name="pID">the patient NurseID</param>
        /// <returns>a visit object</returns>
        public Visit GetVisitByKeys(DateTime time, int pID)
        {
            Visit visit = new Visit();

            string selectStatement =
            "SELECT time, nid, weight, systolic, diastolic, temperature, pulse,  symptoms,  initialDiagnosis, finalDiagnosis " +
            "FROM Visit " +
            "Where pid = @id and time = @time;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@id"].Value = pID;

                    selectCommand.Parameters.Add("@time", System.Data.SqlDbType.DateTime);
                    selectCommand.Parameters["@time"].Value = time;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visit.NurseID = (int)reader["nid"];
                            visit.Weight = (decimal)reader["weight"];
                            visit.Systolic = (int)reader["systolic"];
                            visit.Diastolic = (int)reader["diastolic"];
                            visit.Temperature = (decimal)reader["temperature"];
                            visit.Pulse = (int)reader["pulse"];
                            visit.Symptoms = reader["symptoms"].ToString();
                            visit.InitialDiagnosis = reader["initialDiagnosis"].ToString();
                            visit.FinalDiagnosis = reader["finalDiagnosis"].ToString();
                        }
                    }
                }
            }
                return visit;
        }

        /// <summary>
        /// Method to insert new visit information into the Visit table of the DB
        /// </summary>
        /// <param name="visit">the visit to be entered into the DB</param> 
        /// <returns>true if the visit object was successfully entered</returns>
        public bool EnterVisit(Visit visit)
        {
            string insertStatement = 
                "INSERT INTO dbo.Visit " +
                "(pid, time, nid, weight, systolic, diastolic, temperature, pulse, symptoms, initialDiagnosis, finalDiagnosis) " +
                "VALUES (@pid, @time, @nid, @weight, @systolic, @diastolic, @temperature, @pulse, @symptoms, @initialDiagnosis, @finalDiagnosis);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.Add("@pid", System.Data.SqlDbType.Int);
                    cmd.Parameters["@pid"].Value = visit.PatientID;

                    cmd.Parameters.Add("@time", System.Data.SqlDbType.DateTime);
                    cmd.Parameters["@time"].Value = visit.DateTime;

                    cmd.Parameters.Add("@nid", System.Data.SqlDbType.Int);
                    cmd.Parameters["@nid"].Value = visit.NurseID;

                    cmd.Parameters.Add("@weight", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@weight"].Value = visit.Weight;

                    cmd.Parameters.Add("@systolic", System.Data.SqlDbType.Int);
                    cmd.Parameters["@systolic"].Value = visit.Systolic;

                    cmd.Parameters.Add("@diastolic", System.Data.SqlDbType.Int);
                    cmd.Parameters["@diastolic"].Value = visit.Diastolic;

                    cmd.Parameters.Add("@temperature", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@temperature"].Value = visit.Temperature;

                    cmd.Parameters.Add("@pulse", System.Data.SqlDbType.Int);
                    cmd.Parameters["@pulse"].Value = visit.Pulse;

                    cmd.Parameters.Add("@symptoms", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@symptoms"].Value = visit.Symptoms;

                    cmd.Parameters.Add("@initialDiagnosis", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@initialDiagnosis"].Value = visit.InitialDiagnosis;


                    cmd.Parameters.Add("@finalDiagnosis", System.Data.SqlDbType.VarChar);

                    if (String.IsNullOrEmpty(visit.FinalDiagnosis))
                    {
                        cmd.Parameters["@finalDiagnosis"].Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters["@finalDiagnosis"].Value = visit.FinalDiagnosis;
                    }
                    

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
