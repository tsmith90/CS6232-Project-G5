using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
    /// <summary>
    /// Class to interact with the DB to retrieve and manipulate appointments
    /// </summary>
    class AppointmentDAL
    {
        /// <summary>
        /// Gets all the Appointment objects from the DB
        /// </summary>
        /// <returns>a list of Appointment objects</returns>
        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> _appointments = new List<Appointment>();
            string selectStatement =
                "SELECT pid, did, time, reason " +
                 "FROM Appointment";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.PatientID = (int)reader["pid"];
                            appointment.DoctorID = (int)reader["did"];
                            appointment.Time = (DateTime)reader["time"];
                            appointment.Reason = reader["reason"].ToString();
                            _appointments.Add(appointment);
                        }
                    }
                }
            }
            return _appointments;
        }

        /// <summary>
        /// Gets a specific Appointment object from the DB
        /// </summary>
        /// <param name="pid">the patient's id</param>
        /// <param name="did">the doctor's id</param>
        /// <param name="appointmentTime">the appointment time and date</param>
        /// <returns>the Appointment object</returns>
        public Appointment GetAppointmentByID(int pid, int did, DateTime appointmentTime)
        {
            Appointment _appointment = new Appointment();
            string selectStatement =
                "SELECT pid, did, time, reason " +
                 "FROM Appointment " +
                 "WHERE pid = @pid AND did = @did AND time = @appointmentTime";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@pid", SqlDbType.Int);
                    selectCommand.Parameters["@pid"].Value = pid;
                    selectCommand.Parameters.Add("@did", SqlDbType.Int);
                    selectCommand.Parameters["@did"].Value = did;
                    selectCommand.Parameters.Add("@appointmentTime", SqlDbType.DateTime);
                    selectCommand.Parameters["@appointmentTime"].Value = appointmentTime;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _appointment.PatientID = (int)reader["pid"];
                            _appointment.DoctorID = (int)reader["did"];
                            _appointment.Time = (DateTime)reader["time"];
                            _appointment.Reason = reader["reason"].ToString();
                        }
                    }
                }
            }
            return _appointment;
        }

        /// <summary>
        /// Inserts a new appointment for the given Appointment into the DB
        /// </summary>
        /// <param name="appointment">given appointment to insert a into the DB</param>
        public bool InsertNewAppointment(Appointment appointment)
        {
            string insertStatement =
                 "INSERT INTO dbo.Appointment (did, pid, time, reason) " +
                 "VALUES (@docID, @patientID, @time, @reason)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@docID", SqlDbType.Int).Value = appointment.DoctorID;
                    cmd.Parameters.Add("@patientID", SqlDbType.Int).Value = appointment.PatientID;
                    cmd.Parameters.Add("@time", SqlDbType.DateTime).Value = appointment.Time;
                    cmd.Parameters.Add("@reason", SqlDbType.VarChar, 255).Value = appointment.Reason;
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        /// <summary>
        /// Gets count if found availability for the given doctorID and appointmentTime from the data source.
        /// </summary>
        /// <param name="doctorID">given doctorID to query Appointment</param>
        /// <param name="appointmentDateTime">given appointmentDateTime to query Appointment</param>
        /// <returns>a row count of matching query</returns>
        public int CheckAvailability(int doctorID, DateTime appointmentDateTime)
        {
            int available = 0;
            string selectStatement =
                 "SELECT COUNT(*) FROM Appointment " +
                 "WHERE ([did] = @docID and [time] = @appointmentTime)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@docID", SqlDbType.Int);
                    selectCommand.Parameters["@docID"].Value = doctorID;
                    selectCommand.Parameters.Add("@appointmentTime", SqlDbType.DateTime);
                    selectCommand.Parameters["@appointmentTime"].Value = appointmentDateTime;
                    available = (int)selectCommand.ExecuteScalar();
                }
            }

            return available;
        }

        /// <summary>
        /// update an Appointment for the given Appointment into the data source.
        /// </summary>
        /// <param name="oldAppointment">given oldAppointment to update a Appointment</param>
        /// <param name="newAppointment">given newAppointment to update a Appointment</param>
        /// <returns>true if appoint is successfully updated</returns>
        public bool UpdateAppointment(Appointment oldAppointment, Appointment newAppointment)
        {
            string updateStatement =
                 "UPDATE dbo.Appointment SET Time =  @newTime, Reason = @newReason " +
                 "WHERE pid = @oldPatientID " +
                 "AND did = @oldDoctorID " +
                 "AND time = @oldTime";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.Add("@oldDoctorID", SqlDbType.Int).Value = oldAppointment.DoctorID;
                    cmd.Parameters.Add("@oldPatientID", SqlDbType.Int).Value = oldAppointment.PatientID;
                    cmd.Parameters.Add("@oldTime", SqlDbType.DateTime).Value = oldAppointment.Time;
                    cmd.Parameters.AddWithValue("@newTime", SqlDbType.DateTime).Value = newAppointment.Time;
                    cmd.Parameters.Add("@newReason", SqlDbType.VarChar).Value = newAppointment.Reason;

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        /// <summary>
        /// Get all the Appointment objects from the data source for the given patientID.
        /// </summary>
        /// <param name="patientID">Given patientID</param>
        /// <returns>a list of Appointment objects</returns>
        public List<Appointment> GetAppointmentsByPID(int patientID)
        {
            List<Appointment> _appointments = new List<Appointment>();
            string selectStatement =
                "SELECT pid, did, time, reason " +
                 "FROM Appointment " +
                 "WHERE pid = @patientID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@patientID", SqlDbType.Int);
                    selectCommand.Parameters["@patientID"].Value = patientID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.PatientID = (int)reader["pid"];
                            appointment.DoctorID = (int)reader["did"];
                            appointment.Time = (DateTime)reader["time"];
                            appointment.Reason = reader["reason"].ToString();
                            _appointments.Add(appointment);
                        }
                    }
                }
            }
            return _appointments;
        }

        /// <summary>
        /// Delete an appointment an appointment if there is no visit associated with it in the data source.
        /// </summary>
        /// <param name="appointment">given appointment to insert a new Appointment</param>
        public bool DeleteAppointment(Appointment appointment)
        {
            string deleteStatement =
            "DELETE FROM dbo.Appointment " +
            "WHERE pid = @patientID AND time = @time AND did = @docID AND " +
            "NOT EXISTS(SELECT * FROM dbo.Visit v " +
            "WHERE v.pid = @patientID and v.time = @time)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(deleteStatement, connection))
                {
                    cmd.Parameters.Add("@docID", SqlDbType.Int).Value = appointment.DoctorID;
                    cmd.Parameters.Add("@patientID", SqlDbType.Int).Value = appointment.PatientID;
                    cmd.Parameters.Add("@time", SqlDbType.DateTime).Value = appointment.Time;
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
