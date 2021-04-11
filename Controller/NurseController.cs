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
        /// <param name = "username">the Nurse username</param> 
        /// <returns>A new Nurse object</returns>
        public Nurse GetNurseByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException("Please enter valid credentials");
            }

            return nurseDAL.GetNurseByUsername(username);
        }

        /// <summary>
        /// Method to update the Nurse information in the DAL
        /// </summary>
        /// <param name = "nurse">the Nurse object to be passed to the DAL</param> 
        /// <returns>true if Nurse is updated successfully in the DAL</returns>
        public bool UpdateNurse(Nurse nurse)
        {
            if (nurse == null)
            {
                throw new ArgumentNullException("Please enter a valid nurse object");
            }

            return nurseDAL.UpdateNurse(nurse);
        }
    }
}
