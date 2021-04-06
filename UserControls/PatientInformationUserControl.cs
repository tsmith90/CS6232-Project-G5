using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClinicSupport.Controller;
using ClinicSupport.Model;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to interact and control patient information in the application
    /// </summary>
    public partial class PatientInformationUserControl : UserControl
    {
        private readonly Dictionary<string, string> states;
        private IndividualController individualController;
        private PatientController patientController;
        private int patientID;

        /// <summary>
        /// 0 parameter contructor
        /// </summary>
        public PatientInformationUserControl()
        {
            InitializeComponent();
            this.individualController = new IndividualController();
            this.patientController = new PatientController();
            states = new Dictionary<string, string>();
            SetStateList();
        }

        /// <summary>
        /// Hides the Update button
        /// </summary>
        public void HideUpdateButton()
        {
            updateButton.Visible = false;
            patientInfoLabel.Text = "New Patient";
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
            firstNameTextBox.Text = patient.FirstName;
            lastNameTextBox.Text = patient.LastName;
            dobTextBox.Text = patient.DateOfBirth.ToString();
            phoneTextBox.Text = patient.PhoneNumber.ToString();
            addressTextBox.Text = patient.StreetAddress;
            cityTextBox.Text = patient.City;
            stateComboBox.SelectedItem = GetSelectedState(patient.State);
            zipTextBox.Text = patient.ZipCode.ToString();
        }

        private void SetStateList()
        {
            states.Add("Alabama", "AL");
            states.Add("Alaska", "AK");
            states.Add("America Samoa", "AS");
            states.Add("Arizona", "AZ");
            states.Add("Arkansas", "AR");
            states.Add("California", "CA");
            states.Add("Colorado", "CO");
            states.Add("Connecticut", "CT");
            states.Add("Delaware", "DE");
            states.Add("District of Columbia", "DC");
            states.Add("Florida", "FL");
            states.Add("Georgia", "GA");
            states.Add("Guam", "GU");
            states.Add("Hawaii", "HI");
            states.Add("Idaho", "NurseID");
            states.Add("Illinois", "IL");
            states.Add("Indiana", "IN");
            states.Add("Iowa", "IA");
            states.Add("Kansas", "KS");
            states.Add("Kentucky", "KY");
            states.Add("Louisiana", "LA");
            states.Add("Maine", "ME");
            states.Add("Maryland", "MD");
            states.Add("Massachusetts", "MA");
            states.Add("Michigan", "MI");
            states.Add("Minnesota", "MN");
            states.Add("Mississippi", "MS");
            states.Add("Missouri", "MO");
            states.Add("Montana", "MT");
            states.Add("Nebraska", "NE");
            states.Add("Nevada", "NV");
            states.Add("New Hampshire", "NH");
            states.Add("New Jersey", "NJ");
            states.Add("New Mexico", "NM");
            states.Add("New York", "NY");
            states.Add("North Carolina", "NC");
            states.Add("North Dakota", "ND");
            states.Add("Northern Mariana Islands", "MP");
            states.Add("Ohio", "OH");
            states.Add("Oklahoma", "OK");
            states.Add("Oregon", "OR");
            states.Add("Pennsylvania", "PA");
            states.Add("Puerto Rico", "PR");
            states.Add("Rhode Island", "RI");
            states.Add("South Carolina", "SC");
            states.Add("South Dakota", "SD");
            states.Add("Tennessee", "TN");
            states.Add("Texas", "TX");
            states.Add("Utah", "UT");
            states.Add("Vermont", "VT");
            states.Add("Virginia", "VA");
            states.Add("Virgin Islands", "VI");
            states.Add("Washington", "WA");
            states.Add("West Virginia", "WV");
            states.Add("Wisconsin", "WI");
            states.Add("Wyoming", "WY");

            List<string> names = states.Keys.ToList();

            stateComboBox.DataSource = names;
        }

        private void CreatePatientButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (this.firstNameTextBox.Text == String.Empty || this.lastNameTextBox.Text == String.Empty || this.dobTextBox.Text == String.Empty || this.phoneTextBox.Text == String.Empty || 
                    this.addressTextBox.Text == String.Empty || this.cityTextBox.Text == String.Empty || this.stateComboBox.SelectedIndex == 0 || this.zipTextBox.Text == String.Empty)
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
                    if (this.addressTextBox.Text == String.Empty)
                    {
                        message += "\n-Address is missing";
                    }
                    if (this.cityTextBox.Text == String.Empty)
                    {
                        message += "\n-City is missing";
                    }
                    if (stateComboBox.SelectedIndex == 0)
                    {
                        message += "\n-State is not selected";
                    }
                    if (this.zipTextBox.Text == String.Empty)
                    {
                        message += "\n-Zip is missing";
                    }
                    MessageBox.Show(message, "Missing Information");
                }
                else
                {
                    this.messageLabel.Text = "";
                    var fname = this.firstNameTextBox.Text;
                    var lname = this.lastNameTextBox.Text;
                    var dob = Convert.ToDateTime(this.dobTextBox.Text);
                    var phone = this.phoneTextBox.Text;
                    var address = this.addressTextBox.Text;
                    var city = this.cityTextBox.Text;
                    var state = this.GetSelectedState(this.stateComboBox.SelectedValue.ToString());
                    var zip = int.Parse(this.zipTextBox.Text);
                    
                    Individual newIndividual = new Individual();
                    newIndividual.FirstName = fname;
                    newIndividual.LastName = lname;
                    newIndividual.DateOfBirth = dob;
                    newIndividual.PhoneNumber = phone;
                    newIndividual.StreetAddress = address;
                    newIndividual.City = city;
                    newIndividual.State = state;
                    newIndividual.ZipCode = zip;

                    var newIndividualID = this.individualController.InsertNewIndividual(newIndividual);
                    patientID = this.patientController.InsertNewPatient(newIndividualID);
                    this.ClearForm();
                    this.messageLabel.Text = "Patient has been added!";
                    this.messageLabel.ForeColor = Color.Black;
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
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.SelectedIndex = 0;
            zipTextBox.Text = "";
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

        private void NewAppointmentButton_Click(object sender, EventArgs e)
        {
            //NewAppointmentForm newAppointment = new NewAppointmentForm(patientID);
            //DialogResult result = newAppointment.ShowDialog();
        }
    }
}
