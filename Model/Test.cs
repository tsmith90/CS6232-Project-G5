
namespace ClinicSupport.Model
{
    /// <summary>
    /// Class that represents a Test that is to be ordered for a patient
    /// </summary>
    class Test
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
