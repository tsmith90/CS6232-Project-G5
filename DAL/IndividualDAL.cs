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
        /// <param name="iid">the individual's id</param>
        /// <returns>the Individual object</returns>
        public Individual GetIndividualbyID(int iid)
        {
            Individual _individual = new Individual();
            string selectStatement =
                "SELECT fname, lname, streetAddress, city, state, zip, phone, dob, ssn " +
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
                            _individual.ZipCode = reader["zip"].ToString();
                            _individual.PhoneNumber = (string)reader["phone"];
                            _individual.DateOfBirth = Convert.ToDateTime(reader["dob"]);
                            _individual.SSN = reader["ssn"].ToString();
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

        /// <summary>
        /// Updates an Individual's information in the DB
        /// </summary>
        /// <param name="newIndividual">the individual to be updated</param>
        /// <returns>true if the DB successfully updates the individual</returns>
        public bool UpdateIndividual(Individual newIndividual)
        {
            string updateStatement = 
                "UPDATE dbo.Individual " +
                "SET lname = @lname, fname = @fname, dob = @dob, streetAddress = @address, " +
                "city = @city, state = @state, zip = @zip, phone = @phone, ssn = @ssn " +
                "WHERE iid = @iid;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.Add("@lname", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@lname"].Value = newIndividual.LastName;

                    cmd.Parameters.Add("@fname", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@fname"].Value = newIndividual.FirstName;

                    cmd.Parameters.Add("@dob", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@dob"].Value = newIndividual.DateOfBirth;

                    cmd.Parameters.Add("@address", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@address"].Value = newIndividual.StreetAddress;

                    cmd.Parameters.Add("@city", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@city"].Value = newIndividual.City;

                    cmd.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@state"].Value = newIndividual.State;

                    cmd.Parameters.Add("@zip", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@zip"].Value = newIndividual.ZipCode;

                    cmd.Parameters.Add("@phone", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@phone"].Value = newIndividual.PhoneNumber;

                    cmd.Parameters.Add("@ssn", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@ssn"].Value = newIndividual.SSN;

                    cmd.Parameters.Add("@iid", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@iid"].Value = newIndividual.IndividualID;

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
