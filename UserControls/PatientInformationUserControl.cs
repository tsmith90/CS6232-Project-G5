using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClinicSupport.Controller;
using ClinicSupport.Model;
using ClinicSupport.View;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to interact and control patient information in the application
    /// </summary>
    public partial class PatientInformationUserControl : UserControl
    {
        private readonly Dictionary<string, string> states;
        private readonly States statesList;
        private readonly IndividualController individualController;
        private readonly PatientController patientController;
        private Individual _individual;

        /// <summary>
        /// 0 parameter contructor for PatientInformationUserControl
        /// </summary>
        public PatientInformationUserControl()
        {
            InitializeComponent();
            this.individualController = new IndividualController();
            this.patientController = new PatientController();
            this._individual = new Individual();
            statesList = new States();
            states = statesList.SetStates();
            SetStateList();
        }

        /// <summary>
        /// Hides the Update button
        /// </summary>
        public void HideUpdateButton()
        {
            updateButton.Visible = false;
            closeButton.Visible = false;
            patientInfoLabel.Text = "New Patient";
            apptButton.Visible = false;
        }

        /// <summary>
        /// Hides the Create patient button
        /// </summary>
        public void HideNewButton()
        {
            createPatientButton.Visible = false;
            patientInfoLabel.Text = "Patient Information";
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void SetPatient(Individual patient)
        {
            this._individual = patient;
            firstNameTextBox.Text = patient.FirstName;
            lastNameTextBox.Text = patient.LastName;
            dobTextBox.Text = patient.DateOfBirth.ToString("MM-dd-yyyy");
            phoneTextBox.Text = patient.PhoneNumber.ToString();
            ssnTextBox.Text = patient.SSN;
            addressTextBox.Text = patient.StreetAddress;
            cityTextBox.Text = patient.City;
            stateComboBox.SelectedItem = GetSelectedState(patient.State);
            zipTextBox.Text = patient.ZipCode.ToString();
        }

        private void SetStateList()
        {
            List<string> names = states.Keys.ToList();

            stateComboBox.DataSource = names;
            stateComboBox.SelectedIndex = 0;
        }

        private void CreatePatientButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (this.firstNameTextBox.Text == String.Empty || this.lastNameTextBox.Text == String.Empty || this.dobTextBox.Text == String.Empty || this.phoneTextBox.Text == String.Empty || this.phoneTextBox.Text.Length < 10 || this.ssnTextBox.Text == String.Empty || this.ssnTextBox.Text.Length > 9 || this.ssnTextBox.Text.Length < 9 ||
                    this.addressTextBox.Text == String.Empty || this.cityTextBox.Text == String.Empty || this.stateComboBox.SelectedIndex == -1 || this.zipTextBox.Text == String.Empty || this.zipTextBox.Text != String.Empty && !Int32.TryParse(this.zipTextBox.Text, out int number))
                {
                    string message = "Please enter the required values:";
                    if (this.firstNameTextBox.Text == String.Empty)
                    {
                        message += "\n-First name is missing";
                    }
                    if (this.lastNameTextBox.Text == String.Empty)
                    {
                        message += "\n-Last name is missing";
                    }
                    if (this.dobTextBox.Text == String.Empty)
                    {
                        message += "\n-Date of Birth is missing";
                    }
                    if (this.phoneTextBox.Text == String.Empty)
                    {
                        message += "\n-Phone number is missing";
                    }
                    if (this.phoneTextBox.Text.Length < 10)
                    {
                        message += "\n-Phone number must contain 10 numbers (XXXXXXXXXX)";
                    }
                    if (this.ssnTextBox.Text == String.Empty)
                    {
                        message += "\n-SSN is missing";
                    }
                    if (this.ssnTextBox.Text.Length > 9 || this.ssnTextBox.Text.Length < 9)
                    {
                        message += "\n-SSN should be exactly 9 numbers in length";
                    }
                    if (this.addressTextBox.Text == String.Empty)
                    {
                        message += "\n-Address is missing";
                    }
                    if (this.cityTextBox.Text == String.Empty)
                    {
                        message += "\n-City is missing";
                    }
                    if (stateComboBox.SelectedIndex == -1)
                    {
                        message += "\n-State is not selected";
                    }
                    if (this.zipTextBox.Text == String.Empty)
                    {
                        message += "\n-Zip is missing";
                    }
                    if (this.zipTextBox.Text != String.Empty && !Int32.TryParse(this.zipTextBox.Text, out int num))
                    {
                        message += "\n-Zip must be a number";
                    }
                    MessageBox.Show(message, "Missing Information");
                }
                else
                {
                    this.messageLabel.Text = "";
                    Individual newIndividual = new Individual();
                    this.PutIndividualData(newIndividual);
                    bool duplicateSSNExists = this.individualController.IsDuplicateSSN(newIndividual.SSN);

                    if (duplicateSSNExists)
                    {
                        MessageBox.Show("The SSN for this individual is already in use.", "Duplicate SSN");
                    }
                    else
                    {
                        int patientID = this.patientController.InsertNewPatient(newIndividual);
                        Patient myPatient = this.patientController.GetPatientByID(patientID);
                        Individual myIndividual = this.individualController.GetIndividualByID(myPatient.IndividualID);
                        this.messageLabel.Text = "Patient " + myIndividual.FirstName + " " + myIndividual.LastName + " has been created!";
                        this.messageLabel.ForeColor = Color.Black;
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dobTextBox.Text = "";
            phoneTextBox.Text = "";
            ssnTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.SelectedIndex = 0;
            zipTextBox.Text = "";
            this.messageLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private string GetSelectedState(string stateName)
        {
            string myState = "";
            if (stateName.Length == 2)
            {
                if (this.states.ContainsValue(stateName))
                {
                    myState = this.states.FirstOrDefault(x => x.Value == stateName).Key;
                }
            }
            else
            {
                if (this.states.ContainsKey(stateName))
                {
                    myState = this.states[stateName];
                }
            }
            return myState;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.firstNameTextBox.Text == String.Empty || this.lastNameTextBox.Text == String.Empty || this.dobTextBox.Text == String.Empty || this.phoneTextBox.Text == String.Empty || this.phoneTextBox.Text.Length < 10 || this.ssnTextBox.Text == String.Empty || this.ssnTextBox.Text.Length > 9 || this.ssnTextBox.Text.Length < 9 ||
                    this.addressTextBox.Text == String.Empty || this.cityTextBox.Text == String.Empty || this.stateComboBox.SelectedIndex == -1 || this.zipTextBox.Text == String.Empty || this.zipTextBox.Text != String.Empty && !Int32.TryParse(this.zipTextBox.Text, out int number))
                {
                    string message = "Please enter the required values:";
                    if (this.firstNameTextBox.Text == String.Empty)
                    {
                        message += "\n-First name is missing";
                    }
                    if (this.lastNameTextBox.Text == String.Empty)
                    {
                        message += "\n-Last name is missing";
                    }
                    if (this.dobTextBox.Text == String.Empty)
                    {
                        message += "\n-Date of Birth is missing";
                    }
                    if (this.phoneTextBox.Text == String.Empty)
                    {
                        message += "\n-Phone number is missing";
                    }
                    if (this.phoneTextBox.Text.Length < 10)
                    {
                        message += "\n-Phone number must contain 10 numbers (XXXXXXXXXX)";
                    }
                    if (this.ssnTextBox.Text == String.Empty)
                    {
                        message += "\n-SSN is missing";
                    }
                    if (this.ssnTextBox.Text.Length > 9 || this.ssnTextBox.Text.Length < 9)
                    {
                        message += "\n-SSN should be exactly 9 numbers in length";
                    }
                    if (this.addressTextBox.Text == String.Empty)
                    {
                        message += "\n-Address is missing";
                    }
                    if (this.cityTextBox.Text == String.Empty)
                    {
                        message += "\n-City is missing";
                    }
                    if (stateComboBox.SelectedIndex == -1)
                    {
                        message += "\n-State is not selected";
                    }
                    if (this.zipTextBox.Text == String.Empty)
                    {
                        message += "\n-Zip is missing";
                    }
                    if (this.zipTextBox.Text != String.Empty && !Int32.TryParse(this.zipTextBox.Text, out int num))
                    {
                        message += "\n-Zip must be a number";
                    }
                    MessageBox.Show(message, "Missing Information");
                }
                else
                {
                    Individual newIndividual = new Individual();
                    newIndividual.IndividualID = this._individual.IndividualID;
                    this.PutIndividualData(newIndividual);

                    if (!patientController.UpdatePatient(this._individual, newIndividual))
                    {
                        MessageBox.Show("Cannot update patient", "Database Error");
                    }
                    else
                    {
                        this._individual = newIndividual;
                        this.messageLabel.Text = "Patient was successfully updated!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Assigns current values within the input fields to the individual object passsed in
        /// </summary>
        /// <param name="individual">Individual object passed in to assign values within the input fields at the time of the method call</param>
        public void PutIndividualData(Individual individual)
        {
            var fname = this.firstNameTextBox.Text;
            var lname = this.lastNameTextBox.Text;
            var dob = Convert.ToDateTime(this.dobTextBox.Text);
            var phone = this.phoneTextBox.Text;
            var ssn = this.ssnTextBox.Text;
            var address = this.addressTextBox.Text;
            var city = this.cityTextBox.Text;
            var state = this.GetSelectedState(this.stateComboBox.SelectedValue.ToString());
            var zip = int.Parse(this.zipTextBox.Text);

            individual.FirstName = fname;
            individual.LastName = lname;
            individual.DateOfBirth = dob;
            individual.PhoneNumber = phone;
            individual.SSN = ssn;
            individual.StreetAddress = address;
            individual.City = city;
            individual.State = state;
            individual.ZipCode = zip.ToString();
        }

        /// <summary>
        /// Sets the instance variable individual to the current values of the input fields when called upon
        /// </summary>
        public void SetIndividualData()
        {
            var fname = this.firstNameTextBox.Text;
            var lname = this.lastNameTextBox.Text;
            var dob = Convert.ToDateTime(this.dobTextBox.Text);
            var phone = this.phoneTextBox.Text;
            var ssn = this.ssnTextBox.Text;
            var address = this.addressTextBox.Text;
            var city = this.cityTextBox.Text;
            var state = this.GetSelectedState(this.stateComboBox.SelectedValue.ToString());
            var zip = int.Parse(this.zipTextBox.Text);

            this._individual.FirstName = fname;
            this._individual.LastName = lname;
            this._individual.DateOfBirth = dob;
            this._individual.PhoneNumber = phone;
            this._individual.SSN = ssn;
            this._individual.StreetAddress = address;
            this._individual.City = city;
            this._individual.State = state;
            this._individual.ZipCode = zip.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.OK;
        }

        private void apptButton_Click(object sender, EventArgs e)
        {
            int patientID = 0;
            if (this._individual.IndividualID > 0) {
                patientID = this.patientController.GetPatientIDByIndividualID(this._individual.IndividualID);
            }
            if (patientID > 0)
            {
                ViewPatientAppointmentForm apptForm = new ViewPatientAppointmentForm();
                apptForm.SetAppointment(patientID);
                DialogResult result = apptForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                }
            }
        }
    }
}
