using System.Windows.Forms;
using ClinicSupport.Controller;
using ClinicSupport.Model;

namespace ClinicSupport.View
{
    /// <summary>
    /// This form is intended to be the way for the user to either create a new patient or edit an existing patient,
    /// depending on which button is selected (if its even possible)
    /// </summary>
    public partial class NewOrEditPatientInformation : Form
    {
        private PatientController patientController;
        private IndividualController individualController;
        public NewOrEditPatientInformation()
        {
            InitializeComponent();
            patientInformationUserControl1.HideUpdateButton();
        }

        public NewOrEditPatientInformation(int patientID)
        {
            patientController = new PatientController();
            individualController = new IndividualController();
            patientInformationUserControl1.HideNewButton();
            Patient patient = patientController.GetPatientByID(patientID);
            Individual indivdualPatient = individualController.GetIndividualByID(patient.IndividualID);
            patientInformationUserControl1.SetPatient(patient);
        }
    }
}
