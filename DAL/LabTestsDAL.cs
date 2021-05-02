using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact with the DB LabTests table
    /// </summary>
    class LabTestsDAL
    {
        /// <summary>
        /// Retrieves list of LabTests from the DB whose patientID and appointment equals the one passed in
        /// </summary>
        /// <param name="patient_id">Used to retrieve LabTests for that person</param>
        /// <param name="appTime">The appointment time</param>
        /// <returns>Returns list of LabTests from the DB</returns>
        public List<LabTests> GetLabTestsByPatientIDAndAppt(int patient_id, DateTime appTime)
        {
            List<LabTests> _lab_tests = new List<LabTests>();
            string selectStatement = 
                "SELECT pid, appointmentDate, code, dateTaken, dateReturned, result, normal " +
                "FROM LabTests " +
                "WHERE pid = @PatientID and appointmentDate = @appTime";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@PatientID", SqlDbType.Int);
                    selectCommand.Parameters["@PatientID"].Value = patient_id;
                    selectCommand.Parameters.Add("@appTime", SqlDbType.DateTime);
                    selectCommand.Parameters["@appTime"].Value = appTime;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTests _labTest = new LabTests();
                            _labTest.PatientID = (int)reader["pid"];
                            _labTest.AppointmentDate = Convert.ToDateTime(reader["appointmentDate"]);
                            _labTest.Code = (int)reader["code"];
                            if (reader["dateTaken"].GetType() != typeof(DBNull))
                            {
                                _labTest.DateTaken = Convert.ToDateTime(reader["dateTaken"]);
                            }
                            if (reader["dateReturned"].GetType() != typeof(DBNull))
                            {
                                _labTest.DateReturned = Convert.ToDateTime(reader["dateReturned"]);
                            }
                            if (reader["result"].GetType() != typeof(DBNull))
                            {
                                _labTest.Result = (string)reader["result"];
                            }
                            if (reader["normal"].GetType() != typeof(DBNull))
                            {
                                _labTest.Normal = (Int16)reader["normal"];
                            }
                            _lab_tests.Add(_labTest);
                        }
                    }
                }
            }
            return _lab_tests;
        }

        /// <summary>
        /// Retrieves list of LabTests from the DB whose patientID equals the one passed in
        /// </summary>
        /// <param name="patient_id">Used to retrieve LabTests for that person</param>
        /// <returns>Returns list of LabTests from the DB</returns>
        public List<LabTests> GetLabTestsByPatientID(int patient_id)
        {
            List<LabTests> _lab_tests = new List<LabTests>();
            string selectStatement =
                "SELECT pid, appointmentDate, code, dateTaken, dateReturned, result, normal " +
                "FROM LabTests " +
                "WHERE pid = @PatientID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@PatientID", SqlDbType.Int);
                    selectCommand.Parameters["@PatientID"].Value = patient_id;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTests _labTest = new LabTests();
                            _labTest.PatientID = (int)reader["pid"];
                            _labTest.AppointmentDate = Convert.ToDateTime(reader["appointmentDate"]);
                            _labTest.Code = (int)reader["code"];



                            if (reader["dateTaken"].GetType() != typeof(DBNull))
                            {
                                _labTest.DateTaken = Convert.ToDateTime(reader["dateTaken"]);
                            }
                            if (reader["dateReturned"].GetType() != typeof(DBNull))
                            {
                                _labTest.DateReturned = Convert.ToDateTime(reader["dateReturned"]);
                            }

                            if (reader["result"].GetType() != typeof(DBNull))
                            {
                                _labTest.Result = (string)reader["result"];
                            }
                            if (reader["normal"].GetType() != typeof(DBNull))
                            {
                                _labTest.Normal = (Int16)reader["normal"];
                            }
                            _lab_tests.Add(_labTest);
                        }
                    }
                }
            }
            return _lab_tests;
        }

        public LabTests GetLabTestsByPidCodeApptTime(int pid, int code, DateTime apptTime)
        {
            LabTests _labTest = new LabTests();
            string selectStatement =
                "SELECT pid, appointmentDate, code, dateTaken, dateReturned, result, normal " +
                "FROM LabTests " +
                "WHERE pid = @PatientID AND code = @code AND appointmentDate = @apptTime";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@pid", SqlDbType.Int);
                    selectCommand.Parameters["@pid"].Value = pid;
                    selectCommand.Parameters.Add("@code", SqlDbType.Int);
                    selectCommand.Parameters["@code"].Value = code;
                    selectCommand.Parameters.Add("@apptTime", SqlDbType.DateTime);
                    selectCommand.Parameters["@apptTime"].Value = apptTime;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _labTest.PatientID = (int)reader["pid"];
                            _labTest.AppointmentDate = Convert.ToDateTime(reader["appointmentDate"]);
                            _labTest.Code = (int)reader["code"];



                            if (reader["dateTaken"].GetType() != typeof(DBNull))
                            {
                                _labTest.DateTaken = Convert.ToDateTime(reader["dateTaken"]);
                            }
                            if (reader["dateReturned"].GetType() != typeof(DBNull))
                            {
                                _labTest.DateReturned = Convert.ToDateTime(reader["dateReturned"]);
                            }

                            if (reader["result"].GetType() != typeof(DBNull))
                            {
                                _labTest.Result = (string)reader["result"];
                            }
                            if (reader["normal"].GetType() != typeof(DBNull))
                            {
                                _labTest.Normal = (Int16)reader["normal"];
                            }
                        }
                    }
                }
            }
            return _labTest;
        }

        /// <summary>
        /// Adds LabTest to the database
        /// </summary>
        /// <param name="newLabTest">Lab Test to be added</param>
        /// <returns>Returns if addition was successful</returns>
        public bool AddLabTest(LabTests newLabTest)
        {
            string insertStatement = 
                "INSERT INTO LabTests (pid, appointmentDate, code) " +
                "VALUES (@PatientID, @AppointmentDate, @Code)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.Add("@PatientID", SqlDbType.Int);
                    insertCommand.Parameters["@PatientID"].Value = newLabTest.PatientID;
                    insertCommand.Parameters.Add("@AppointmentDate", SqlDbType.DateTime);
                    insertCommand.Parameters["@AppointmentDate"].Value = newLabTest.AppointmentDate;
                    insertCommand.Parameters.Add("@Code", SqlDbType.Int);
                    insertCommand.Parameters["@Code"].Value = newLabTest.Code;

                    insertCommand.ExecuteNonQuery();
                    return true;
                }
            }
        }

        /// <summary>
        /// Adds LabTest to the database
        /// </summary>
        /// <param name="newLabTest">Lab Test to be added</param>
        /// <returns>Returns if addition was successful</returns>
        public Boolean UpdateLabTest(LabTests labTest, LabTests oldLabTest)
        {  
            string updateStatement =
                 "UPDATE dbo.LabTests SET pid =  @pid, appointmentDate = @appointmentDate, " +
                 "code = @code, dateTaken = @dateTaken, dateReturned = @dateReturned, result = @result, normal = @normal " +
                 "WHERE pid = @oldPatientID " +
                 "AND appointmentDate = @oldAppointmentDate " +
                 "AND code = @oldCode";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@pid", SqlDbType.Int);
                    cmd.Parameters["@pid"].Value = labTest.PatientID;
                    cmd.Parameters.Add("@appointmentDate", SqlDbType.DateTime);
                    cmd.Parameters["@appointmentDate"].Value = labTest.AppointmentDate;
                    cmd.Parameters.Add("@code", SqlDbType.Int);
                    cmd.Parameters["@code"].Value = labTest.Code;
                    cmd.Parameters.Add("@dateTaken", SqlDbType.DateTime);
                    cmd.Parameters["@dateTaken"].Value = labTest.DateTaken;
                    cmd.Parameters.Add("@dateReturned", SqlDbType.DateTime);
                    cmd.Parameters["@dateReturned"].Value = labTest.DateReturned;
                    cmd.Parameters.Add("@result", SqlDbType.VarChar);
                    cmd.Parameters["@result"].Value = labTest.Result;
                    cmd.Parameters.Add("@normal", SqlDbType.TinyInt);
                    cmd.Parameters["@normal"].Value = labTest.Normal;

                    cmd.Parameters.Add("@oldAppointmentDate", SqlDbType.DateTime);
                    cmd.Parameters["@oldAppointmentDate"].Value = oldLabTest.AppointmentDate;
                    cmd.Parameters.Add("@oldPatientID", SqlDbType.Int);
                    cmd.Parameters["@oldPatientID"].Value = oldLabTest.PatientID;
                    cmd.Parameters.Add("@oldCode", SqlDbType.Int);
                    cmd.Parameters["@oldCode"].Value = oldLabTest.Code;

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
