using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact and manipulate the DB for Patients
    /// </summary>
    class PatientDAL
    {
        /// <summary>
        /// Get all the Patient objects from the data source.
        /// </summary>
        /// <returns>a list of Patient objects</returns>
        public List<Patient> GetPatients()
        {
            List<Patient> _patients = new List<Patient>();
            string selectStatement =
                "SELECT pid, iid " +
                 "FROM Patient";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
                            patient.PatientID = (int)reader["pid"];
                            patient.IndividualID = (int)reader["iid"];
                            _patients.Add(patient);
                        }
                    }
                }
            }
            return _patients;
        }

        /// <summary>
        /// Get the Patient object from the data source.
        /// </summary>
        /// <param name="pid">pid</param>
        /// <returns>the Patient object</returns>
        public Patient GetPatientbyID(int pid)
        {
            Patient _patient = new Patient();
            string selectStatement =
                "SELECT pid, iid " +
                 "FROM Patient " +
                 "WHERE pid = @pid";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@pid", SqlDbType.Int);
                    selectCommand.Parameters["@pid"].Value = pid;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _patient.PatientID = (int)reader["pid"];
                            _patient.IndividualID = (int)reader["iid"];
                        }
                    }
                }
            }
            return _patient;
        }

        /// <summary>
        /// Adds passed in individualID to the Patient table
        /// </summary>
        /// <param name="individualID">ID of individual recently added to Individual table and to be added to the Patient table</param>
        /// <returns>Returns the new patientID for the patient that was just created</returns>
        public int AddPatient(int individualID)
        {
            string insertStatement =
                "INSERT INTO Patient (iid) " +
                "VALUES (@IndividualID);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@IndividualID", individualID);

                    insertCommand.ExecuteNonQuery();
                }

                string selectStatement = "SELECT IDENT_CURRENT('Patient') FROM Patient;";
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    int patientID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return patientID;
                }
            }
        }

        /// <summary>
        /// Get the Patient object from the data source.
        /// </summary>
        /// <param name="fname">fname</param>
        /// <param name="lname">lname</param>
        /// <param name="dob">dob</param>
        /// <returns>the Patient object</returns>
        public Patient GetPatientbyNameAndDOB(string fname, string lname, DateTime dob)
        {
            Patient _patient = new Patient();
            string selectStatement =
                "SELECT pid, p.iid " +
                 "FROM Patient p " +
                 "INNER JOIN Individual i " +
                 "ON i.iid = p.iid " +
                 "WHERE fname = @fname AND lname = @lname AND dob = @dob";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@fname", SqlDbType.VarChar);
                    selectCommand.Parameters["@fname"].Value = fname;
                    selectCommand.Parameters.Add("@lname", SqlDbType.VarChar);
                    selectCommand.Parameters["@lname"].Value = lname;
                    selectCommand.Parameters.Add("@dob", SqlDbType.Date);
                    selectCommand.Parameters["@dob"].Value = dob.ToString("yyyy-MM-dd"); ;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _patient.PatientID = (int)reader["pid"];
                            _patient.IndividualID = (int)reader["iid"];
                        }
                    }
                }
            }
            return _patient;
        }
    }
}
