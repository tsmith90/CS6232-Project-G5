using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    class DBConnection
    {
        /// <summary>
        /// Method to establish a connection to the TechSupport DB
        /// </summary>
        /// <returns>The connection to the database</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog= cs6232-g5;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
