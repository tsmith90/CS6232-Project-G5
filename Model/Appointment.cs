using System;

namespace ClinicSupport.Model
{
    /// <summary>
    /// Class to create and populate an Appointment object from the DB
    /// </summary>
    class Appointment
    {
        public int PatientID { get; set; }

        public DateTime Time { get; set; }

        public int DoctorID { get; set; }

        public string Reason { get; set; }
    }
}
