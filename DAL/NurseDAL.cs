using ClinicSupport.Model;
using System;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact with the Nurse table of the ClinicSupport DB
    /// </summary>
    class NurseDAL
    {
        /// <summary>
        /// Method to get the Nurse information from CS6232-g5 DB
        /// </summary>
        /// <param name = "username">the Nurse's username</param> 
        /// <returns>A new Nurse object</returns>
        public Nurse GetNurseByUsername(string username)
        {
            Nurse nurse = new Nurse();

            string selectStatement = 
                "SELECT n.nid, n.username, n.iid, l.privilege, i.lname as last, i.fname as first " +
                "FROM Nurse n join Login l on l.username = n.username " +
                "join Individual i on n.iid = i.iid " +
                "WHERE n.username = @username;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@username"].Value = username;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nurse.NurseID = (int)reader["nid"];
                            nurse.Username = reader["username"].ToString();
                            nurse.IndividualID = (int)reader["iid"];
                            nurse.Privilege = reader["privilege"].ToString();
                            nurse.LastName = reader["last"].ToString();
                            nurse.FirstName = reader["first"].ToString();
                        }
                    }
                }
            }

            return nurse;
        }

        /// <summary>
        /// Method to update the Nurse information in the DB
        /// </summary>
        /// <param name = "nurse">the Nurse object to be passed from the controller</param> 
        /// <returns>true if Nurse is updated successfully in the DB</returns>
        public bool UpdateNursePrivileges(Nurse nurse)
        {
            string updateStatement = "UPDATE Login " +
                "SET privilege = @privilege " + 
                "WHERE username = @username;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.Add("@privilege", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@privilege"].Value = nurse.Privilege;

                    cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@username"].Value = nurse.Username;

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }


        /// <summary>
        /// Method to add a Nurse in the DB
        /// </summary>
        /// <param name = "individual">the Individual object to be passed to the DB</param> 
        /// <param name = "user">the username to be passed to the DB</param> 
        /// <param name = "password">the password to be passed to the DB</param> 
        /// <returns>true if Nurse is added successfully in the DB</returns>
        public bool AddNurse(Individual individual, string user, string password)
        {
            int counter = 0;
            int nurseID;
            int inserted;

            string selectStatement = "SELECT count(username)as counter FROM Login WHERE username = @username;";

            string selectNurseStatement = "SELECT IDENT_CURRENT('Individual') FROM Individual;";

            string insertIndividual =
                "INSERT INTO Individual (lname, fname, dob, streetAddress, city, state, zip, phone, ssn) " +
                "VALUES (@LastName, @FirstName, @DOB, @Address, @City, @State, @Zip, @Phone, @SSN);";

            string insertNurse = "Insert into Nurse (username, iid) " +
                "Values (@username, @iid);";

            string insertLogin = 
                "INSERT INTO Login (username, password, privilege) " +
                "VALUES (@username, @password, @privilege)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@username"].Value = user;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            counter = (int)reader["counter"];
                        }
                    }

                    if(counter > 0)
                    {
                        throw new Exception("That username is taken");
                    }
                    else
                    {
                        using (SqlCommand insertCommand = new SqlCommand(insertIndividual, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@LastName", individual.LastName);
                            insertCommand.Parameters.AddWithValue("@FirstName", individual.FirstName);
                            insertCommand.Parameters.AddWithValue("@DOB", individual.DateOfBirth);
                            insertCommand.Parameters.AddWithValue("@Address", individual.StreetAddress);
                            insertCommand.Parameters.AddWithValue("@City", individual.City);
                            insertCommand.Parameters.AddWithValue("@State", individual.State);
                            insertCommand.Parameters.AddWithValue("@Zip", individual.ZipCode);
                            insertCommand.Parameters.AddWithValue("@Phone", individual.PhoneNumber);
                            insertCommand.Parameters.AddWithValue("@SSN", individual.SSN);

                            inserted = insertCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand nurseCMD = new SqlCommand(selectNurseStatement, connection))
                        {
                            nurseID = Convert.ToInt32(nurseCMD.ExecuteScalar());
                        }

                        if (inserted > 0)
                        {
                            using (SqlCommand cmd = new SqlCommand(insertLogin, connection))
                            {
                                cmd.Parameters.AddWithValue("@username", user);
                                cmd.Parameters.AddWithValue("@password", password);
                                cmd.Parameters.AddWithValue("@privilege", "Nurse");

                                inserted += cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            return false;
                        }

                        if (inserted > 1)
                        {
                            using (SqlCommand cmd = new SqlCommand(insertNurse, connection))
                            {
                                cmd.Parameters.AddWithValue("@username", user);
                                cmd.Parameters.AddWithValue("@iid", nurseID);

                                inserted += cmd.ExecuteNonQuery();
                            }
                        }

                        if (inserted > 2)
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception("Information failed to be entered into all tables.");
                        }
                    }
                }
            }
        }
    }
}
