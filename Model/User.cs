namespace ClinicSupport.Model
{
    /// <summary>
    /// Class to create and populate a User object from the DB
    /// </summary>
    class User
    {
        public string Username { get; set; }

        public string Privileges { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
