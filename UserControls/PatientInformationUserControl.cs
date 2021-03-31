using System.Windows.Forms;
using ClinicSupport.Model;

namespace ClinicSupport.UserControls
{
    public partial class PatientInformationUserControl : UserControl
    {
        public PatientInformationUserControl()
        {
            InitializeComponent();
        }

        public void HideUpdateButton()
        {
            updateButton.Visible = false;
        }

        public void HideNewButton()
        {
            createPatientButton.Visible = false;
        }

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
