using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to interact with the Administrator table of the ClinicSupport DB
    /// </summary>
    class AdministratorController
    {
        private readonly AdministratorDAL administratorDAL;

        public AdministratorController()
        {
            administratorDAL = new AdministratorDAL();
        }

        /// <summary>
        /// Method to get the Administrator information from DAL
        /// </summary>
        /// <param name = "username">the Nurse's username</param> 
        /// <returns>A new Administrator object</returns>
        public Administrator GetAdminByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException("Please enter valid credentials");
            }

            return administratorDAL.GetAdminByUsername(username);
        }
    }
}
