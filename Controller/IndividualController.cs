using ClinicSupport.DAL;
using ClinicSupport.Model;

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
        /// <param name="iid">ID of the individual to be returned</param>
        /// <returns>Returns the individual with the specified individualID</returns>
        public Individual GetIndividualByID(int iid)
        {
            Individual individual = individualDAL.GeIndividualbyID(iid);
            return individual;
        }
    }
}
