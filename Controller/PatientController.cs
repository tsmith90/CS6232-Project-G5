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
        /// <param name="patientID">NurseID of the patient to be returned</param>
        /// <returns>Returns the patient with the specified patientID</returns>
        public Patient GetPatientByID(int patientID)
        {
            Patient patient = patientDAL.GetPatientbyID(patientID);
            return patient;
        }

        /// <summary>
        /// Adds passed in individualID to the Patient table
        /// </summary>
        /// <param name="individualID">ID of individual recently added to Individual table and to be added to the Patient table</param>
        /// <returns>Returns the new patientID for the patient that was just created</returns>
        public int InsertNewPatient(int individualID)
        {
            int patientID = patientDAL.AddPatient(individualID);
            return patientID;
        }
    }
}
