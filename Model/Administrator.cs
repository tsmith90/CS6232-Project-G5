namespace ClinicSupport.Model
{
    /// <summary>
    /// Class to create and populate an Administrator object from the DB
    /// </summary>
    class Administrator
    {
        public int AdministratorID { get; set; }

        public string AdministratorUsername { get; set; }

        public int IndividualID { get; set; }
    }
}
