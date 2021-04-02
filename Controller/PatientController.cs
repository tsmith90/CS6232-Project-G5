using ClinicSupport.DAL;
using ClinicSupport.Model;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to interact with the Patient table of the ClinicSupport DB
    /// </summary>
    class PatientController
    {
        private readonly PatientDAL patientDAL;

        /// <summary>
        /// 0 parameter constructor for the PatientController class
        /// </summary>
        public PatientController()
        {
            patientDAL = new PatientDAL();
        }

        /// <summary>
        /// Method to retrieve a patient from the PatientDAL
        /// </summary>
        /// <param name="patientID">ID of the patient to be returned</param>
        /// <returns>Returns the patient with the specified patientID</returns>
        public Patient GetPatientByID(int patientID)
        {
            Patient patient = patientDAL.GetPatientbyID(patientID);
            return patient;
        }
    }
}
