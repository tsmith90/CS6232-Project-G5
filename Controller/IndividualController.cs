using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to interact with the Individual table of the ClinicSupport DB
    /// </summary>
    class IndividualController
    {
        private readonly IndividualDAL individualDAL;

        /// <summary>
        /// 0-parameter constructor for the IndividualController class
        /// </summary>
        public IndividualController()
        {
            individualDAL = new IndividualDAL();
        }

        /// <summary>
        /// Method that retrieves the indivudal object from the IndividualDAL
        /// </summary>
        /// <param name="iid">ID of the individual to be returned</param>
        /// <returns>Returns the individual with provided specified individualID</returns>
        public Individual GetIndividualByID(int iid)
        {
            if (iid < 0)
            {
                throw new Exception("Please enter a valid individual id");
            }

            Individual individual = individualDAL.GetIndividualbyID(iid);
            return individual;
        }

        /// <summary>
        /// Updates an Individual object in the DAL
        /// </summary>
        /// <param name="newIndividual">the individual to be updated</param>
        /// <returns>true if the DAL updates properly </returns>
        public bool UpdateIndividual(Individual newIndividual)
        {
            if (newIndividual == null)
            {
                throw new ArgumentNullException("Please enter a valid individual object");
            }

            return individualDAL.UpdateIndividual(newIndividual);
        }

        /// <summary>
        /// Calls to the individual DAL to see if the ssn passed in already exist
        /// </summary>
        /// <param name="ssn">SSN in question</param>
        /// <returns>Returns true if the number of rows returned in the DAL is greater than 0</returns>
        public bool IsDuplicateSSN(string ssn)
        {
            if (ssn.Length != 9)
            {
                throw new ArgumentException("Please enter a valid SSN. It must be 9 character long");
            }

            return individualDAL.IsDuplicateSSN(ssn);
        }
    }
}
