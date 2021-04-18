using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class DeletePatientUserControl : UserControl
    {
        private readonly PatientController patientController;
        private int id;

        public DeletePatientUserControl()
        {
            InitializeComponent();
            patientController = new PatientController();
            SetControls();
        }

        private void SetControls()
        {
            firstNameTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            cityTextBox.ReadOnly = true;
            stateComboBox.Enabled = false;
            zipTextBox.ReadOnly = true;
            dateOfBirthTimePicker.Enabled = false;
            ssnTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
        }

        private void TextBox_Changed(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.DataSource = null;
            zipTextBox.Text = "";
            dateOfBirthTimePicker.Value = DateTime.Now;
            ssnTextBox.Text = "";
            phoneTextBox.Text = "";
        }

        private void FindPatientButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            try
            {
                id = Int32.Parse(findPatientTextbox.Text);
                Individual individual = patientController.GetPatientInformation(id);

                firstNameTextBox.Text = individual.FirstName;
            }
            catch (FormatException)
            {
                errorLabel.Text = "Please enter a valid Patient ID";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }
    }
}
