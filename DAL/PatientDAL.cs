﻿using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public int AddPatient(Individual newIndividual)
        {
            string insertStatement =
                "BEGIN TRANSACTION " +
                    "DECLARE @iid int;" +
                    "INSERT INTO Individual (lname, fname, dob, streetAddress, city, state, zip, phone, ssn) " +
                    "VALUES (@LastName, @FirstName, @DOB, @Address, @City, @State, @Zip, @Phone, @SSN);" +
                    "SELECT @iid = scope_identity();" +
                    "INSERT INTO Patient (iid) VALUES(@iid); " +
                "COMMIT";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@LastName", newIndividual.LastName);
                    insertCommand.Parameters.AddWithValue("@FirstName", newIndividual.FirstName);
                    insertCommand.Parameters.AddWithValue("@DOB", newIndividual.DateOfBirth);
                    insertCommand.Parameters.AddWithValue("@Address", newIndividual.StreetAddress);
                    insertCommand.Parameters.AddWithValue("@City", newIndividual.City);
                    insertCommand.Parameters.AddWithValue("@State", newIndividual.State);
                    insertCommand.Parameters.AddWithValue("@Zip", newIndividual.ZipCode);
                    insertCommand.Parameters.AddWithValue("@Phone", newIndividual.PhoneNumber);
                    insertCommand.Parameters.AddWithValue("@SSN", newIndividual.SSN);

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
        /// Method to delete Patient information in the DB
        /// </summary>
        /// <param name="pid">The patient id</param>
        /// <returns>True if individual is successfully deleted</returns>
        public bool DeletePatientWithoutAppointment(int pid)
        {
            int countAppointments = 0;
            int individiualID = 0;
            string deletePatient = "DELETE FROM Patient WHERE pid = @pid;";
            string deleteIndividual = "DELETE FROM Individual WHERE iid = @iid";
            string selectIndividual = "SELECT iid FROM Patient Where pid = @pid;";
            string checkAppointments = "SELECT count(pid) as counted FROM  Appointment WHERE pid = @pid;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(checkAppointments, connection))
                {
                    selectCommand.Parameters.Add("@pid", SqlDbType.Int);
                    selectCommand.Parameters["@pid"].Value = pid;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            countAppointments = (int)reader["counted"];
                        }

                        if (countAppointments > 0)
                        {
                            throw new Exception("Can't delete. That patient has appointments.");
                        }
                    }
                }

                using (SqlCommand selectIndividualCommand = new SqlCommand(selectIndividual, connection))
                {
                    selectIndividualCommand.Parameters.Add("@pid", SqlDbType.Int);
                    selectIndividualCommand.Parameters["@pid"].Value = pid;

                    using (SqlDataReader reader = selectIndividualCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            individiualID = (int)reader["iid"];
                        }
                    }
                }

                using (SqlCommand cmd = new SqlCommand(deletePatient, connection))
                {
                    cmd.Parameters.Add("@pid", SqlDbType.Int);
                    cmd.Parameters["@pid"].Value = pid;

                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand deleteCmd = new SqlCommand(deleteIndividual, connection))
                {
                    deleteCmd.Parameters.Add("@iid", SqlDbType.Int);
                    deleteCmd.Parameters["@iid"].Value = individiualID;

                    int count = deleteCmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
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
                "SELECT p.pid, i.iid, fname, lname, streetAddress, dob, city, state, zip, phone, ssn " +
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
                            _individual.IndividualID = (int)reader["iid"];
                            _individual.FirstName = (string)reader["fname"];
                            _individual.LastName = (string)reader["lname"];
                            _individual.DateOfBirth = Convert.ToDateTime(reader["dob"]);
                            _individual.StreetAddress = (string)reader["streetAddress"];
                            _individual.City = (string)reader["city"];
                            _individual.State = (string)reader["state"];
                            _individual.ZipCode = reader["zip"].ToString();
                            _individual.PhoneNumber = (string)reader["phone"];
                            _individual.SSN = (string)reader["ssn"];
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
        public List<Individual> GetPatientsByFirstAndLastName(string fname, string lname)
        {
            List<Individual> _patients = new List<Individual>();
            string selectStatement =
                "SELECT p.pid, i.iid, fname, lname, streetAddress, dob, city, state, zip, phone, ssn " +
                "FROM Individual i INNER JOIN Patient p ON " +
                "i.iid = p.iid " +
                "WHERE fname = @FirstName " +
                "AND lname = @LastName";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@FirstName", fname);
                    selectCommand.Parameters.AddWithValue("@LastName", lname);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient _patient = new Patient();
                            Individual _individual = new Individual();
                            _patient.PatientID = (int)reader["pid"];
                            _individual.IndividualID = (int)reader["iid"];
                            _individual.FirstName = (string)reader["fname"];
                            _individual.LastName = (string)reader["lname"];
                            _individual.DateOfBirth = Convert.ToDateTime(reader["dob"]);
                            _individual.StreetAddress = (string)reader["streetAddress"];
                            _individual.City = (string)reader["city"];
                            _individual.State = (string)reader["state"];
                            _individual.ZipCode = reader["zip"].ToString();
                            _individual.PhoneNumber = (string)reader["phone"];
                            _individual.SSN = (string)reader["ssn"];
                            _patients.Add(_individual);
                        }
                    }
                }
            }
            return _patients;
        }

        /// <summary>
        /// Retrieves list of patients that have a last name and DOB equal to the last name and dob passed in
        /// </summary>
        /// <param name="lname">Last name of patient</param>
        /// <param name="dob">Date of birth of the patient</param>
        /// <returns>Returns list of patients that have a last name and DOB equal to the last name and dob passed in</returns>
        public List<Individual> GetPatientsByLastNameAndDOB(string lname, DateTime dob)
        {
            List<Individual> _patients = new List<Individual>();
            string selectStatement =
                "SELECT p.pid, i.iid, fname, lname, streetAddress, dob, city, state, zip, phone, ssn " +
                "FROM Individual i INNER JOIN Patient p ON " +
                "i.iid = p.iid " +
                "WHERE lname = @LastName " +
                "AND dob = @DOB";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@LastName", lname);
                    selectCommand.Parameters.AddWithValue("@DOB", dob);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient _patient = new Patient();
                            Individual _individual = new Individual();
                            _patient.PatientID = (int)reader["pid"];
                            _individual.IndividualID = (int)reader["iid"];
                            _individual.FirstName = (string)reader["fname"];
                            _individual.LastName = (string)reader["lname"];
                            _individual.DateOfBirth = Convert.ToDateTime(reader["dob"]);
                            _individual.StreetAddress = (string)reader["streetAddress"];
                            _individual.City = (string)reader["city"];
                            _individual.State = (string)reader["state"];
                            _individual.ZipCode = reader["zip"].ToString();
                            _individual.PhoneNumber = (string)reader["phone"];
                            _individual.SSN = (string)reader["ssn"];
                            _patients.Add(_individual);
                        }
                    }
                }
            }
            return _patients;
        }

        /// <summary>
        /// Update an individual patient for the given individual patient into the data source.
        /// </summary>
        /// <param name="oldPatient">given oldPatient to update an Individual</param>
        /// <param name="newPatient">given newPatient to update an Individual</param>
        /// <returns>True if individual is successfully updated</returns>
        public bool UpdatePatient(Individual oldPatient, Individual newPatient)
        {
            string updateStatement =
                 "UPDATE Individual " +
                 "SET lname = @NewLastName, " +
                 "fname = @NewFirstName, " +
                 "dob = @NewDOB, " +
                 "streetAddress = @NewAddress, " +
                 "city = @NewCity, " +
                 "state = @NewState, " +
                 "zip = @NewZip, " +
                 "phone = @NewPhone, " +
                 "ssn = @NewSSN " +
                 "WHERE lname = @OldLastName " +
                 "AND fname = @OldFirstName " +
                 "AND dob LIKE @OldDOB " +
                 "AND streetAddress = @OldAddress " +
                 "AND city = @OldCity " +
                 "AND state = @OldState " +
                 "AND zip = @OldZip " +
                 "AND phone = @OldPhone " +
                 "AND ssn = @OldSSN";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@NewLastName", newPatient.LastName);
                    updateCommand.Parameters.AddWithValue("@NewFirstName", newPatient.FirstName);
                    updateCommand.Parameters.AddWithValue("@NewDOB", newPatient.DateOfBirth);
                    updateCommand.Parameters.AddWithValue("@NewAddress", newPatient.StreetAddress);
                    updateCommand.Parameters.AddWithValue("@NewCity", newPatient.City);
                    updateCommand.Parameters.AddWithValue("@NewState", newPatient.State);
                    updateCommand.Parameters.AddWithValue("@NewZip", newPatient.ZipCode);
                    updateCommand.Parameters.AddWithValue("@NewPhone", newPatient.PhoneNumber);
                    updateCommand.Parameters.AddWithValue("@NewSSN", newPatient.SSN);

                    updateCommand.Parameters.AddWithValue("@OldLastName", oldPatient.LastName);
                    updateCommand.Parameters.AddWithValue("@OldFirstName", oldPatient.FirstName);

                    var escapedForlike = oldPatient.DateOfBirth.ToString("yyyy-MM-dd");
                    string searchTerm = string.Format("{0}%", escapedForlike);
                    updateCommand.Parameters.AddWithValue("@OldDOB", searchTerm);
                    updateCommand.Parameters.AddWithValue("@OldAddress", oldPatient.StreetAddress);
                    updateCommand.Parameters.AddWithValue("@OldCity", oldPatient.City);
                    updateCommand.Parameters.AddWithValue("@OldState", oldPatient.State);
                    updateCommand.Parameters.AddWithValue("@OldZip", oldPatient.ZipCode);
                    updateCommand.Parameters.AddWithValue("@OldPhone", oldPatient.PhoneNumber);
                    updateCommand.Parameters.AddWithValue("@OldSSN", oldPatient.SSN);

                    try
                    {
                        int count = updateCommand.ExecuteNonQuery();
                        if (count > 0)
                            return true;
                        else
                            return false;
                    }
                    catch(SqlException ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        public int GetPatientIDByIndividualID(int iid)
        {
            Patient _patient = new Patient();
            string selectStatement =
                "SELECT pid, iid " +
                 "FROM Patient " +
                 "WHERE iid = @iid";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@iid", SqlDbType.Int);
                    selectCommand.Parameters["@iid"].Value = iid;
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
            return _patient.PatientID;
        }
    }
}
