using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to control flow from the application to the DAL for appointments
    /// </summary>
    class AppointmentController
    {
        private AppointmentDAL appointmentDAL;

        /// <summary>
        /// Create a IncidentController object.
        /// </summary>
        public AppointmentController()
        {
            this.appointmentDAL = new AppointmentDAL();
        }

        /// <summary>
        /// Insert a new appointment for given Appointment.
        /// </summary>
        /// <returns>true if sucessful, else false</returns>
        public bool InsertNewAppointment(Appointment appt)
        {
            if (appt == null)
            {
                throw new ArgumentNullException("Appointment cannot be null");
            }
            return this.appointmentDAL.InsertNewAppointment(appt);
        }

        /// <summary>
        /// Update an existing appointment for given Appointment.
        /// </summary>
        /// <param name="newAppt">newAppt to update</param>
        /// <param name="oldAppt">oldAppt to compare if has changed</param>
        /// <returns>true if sucessful, else false</returns>
        public bool UpdateAppointmentt(Appointment oldAppt, Appointment newAppt)
        {
            if (oldAppt == null || newAppt == null)
            {
                throw new ArgumentNullException("Appointments cannot be null");
            }
            return this.appointmentDAL.UpdateAppointmentt(oldAppt, newAppt);
        }

        /// <summary>
        /// Getting row count from Appointment for given doctorID and apptDateTime.
        /// </summary>
        /// <param name="apptDateTime">apptDateTime</param>
        /// <param name="doctorID">doctorID</param>
        /// <returns>row count</returns>
        public int CheckAvailability(int doctorID, DateTime apptDateTime)
        {
            if (doctorID < 0 || apptDateTime == DateTime.MinValue)
            {
                throw new ArgumentNullException("doctorID cannot be a negative number or apptDateTime cannot be an DateTime.MinValue");
            }
            return this.appointmentDAL.CheckAvailability(doctorID, apptDateTime);
        }

        /// <summary>
        /// Getting list of Appointments for given patientID.
        /// </summary>
        /// <param name="patientID">patientID</param>
        /// <returns>list of Appointments</returns>
        public List<Appointment> GetAppointmentsByPID(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentNullException("patientID cannot be a negative number");
            }
            return this.appointmentDAL.GetAppointmentsByPID(patientID);
        }
    }
}
