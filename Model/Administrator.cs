namespace ClinicSupport.Model
{
    /// <summary>
    /// Class to create and populate an Administrator object from the DB
    /// </summary>
    class Administrator
    {
        public int AdministratorID { get; set; }

        public string Privilege { get; set; }

        public string Username { get; set; }

        public int IndividualID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }
    }
}
