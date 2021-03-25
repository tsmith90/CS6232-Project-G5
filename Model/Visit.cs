using System;

namespace ClinicSupport.Model
{
    /// <summary>
    /// Class to create and populate a Visit object from the DB
    /// </summary>
    class Visit
    {
        public int PatientID { get; set; }

        public DateTime DateTime { get; set; }

        public int NurseID { get; set; }

        public decimal Weight { get; set; }

        public int Systolic { get; set; }

        public int Diastolic { get; set; }

        public decimal Temperature { get; set; }

        public int Pulse { get; set; }

        public string Symptoms { get; set; }

        public string InitialDiagnosis { get; set; }

        public string FinalDiagnosis { get; set; }
    }
}
