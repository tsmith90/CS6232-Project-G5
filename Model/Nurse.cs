namespace ClinicSupport.Model
{
    /// <summary>
    /// Class to create and populate a Nurse object from the DB
    /// </summary>
    public class Nurse
    {
        public int NurseID { get; set; }

        public string Username { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int IndividualID { get; set; }

        public string Privilege { get; set; }
    }
}
