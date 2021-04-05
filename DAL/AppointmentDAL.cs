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
        /// Get all the Appointment objects from the data source.
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
        /// Get the Appointment object from the data source.
        /// </summary>
        /// <param name="pid">pid</param>
        /// <param name="apptTime">apptTime</param>
        /// <param name="did">did</param>
        /// <returns>the Appointment object</returns>
        public Appointment GetAppointmentByPid(int pid, int did, DateTime apptTime)
        {
            Appointment _appointment = new Appointment();
            string selectStatement =
                "SELECT pid, did, time " +
                 "FROM Appointment " +
                 "WHERE pid = @pid AND did = @did AND time = @apptTime";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@pid", SqlDbType.Int);
                    selectCommand.Parameters["@pid"].Value = pid;
                    selectCommand.Parameters.Add("@did", SqlDbType.Int);
                    selectCommand.Parameters["@did"].Value = did;
                    selectCommand.Parameters.Add("@apptTime", SqlDbType.DateTime);
                    selectCommand.Parameters["@apptTime"].Value = apptTime;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _appointment.PatientID = (int)reader["pid"];
                            _appointment.DoctorID = (int)reader["iid"];
                            _appointment.Time = (DateTime)reader["time"];
                        }
                    }
                }
            }
            return _appointment;
        }

        /// <summary>
        /// insert a new appointment for the given Appointment into the data source.
        /// </summary>
        /// <param name="appt">given appt to insert a new Appointment</param>
        public bool InsertNewAppointment(Appointment appt)
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
                    cmd.Parameters.Add("@docID", SqlDbType.Int).Value = appt.DoctorID;
                    cmd.Parameters.Add("@patientID", SqlDbType.VarChar, 10).Value = appt.PatientID;
                    cmd.Parameters.Add("@time", SqlDbType.VarChar, 50).Value = appt.Time;
                    cmd.Parameters.Add("@reason", SqlDbType.VarChar, 250).Value = appt.Reason;
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        /// <summary>
        /// Get row count if found availability for the given doctorID and apptTime from the data source.
        /// </summary>
        /// <param name="doctorID">given doctorID to query Appointment</param>
        /// <param name="apptDateTime">given apptDateTime to query Appointment</param>
        /// <returns>a row count of matching query</returns>
        public int CheckAvailability(int doctorID, DateTime apptDateTime)
        {
            int apptAvailable = 0;
            string selectStatement =
                 "SELECT COUNT(*) FROM Appointment " +
                 "WHERE ([did] = @docID and [time] = @apptTime)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@docID", SqlDbType.Int);
                    selectCommand.Parameters["@docID"].Value = doctorID;
                    selectCommand.Parameters.Add("@apptTime", SqlDbType.DateTime);
                    selectCommand.Parameters["@apptTime"].Value = apptDateTime;
                    apptAvailable = (int)selectCommand.ExecuteScalar();
                }
            }
            return apptAvailable;
        }

        /// <summary>
        /// update an Appointment for the given Appointment into the data source.
        /// </summary>
        /// <param name="oldAppointment">given oldAppointment to update a Appointment</param>
        /// <param name="newAppointment">given newAppointment to update a Appointment</param>
        /// <returns>true if appoint is successfully updated</returns>
        public bool UpdateAppointmentt(Appointment oldAppointment, Appointment newAppointment)
        {
            string updateStatement =
                 "UPDATE dbo.Appointment SET Time =  @newTime " +
                 "WHERE PatientID = @oldPatientID " +
                 "AND DoctorID = @oldDoctorID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@oldDoctorID", SqlDbType.Int).Value = oldAppointment.DoctorID;
                    cmd.Parameters.Add("@newPatientID", SqlDbType.Int).Value = newAppointment.PatientID;
                    cmd.Parameters.Add("@newTime", SqlDbType.VarChar).Value = newAppointment.Time;

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
                    // define parameters and their values
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
    }
}
