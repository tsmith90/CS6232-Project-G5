using ClinicSupport.DAL;
using ClinicSupport.Model;
using System.Collections.Generic;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to control flow from the application to the DAL for Doctors
    /// </summary>
    class DoctorController
    {
        private readonly DoctorDAL doctorDAL;

        /// <summary>
        /// 0 parameter constructor for the DoctorController class
        /// </summary>
        public DoctorController()
        {
            this.doctorDAL = new DoctorDAL();
        }

        /// <summary>
        /// Method that retrieves the list of doctors object from the DoctorDAL
        /// </summary>
        /// <returns>Returns the list of doctors object</returns>
        public List<Doctor> GetAllDoctors()
        {
            return this.doctorDAL.GetAllDoctors();
        }
    }
}
