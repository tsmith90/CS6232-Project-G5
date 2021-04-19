using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Method to retrieve a patient from the PatientDAL
        /// </summary>
        /// <param name="fname">fname</param>
        /// <param name="lname">lname</param>
        /// <param name="dob">dob</param>
        /// <returns>Returns the patient with the specified patientID</returns>
        public Patient GetPatientbyNameAndDOB(string fname, string lname, DateTime dob)
        {
            if (fname == string.Empty || lname == string.Empty || dob == DateTime.MinValue)
            {
                throw new ArgumentNullException("fname, lname cannot be an empty string or dob cannot be an DateTime.MinValue");
            }
            return patientDAL.GetPatientbyNameAndDOB(fname, lname, dob);
        }

        /// <summary>
        /// Retrieves list of patients that have a DOB equal to the dob passed in
        /// </summary>
        /// <param name="dob">Date to search patients by</param>
        /// <returns>Returns list of individuals who are patients that have a DOB equal to the dob passed in</returns>
        public List<Individual> GetPatientsByDOB(DateTime dob)
        {
            if (dob == DateTime.MinValue || dob == null)
            {
                throw new ArgumentNullException("DOB cannot be null");
            }
            return patientDAL.GetPatientsByDOB(dob); ;
        }

        /// <summary>
        /// Retrieves list of patients that have a first and last name equal to the ones passed in
        /// </summary>
        /// <param name="fname">First name of patient</param>
        /// <param name="lname">Last name of patient</param>
        /// <returns>Returns list of patients that have a first and last name equal to the ones passed in</returns>
        public List<Individual> GetPatientsByFirstAndLastName(string fname, string lname)
        {
            if (fname == string.Empty || lname == string.Empty)
            {
                throw new ArgumentNullException("Please make sure that the first name and last name of the patient are present");
            }
            return patientDAL.GetPatientsByFirstAndLastName(fname, lname);
        }

        /// <summary>
        /// Retrieves list of patients that have a last name and DOB equal to the last name and dob passed in
        /// </summary>
        /// <param name="lname">Last name of patient</param>
        /// <param name="dob">Date of birth of the patient</param>
        /// <returns>Returns list of patients that have a last name and DOB equal to the last name and dob passed in</returns>
        public List<Individual> GetPatientsByLastNameAndDOB(string lname, DateTime dob)
        {
            if (lname == string.Empty || dob == null)
            {
                throw new ArgumentNullException("Please make sure that the last name and date of birth of the patient are present and accurate");
            }
            return patientDAL.GetPatientsByLastNameAndDOB(lname, dob);
        }

        /// <summary>
        /// Update an individual patient for the given individual patient into the data source.
        /// </summary>
        /// <param name="oldPatient">given oldPatient to update an Individual</param>
        /// <param name="newPatient">given newPatient to update an Individual</param>
        /// <returns>True if individual is successfully updated</returns>
        public bool UpdatePatient(Individual oldPatient, Individual newPatient)
        {
            if (oldPatient == null || newPatient == null)
            {
                throw new ArgumentNullException("Please make sure all information is entered");
            }
            return patientDAL.UpdatePatient(oldPatient, newPatient);
        }

        public int GetPatientIDByIndividualID(int iid)
        {
            return patientDAL.GetPatientIDByIndividualID(iid);
        }
    }
}
