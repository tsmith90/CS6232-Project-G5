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
        private readonly LoginController loginController;

        /// <summary>
        /// 0-parameter constructor for the NurseController class
        /// </summary>
        public NurseController()
        {
            nurseDAL = new NurseDAL();
            loginController = new LoginController();
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

            return nurseDAL.UpdateNursePrivileges(nurse);
        }

        /// <summary>
        /// Method to add a Nurse in the DAL
        /// </summary>
        /// <param name = "individual">the Individual object to be passed to the DAL</param> 
        /// <param name = "user">the username to be passed to the DAL</param> 
        /// <param name = "password">the password to be hashed then passed to the DAL</param>
        /// <returns>true if Nurse is added successfully in the DAL</returns>
        public bool AddNurse(Individual individual, string user, string password)
        {
            if (individual == null || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                throw new Exception("please enter valid parameters to AddNurse");
            }

            try
            {
                string hashedPassword = loginController.HashPassword(user, password);
                return nurseDAL.AddNurse(individual, user, hashedPassword);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
