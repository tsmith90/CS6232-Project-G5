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
        /// <param name="pid">the patient id</param>
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

        /// <summary>
        /// Retrieves list of patients that have a DOB equal to the dob passed in
        /// </summary>
        /// <param name="dob">Date to search patients by</param>
        /// <returns>Returns list of individuals who are patients that have a DOB equal to the dob passed in</returns>
        public List<Individual> GetPatientsByDOB(DateTime dob)
        {
            List<Individual> _patients = new List<Individual>();
            string selectStatement = 
                "SELECT p.pid, fname, lname, streetAddress, dob, city, state, zip, phone " +
                "FROM Individual i INNER JOIN Patient p ON " +
                "i.iid = p.iid " +
                "WHERE dob = @DOB";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@DOB", dob.ToString("yyyy-MM-dd"));
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient _patient = new Patient();
                            Individual _individual = new Individual();
                            _patient.PatientID = (int)reader["pid"];
                            _individual.FirstName = (string)reader["fname"];
                            _individual.LastName = (string)reader["lname"];
                            _individual.DateOfBirth = Convert.ToDateTime(reader["dob"]);
                            _individual.StreetAddress = (string)reader["streetAddress"];
                            _individual.City = (string)reader["city"];
                            _individual.State = (string)reader["state"];
                            _individual.ZipCode = Convert.ToInt32(reader["zip"]);
                            _individual.PhoneNumber = (string)reader["phone"];
                            _patients.Add(_individual);
                        }
                    }
                }
            }
            return _patients;
        }

        /// <summary>
        /// Retrieves list of patients that have a first and last name equal to the ones passed in
        /// </summary>
        /// <param name="fname">First name of patient</param>
        /// <param name="lname">Last name of patient</param>
        /// <returns>Returns list of patients that have a first and last name equal to the ones passed in</returns>
        public List<Patient> GetPatientsByFirstAndLastName(string fname, string lname)
        {
            List<Patient> _patients = new List<Patient>();
            return _patients;
        }

        /// <summary>
        /// Retrieves list of patients that have a last name and DOB equal to the last name and dob passed in
        /// </summary>
        /// <param name="lname">Last name of patient</param>
        /// <param name="dob">Date of birth of the patient</param>
        /// <returns>Returns list of patients that have a last name and DOB equal to the last name and dob passed in</returns>
        public List<Patient> GetPatientsByLastNameAndDOB(string lname, DateTime dob)
        {
            List<Patient> _patients = new List<Patient>();
            return _patients;
        }
    }
}
