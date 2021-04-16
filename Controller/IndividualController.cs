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
        /// 0 parameter constructor for the IndividualController class
        /// </summary>
        public IndividualController()
        {
            individualDAL = new IndividualDAL();
        }

        /// <summary>
        /// Method that retrieves the indivudal object from the IndividualDAL
        /// </summary>
        /// <param name="iid">NurseID of the individual to be returned</param>
        /// <returns>Returns the individual with the specified individualID</returns>
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
        /// Method that adds an individual object to the database via the IndividualDAL
        /// </summary>
        /// <param name="newIndividual">New Individual object to be added</param>
        /// <returns>Returns the new iid of the newly created individual</returns>
        public int InsertNewIndividual(Individual newIndividual)
        {
            if (newIndividual == null)
            {
                throw new ArgumentNullException("Please enter a valid individual");
            }

            int newIndividualID = individualDAL.AddIndividual(newIndividual);
            return newIndividualID;
        }

        public bool UpdateIndividual(Individual newIndividual)
        {
            if (newIndividual == null)
            {
                throw new ArgumentNullException("Please enter a valid individual");
            }

            return false;
        }
    }
}
