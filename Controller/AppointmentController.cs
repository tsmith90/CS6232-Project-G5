using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;

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
        /// Getting row count from registration for given customerID and productCode.
        /// </summary>
        /// <returns>row count</returns>
        public bool InsertNewAppointment(Appointment appt)
        {
            if (appt == null)
            {
                throw new ArgumentNullException("Appointment cannot be null");
            }
            return this.appointmentDAL.InsertNewAppointment(appt);
        }

        /// <summary>
        /// Getting row count from registration for given customerID and productCode.
        /// </summary>
        /// <returns>row count</returns>
        public int CheckAvailability(int doctorID, DateTime apptDateTime)
        {
            if (doctorID < 0 || apptDateTime == DateTime.MinValue)
            {
                throw new ArgumentNullException("doctorID cannot be a negative number or apptDateTime cannot be an DateTime.MinValue");
            }
            return this.appointmentDAL.CheckAvailability(doctorID, apptDateTime);
        }

    }
}
