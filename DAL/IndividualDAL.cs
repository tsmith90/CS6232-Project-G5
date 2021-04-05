using ClinicSupport.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact with the Individual table of the ClinicSupport DB
    /// </summary>
    class IndividualDAL
    {
        /// <summary>
        /// Get the Individual object from the data source.
        /// </summary>
        /// <param name="iid">iid</param>
        /// <returns>the Individual object</returns>
        public Individual GeIndividualbyID(int iid)
        {
            Individual _individual = new Individual();
            string selectStatement =
                "SELECT fname, lname, streetAddress, city, state, zip, phone, dob " +
                 "FROM Individual " +
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
                            _individual.FirstName = (string)reader["fname"];
                            _individual.LastName = (string)reader["lname"];
                            _individual.StreetAddress = (string)reader["streetAddress"];
                            _individual.City = (string)reader["city"];
                            _individual.State = (string)reader["state"];
                            _individual.ZipCode = (int)reader["zip"];
                            _individual.PhoneNumber = (string)reader["phone"];
                            _individual.DateOfBirth = Convert.ToDateTime(reader["dob"]);
                        }
                    }
                }
            }
            return _individual;
        }

        /// <summary>
        /// Adds passed in individual to the Individual table
        /// </summary>
        /// <param name="newIndividual">New indivisual to be added</param>
        /// <returns>Returns the new individualID for the individual that was just created</returns>
        public int AddIndividual(Individual newIndividual)
        {
            string insertStatement =
                "INSERT INTO Individual (lname, fname, dob, streetAddress, city, state, zip, phone) " +
                "VALUES (@LastName, @FirstName, @DOB, @Address, @City, @State, @Zip, @Phone);";

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

                    insertCommand.ExecuteNonQuery();
                }

                string selectStatement = "SELECT IDENT_CURRENT('Individual') FROM Individual;";
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    int indivdualID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return indivdualID;
                }
            }
        }
    }
}
