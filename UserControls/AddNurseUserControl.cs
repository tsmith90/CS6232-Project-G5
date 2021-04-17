using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl for Adding Nurses to the DB
    /// </summary>
    public partial class AddNurseUserControl : UserControl
    {

        private readonly Dictionary<string, string> states;

        /// <summary>
        /// 0-parameter constructor for the AddNurseUserControl
        /// </summary>
        public AddNurseUserControl()
        {
            InitializeComponent();
            states = new Dictionary<string, string>();
            SetStateList();
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            ClearControls();
        }

        /// <summary>
        /// Method to reset the UserControl controls
        /// </summary>
        public void ClearControls()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dateOfBirthTimePicker.Value = DateTime.Now;
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            zipTextBox.Text = "";
            phoneTextBox.Text = "";
            stateComboBox.SelectedIndex = 0;
            errorLabel.Text = "";
            usernameTextBox.Text = "";
            passwordTextbox.Text = "";
            confirmPasswordTextbox.Text = "";
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
            stateComboBox.SelectedIndex = 0;
        }

        private void AddNurseButton_Click(object sender, EventArgs e)
        {
            Individual newNurse = new Individual();

            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                errorLabel.Text = "Please provide a first name";
            }
            else if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                errorLabel.Text = "Please provide a last name";
            }
            else if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                errorLabel.Text = "Please provide an address";
            }
            else if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                errorLabel.Text = "Please provide a city";
            }
            else if (string.IsNullOrEmpty(zipTextBox.Text) || zipTextBox.Text.Length != 5)
            {
                errorLabel.Text = "Please provide a valid zip code";
            }
            else if (string.IsNullOrEmpty(ssnTextBox.Text) || ssnTextBox.Text.Length != 9)
            {
                errorLabel.Text = "Please provide a valid SSN";
            }
            else if (string.IsNullOrEmpty(phoneTextBox.Text) || phoneTextBox.Text.Length != 10)
            {
                errorLabel.Text = "Please provide a valid phone number";
            }
            else if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                errorLabel.Text = "Please provide a valid username";
            }
            else if (string.IsNullOrEmpty(passwordTextbox.Text))
            {
                errorLabel.Text = "Please provide a valid password";
            }
            else if (string.IsNullOrEmpty(confirmPasswordTextbox.Text))
            {
                errorLabel.Text = "Please confirm the password";
            }
            else if (!passwordTextbox.Text.Equals(confirmPasswordTextbox.Text))
            {
                errorLabel.Text = "The passwords don't match!";
            }
            else
            {
                try
                {
                    long zip = ParseNumbers(zipTextBox.Text, "zip code");
                    long ssn = ParseNumbers(ssnTextBox.Text, "SSN");
                    long phone = ParseNumbers(phoneTextBox.Text, "phone number");

                    newNurse.ZipCode = zip.ToString();
                    newNurse.SSN = ssn.ToString();
                    newNurse.PhoneNumber = phone.ToString();
                    newNurse.FirstName = firstNameTextBox.Text;
                    newNurse.LastName = lastNameTextBox.Text;
                    newNurse.StreetAddress = addressTextBox.Text;
                    newNurse.City = cityTextBox.Text;

                    string state = states[stateComboBox.SelectedItem.ToString()];
                    newNurse.State = state;
                    newNurse.DateOfBirth = dateOfBirthTimePicker.Value;


                    //add newNurse to the DB here

                }
                catch (FormatException ex)
                {
                    errorLabel.Text = "Please enter a valid " + ex.Message;
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }

        }

        private long ParseNumbers(string numbers, string text)
        {
            long id;

            try
            {
                id = Int64.Parse(numbers);
            }
            catch (FormatException)
            {
                throw new FormatException(text);
            }

            return id;
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
