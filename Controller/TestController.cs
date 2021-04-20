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
    /// Class to interact with the TestDAL
    /// </summary>
    class TestController
    {
        private readonly TestDAL testDAL;

        /// <summary>
        /// 0 parameter constructor for the TestController class
        /// </summary>
        public TestController()
        {
            testDAL = new TestDAL();
        }

        /// <summary>
        /// Method to retrieve a list of Test objects from the TestDAL
        /// </summary>
        /// <returns>Returns a list of Test objects</returns>
        public List<Test> GetTests()
        {
            return testDAL.GetTests();
        }
    }
}
