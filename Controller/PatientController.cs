using ClinicSupport.DAL;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSupport.Controller
{
    class PatientController
    {
        private PatientDAL patientDAL;

        public PatientController()
        {
            patientDAL = new PatientDAL();
        }

        public Patient GetPatientByID(int patientID)
        {
            Patient patient = patientDAL.GetPatientbyID(patientID);
            return patient;
        }
    }
}
