using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form to view patient information
    /// </summary>
    public partial class ViewPatientInformationForm : Form
    {
        /// <summary>
        /// 0-parameter constructor for ViewPatientInformationForm
        /// </summary>
        public ViewPatientInformationForm()
        {
            InitializeComponent();
            patientInformationUserControl1.HideNewButton();
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void SetPatient(Individual patient)
        {
            patientInformationUserControl1.SetPatient(patient);
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void PutIndividualData(Individual patient)
        {
            patientInformationUserControl1.PutIndividualData(patient);
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void SetIndividualData()
        {
            patientInformationUserControl1.SetIndividualData();
        }
    }
}
