using ClinicSupport.Model;
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
    }
}
