using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to control and mainpulate data from the DAL to the application for visit information
    /// </summary>
    class VisitController
    {
        private readonly VisitDAL visitDAL;

        /// <summary>
        /// 0-parameter constructor for the VisitController class
        /// </summary>
        public VisitController()
        {
            visitDAL = new VisitDAL();
        }

        /// <summary>
        /// Method to get visit information from the DAL by patient ID
        /// </summary>
        /// <param name="id">int id for the patient ID</param>
        /// <returns>List containing all visits made by a given patient</returns>
        public List<Visit> GetVisitsByID(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Please enter a valid ID.");
            }

            return visitDAL.GetVisitsByID(id);
        }

        /// <summary>
        /// Method to get visit information from the DAL by patient ID and datetime
        /// </summary>
        /// <param name="time">the datetime of the appointment</param> 
        /// <param name="pID">the patient ID</param>
        /// <returns>a visit object</returns>
        public Visit GetVisitByKeys(DateTime time, int pID)
        {
            if (time == null || pID < 0)
            {
                throw new ArgumentOutOfRangeException("Please enter a valid paramers for keys.");
            }
            
            return visitDAL.GetVisitByKeys(time, pID);
        }
    }
}
