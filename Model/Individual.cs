using System;

namespace ClinicSupport.Model
{
    /// <summary>
    /// Class to create and populate an Individual object from the DB
    /// </summary>
    public class Individual
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; } 

        public int PhoneNumber { get; set; }
    }
}
