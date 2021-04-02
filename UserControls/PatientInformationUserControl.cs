using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClinicSupport.Model;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to interact and control patient information in the application
    /// </summary>
    public partial class PatientInformationUserControl : UserControl
    {
        private readonly Dictionary<string, string> states;

        /// <summary>
        /// 0 parameter contructor
        /// </summary>
        public PatientInformationUserControl()
        {
            InitializeComponent();
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
            stateComboBox.SelectedItem = patient.State;
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
            states.Add("Idaho", "ID");
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
    }
}
