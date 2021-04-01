using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to establish a connection directly to the DB (cs6232-g5)
    /// </summary>
    class DBConnection
    {
        /// <summary>
        /// Method to establish a connection to the TechSupport DB
        /// </summary>
        /// <returns>The connection to the database</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=tphan-p1;Initial Catalog= cs6232-g5;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
