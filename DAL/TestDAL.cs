using ClinicSupport.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact with DB Test table
    /// </summary>
    class TestDAL
    {
        /// <summary>
        /// Gets all of the Test objects from the database
        /// </summary>
        /// <returns>Returns a list of test objects</returns>
        public List<Test> GetTests()
        {
            List<Test> _tests = new List<Test>();
            string selectStatement = "SELECT code, name, description FROM Test";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Test test = new Test();
                            test.Code = (int)reader["code"];
                            test.Name = (string)reader["name"];
                            test.Description = (string)reader["description"];
                            _tests.Add(test);
                        }
                    }
                }
            }
            return _tests;
        }
    }
}
