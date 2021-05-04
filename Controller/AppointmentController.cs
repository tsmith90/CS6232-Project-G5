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
        private readonly AppointmentDAL appointmentDAL;

        /// <summary>
        /// 0-parameter constructor for AppointmentController
        /// </summary>
        public AppointmentController()
        {
            this.appointmentDAL = new AppointmentDAL();
        }

        /// <summary>
        /// Inserts a new appointment using the DAL method
        /// </summary>
        /// <returns>true if sucessful, else false</returns>
        public bool InsertNewAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException("Appointment cannot be null");
            }
            return this.appointmentDAL.InsertNewAppointment(appointment);
        }

        /// <summary>
        /// Update an existing appointment using the DAL method
        /// </summary>
        /// <param name="newAppointment">newAppointment to update</param>
        /// <param name="oldAppointment">oldAppointment to compare if has changed</param>
        /// <returns>true if sucessful, else false</returns>
        public bool UpdateAppointment(Appointment oldAppointment, Appointment newAppointment)
        {
            if (oldAppointment == null || newAppointment == null)
            {
                throw new ArgumentNullException("Appointments cannot be null");
            }
            return this.appointmentDAL.UpdateAppointment(oldAppointment, newAppointment);
        }

        /// <summary>
        /// Deletes an existing appointment from given Appointment parameter
        /// </summary>
        /// <param name="appointment">the appointment to be deleted</param>
        /// <returns>true if sucessful, else false</returns>
        public bool DeleteAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException("Appointments cannot be null");
            }
            return this.appointmentDAL.DeleteAppointment(appointment);
        }

        /// <summary>
        /// Gets row count from Appointment for a given doctorID and appointmentDateTime
        /// </summary>
        /// <param name="appointmentDateTime">The appointment reference time and date</param>
        /// <param name="doctorID">the doctor's ID</param>
        /// <returns>row count</returns>
        public int CheckAvailability(int doctorID, DateTime appointmentDateTime)
        {
            if (doctorID < 0 || appointmentDateTime == DateTime.MinValue)
            {
                throw new ArgumentNullException("doctorID cannot be a negative number or appointmentDateTime cannot be an DateTime.MinValue");
            }
            return this.appointmentDAL.CheckAvailability(doctorID, appointmentDateTime);
        }

        /// <summary>
        /// Gets list of Appointments for a given patientID
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

        /// <summary>
        /// Gets Appointment from the DAL by pid, did, and time
        /// </summary>
        /// <param name="patientID">The patient's ID</param>
        /// <param name="doctorID">The doctor's ID</param>
        /// <param name="appointmentTime">The time for the given appointment</param>
        /// <returns>A specific Appointment</returns>
        public Appointment GetAppointmentByIDsAndTime(int patientID, int doctorID, DateTime appointmentTime)
        {
            if (patientID < 0 || doctorID < 0 || appointmentTime == DateTime.MinValue )
            {
                throw new ArgumentNullException("Please enter valid information to get an Appointment by ID");
            }
            return this.appointmentDAL.GetAppointmentByID(patientID, doctorID, appointmentTime);
        }
    }
}
