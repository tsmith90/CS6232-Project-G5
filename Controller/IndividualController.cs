using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSupport.Controller
{
    class IndividualController
    {
        private IndividualDAL individualDAL;

        public IndividualController()
        {
            individualDAL = new IndividualDAL();
        }

        public Individual GetIndividualByID(int iid)
        {
            Individual individual = individualDAL.GeIndividualbyID(iid);
            return individual;
        }
    }
}
