using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;

namespace ClinicSupport.Controller
{
    class LabTestController
    {
        private readonly LabTestsDAL labTestDAL;

        /// <summary>
        /// Create a IncidentController object.
        /// </summary>
        public LabTestController()
        {
            this.labTestDAL = new LabTestsDAL();
        }

        /// <summary>
        /// Getting list of LabTests for given patientID.
        /// </summary>
        /// <param name="patientID">patientID</param>
        /// <returns>list of Appointments</returns>
        public List<LabTests> GetLabTestsByPatientID(int patientID, DateTime appTime)
        {
            if (patientID < 0)
            {
                throw new ArgumentNullException("patientID cannot be a negative number");
            }
            return this.labTestDAL.GetLabTestsByPatientID(patientID, appTime);
        }

        /// <summary>
        /// Adds LabTest to the database via the LabTestDAL
        /// </summary>
        /// <param name="newLabTest">Lab Test to be added</param>
        /// <returns>Returns if addition was successful</returns>
        public Boolean AddLabTest(LabTests newLabTest)
        {
            if (newLabTest.PatientID == 0 || newLabTest.AppointmentDate == null || newLabTest.Code == 0)
            {
                throw new ArgumentNullException("Not all of the required data is set for the Lab Test to be added");
            }
            return this.labTestDAL.AddLabTest(newLabTest);
        }
    }
}
