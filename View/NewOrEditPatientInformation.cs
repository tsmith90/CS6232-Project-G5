using System.Windows.Forms;
using ClinicSupport.Controller;
using ClinicSupport.Model;

namespace ClinicSupport.View
{
    /// <summary>
    /// This form is intended to be the way for the user to either create a new patient or edit an existing patient,
    /// depending on which button is selected
    /// </summary>
    public partial class NewOrEditPatientInformation : Form
    {
        private PatientController patientController;
        private IndividualController individualController;

        /// <summary>
        /// 0 parameter constructor that is used for a new patient
        /// </summary>
        public NewOrEditPatientInformation()
        {
            InitializeComponent();
            patientInformationUserControl1.HideUpdateButton();
            this.Text = "New Patient";
        }

        /// <summary>
        /// 1 parameter contructor that is used for editing an existing patient
        /// </summary>
        /// <param name="patientID">Id of the patient to be edited</param>
        public NewOrEditPatientInformation(int patientID)
        {
            patientController = new PatientController();
            individualController = new IndividualController();
            patientInformationUserControl1.HideNewButton();
            this.Text = "Edit Paitent Information";
            Patient patient = patientController.GetPatientByID(patientID);
            Individual indivdualPatient = individualController.GetIndividualByID(patient.IndividualID);
            patientInformationUserControl1.SetPatient(indivdualPatient);
        }
    }
}
