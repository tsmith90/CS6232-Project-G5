using System.Windows.Forms;
using ClinicSupport.Model;

namespace ClinicSupport.UserControls
{
    public partial class PatientInformationUserControl : UserControl
    {
        /// <summary>
        /// 0 parameter contructor
        /// </summary>
        public PatientInformationUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hides the Update button
        /// </summary>
        public void HideUpdateButton()
        {
            updateButton.Visible = false;
        }

        /// <summary>
        /// Hides the Create patient button
        /// </summary>
        public void HideNewButton()
        {
            createPatientButton.Visible = false;
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void SetPatient(Individual patient)
        {
            firstNameTextBox.Text = patient.FirstName;
            lastNameTextBox.Text = patient.LastName;
            dobTextBox.Text = patient.DateOfBirth.ToString();
            phoneTextBox.Text = patient.PhoneNumber.ToString();
            addressTextBox.Text = patient.StreetAddress;
            cityTextBox.Text = patient.City;
            stateComboBox.SelectedItem = patient.State;
            zipTextBox.Text = patient.ZipCode.ToString();
        }
    }
}
