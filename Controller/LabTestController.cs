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

    }
}
