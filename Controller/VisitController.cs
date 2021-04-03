using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;

namespace ClinicSupport.Controller
{
    class VisitController
    {
        private readonly VisitDAL visitDAL;

        public VisitController()
        {
            visitDAL = new VisitDAL();
        }

        public List<Visit> GetVisitsByID(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Please enter a valid ID.");
            }

            return visitDAL.GetVisitsByID(id);
        }
    }
}
