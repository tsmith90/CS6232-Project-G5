using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to interact with the LabTestDAL
    /// </summary>
    class LabTestController
    {
        private readonly LabTestsDAL labTestDAL;

        /// <summary>
        /// 0-parameter constructor for LabTestController
        /// </summary>
        public LabTestController()
        {
            this.labTestDAL = new LabTestsDAL();
        }

        /// <summary>
        /// Gets list of LabTests for a given patientID and appointment time
        /// </summary>
        /// <param name="patientID">The patient's ID</param>
        /// <param name="appointmentTime">The time and date of the appointment</param>
        /// <returns>A list of Appointments</returns>
        public List<LabTests> GetLabTestsByPatientIDAndAppt(int patientID, DateTime appointmentTime)
        {
            if (patientID < 0 || appointmentTime == DateTime.MinValue)
            {
                throw new ArgumentNullException("patientID cannot be a negative number or Appointment cannot be null");
            }

            return this.labTestDAL.GetLabTestsByPatientIDAndAppt(patientID, appointmentTime);
        }

        /// <summary>
        /// Gets list of LabTests for given patientID, code, and appointment time
        /// </summary>
        /// <param name="patientID">The patient's ID</param>
        /// <param name="code">The code of the lab test</param>
        /// <param name="appointmentTime">The time and date of the appointment</param>
        /// <returns>list of LabTests</returns>
        public LabTests GetLabTestsByPidCodeApptTime(int patientID, int code, DateTime appointmentTime)
        {
            if (patientID < 0 || appointmentTime == DateTime.MinValue || code < 0)
            {
                throw new ArgumentNullException("patientID cannot be a negative number or Appointment cannot be null");
            }

            return this.labTestDAL.GetLabTestsByPidCodeApptTime(patientID, code, appointmentTime);
        }

        /// <summary>
        /// Getting list of LabTests for given patientID.
        /// </summary>
        /// <param name="patientID">patientID</param>
        /// <returns>list of LabTests</returns>
        public List<LabTests> GetLabTestsByPatientID(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentNullException("patientID cannot be a negative number");
            }

            return this.labTestDAL.GetLabTestsByPatientID(patientID);
        }


        /// <summary>
        /// Adds LabTest to the database via the LabTestDAL
        /// </summary>
        /// <param name="newLabTest">Lab Test to be added</param>
        /// <returns>returns true if addition was successful</returns>
        public bool AddLabTest(LabTests newLabTest)
        {
            if (newLabTest.PatientID == 0 || newLabTest.AppointmentDate == DateTime.MinValue || newLabTest.Code == 0)
            {
                throw new ArgumentNullException("Not all of the required data is set for the Lab Test to be added");
            }

            return this.labTestDAL.AddLabTest(newLabTest);
        }

        /// <summary>
        /// Adds LabTest to the database via the LabTestDAL
        /// </summary>
        /// <param name="oldLabTest">Lab Test to be added</param>
        /// <returns>returns true if addition was successful</returns>
        public bool UpdateLabTest(LabTests labTest, LabTests oldLabTest)
        {
            if (labTest == null || oldLabTest == null)
            {
                throw new ArgumentNullException("Not all of the required data is set for the Lab Test to be added");
            }
            return this.labTestDAL.UpdateLabTest(labTest, oldLabTest);
        }
    }
}
