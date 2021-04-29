using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl for nurses to delete patients who don't have appointments
    /// </summary>
    public partial class DeletePatientUserControl : UserControl
    {
        private readonly PatientController patientController;
        private readonly States statesList;
        private int pid;

        /// <summary>
        /// 0-parameter constructor for DeletePatientUserControl
        /// </summary>
        public DeletePatientUserControl()
        {
            InitializeComponent();
            patientController = new PatientController();
            statesList = new States();
            SetControls();
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void SetPatient(int patinentID)
        {
            if (patinentID > 0)
            {
                this.pid = patinentID;
                this.FillPatientInfo(patinentID);
            }
        }
        private void SetControls()
        {
            firstNameTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            cityTextBox.ReadOnly = true;
            stateTextbox.ReadOnly = true;
            zipTextBox.ReadOnly = true;
            dateTextBox.ReadOnly = true;
            ssnTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            deletePatientButton.Enabled = false;
        }

        private void TextBox_Changed(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        /// <summary>
        /// Method to Clear all controls in the usercontrol
        /// </summary>
        public void ClearControls()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            stateTextbox.Text = "";
            zipTextBox.Text = "";
            dateTextBox.Text = "";
            ssnTextBox.Text = "";
            phoneTextBox.Text = "";
            deletePatientButton.Enabled = false;
        }
        private void FillPatientInfo(int patinentID)
        {
            if (patinentID > 0)
            {
                try
                {
                    Individual individual = patientController.GetPatientInformation(patinentID);
                    firstNameTextBox.Text = individual.FirstName;
                    lastNameTextBox.Text = individual.LastName;
                    addressTextBox.Text = individual.StreetAddress;
                    cityTextBox.Text = individual.City;
                    stateTextbox.Text = statesList.SetStates().FirstOrDefault(x => x.Value == individual.State).Key;
                    zipTextBox.Text = individual.ZipCode;
                    ssnTextBox.Text = individual.SSN;
                    phoneTextBox.Text = individual.PhoneNumber;
                    if (individual.DateOfBirth.CompareTo(DateTime.MinValue) > 0)
                    {
                        dateTextBox.Text = individual.DateOfBirth.ToShortDateString();
                        deletePatientButton.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
        }

        private void FindPatientButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            try
            {
                //id = Int32.Parse(findPatientTextbox.Text);
                //Individual individual = patientController.GetPatientInformation(id);

                //firstNameTextBox.Text = individual.FirstName;
                //lastNameTextBox.Text = individual.LastName;
                //addressTextBox.Text = individual.StreetAddress;
                //cityTextBox.Text = individual.City;
                //stateTextbox.Text = statesList.SetStates().FirstOrDefault(x => x.Value == individual.State).Key;
                //zipTextBox.Text = individual.ZipCode;
                //ssnTextBox.Text = individual.SSN;
                //phoneTextBox.Text = individual.PhoneNumber;
                //if (individual.DateOfBirth.CompareTo(DateTime.MinValue) > 0)
                //{
                //    dateTextBox.Text = individual.DateOfBirth.ToShortDateString();
                //    deletePatientButton.Enabled = true;
                //}
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

        private void DeletePatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (patientController.DeletePatientWithoutAppointment(this.pid))
                {
                    ClearControls();
                    this.ParentForm.DialogResult = DialogResult.OK;
                    //findPatientTextbox.Text = "";
                    //errorLabel.Text = "The patient was successfully deleted";
                }
                else
                {
                    errorLabel.Text = "The patient was not deleted. They have an appointment";
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }

    }
}
