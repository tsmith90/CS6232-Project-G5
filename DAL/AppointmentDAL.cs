using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSupport.DAL
{
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
                "SELECT pid, did, time " +
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
    }
}
