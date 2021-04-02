using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to control flow from the application to the DAL for Nurses
    /// </summary>
    class NurseController
    {
        private readonly NurseDAL nurseDAL;

        /// <summary>
        /// 0-parameter constructor for the NurseController class
        /// </summary>
        public NurseController()
        {
            nurseDAL = new NurseDAL();
        }

        /// <summary>
        /// Method to get the Nurse information from CS6232-g5 DB
        /// </summary>
        /// <param username = "username">the nurse username</param> 
        /// <returns>A new Nurse object</returns>
        public Nurse GetNurseByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException("Please enter valid credentials");
            }

            return nurseDAL.GetNurseByUsername(username);
        }
    }
}
