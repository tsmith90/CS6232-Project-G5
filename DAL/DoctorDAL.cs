using ClinicSupport.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    class DoctorDAL
    {
        /// <summary>
        /// Get all the Doctor objects from the data source.
        /// </summary>
        /// <returns>a list of Doctor objects</returns>
        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> _doctors = new List<Doctor>();
            string selectStatement =
                "SELECT did, fname, lname " +
                 "FROM Doctor d " +
                 "INNER JOIN Individual i ON i.iid = d.did";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doc = new Doctor();
                            doc.DoctorID = (int)reader["did"];
                            doc.Name = reader["fname"].ToString() + ' ' + reader["lname"].ToString();
                            _doctors.Add(doc);
                        }
                    }
                }
            }
            return _doctors;
        }
    }
}
