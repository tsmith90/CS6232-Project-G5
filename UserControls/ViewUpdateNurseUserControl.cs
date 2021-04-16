using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class ViewUpdateNurseUserControl : UserControl
    {
        private readonly Dictionary<string, string> states;
        private readonly NurseController nurseController;
        private readonly IndividualController individualController;
        private Individual individual;
        private Nurse nurse;

        public ViewUpdateNurseUserControl()
        {
            InitializeComponent();
            states = new Dictionary<string, string>();
            nurseController = new NurseController();
            individualController = new IndividualController();
            individual = new Individual();
            nurse = new Nurse();
            SetControls();
            SetStateList();
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        public void ClearControls()
        {
            firstNameTextbox.Text = "";
            lastNameTextbox.Text = "";
            dateOfBirthTimePicker.Value = DateTime.Now;
            addressTextbox.Text = "";
            cityTextbox.Text = "";
            zipTextbox.Text = "";
            ssnTextbox.Text = "";
            phoneTextbox.Text = "";
            stateComboBox.SelectedIndex = 0;
            errorLabel.Text = "";
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

        private void FindNurseButton_Click(object sender, EventArgs e)
        {
            ClearControls();

            if(string.IsNullOrEmpty(findNurseTextBox.Text))
            {
                errorLabel.Text = "Please enter a nurse Username";
            }
            else
            {
                string getNurse = findNurseTextBox.Text;
                nurse = nurseController.GetNurseByUsername(getNurse);

                if(nurse.IndividualID != 0)
                {
                    int id = nurse.IndividualID;
                    individual = individualController.GetIndividualByID(id);
                    PopulateControls();
                    OpenControls();
                }
                else
                {
                    SetControls();
                    errorLabel.Text = "That username isn't a nurse.";
                }
            }
        }

        private void PopulateControls()
        {
            firstNameTextbox.Text = individual.FirstName;
            lastNameTextbox.Text = individual.LastName;
            addressTextbox.Text = individual.StreetAddress;
            cityTextbox.Text = individual.City;
            stateComboBox.SelectedItem = states.FirstOrDefault(x => x.Value == individual.State).Key;
            zipTextbox.Text = individual.ZipCode.ToString();
            dateOfBirthTimePicker.Value = individual.DateOfBirth;
            ssnTextbox.Text = individual.SSN;
            phoneTextbox.Text = individual.PhoneNumber;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(CheckChanges())
            {
                errorLabel.Text = "Please enter something to update";
            }
            else if (string.IsNullOrEmpty(firstNameTextbox.Text))
            {
                errorLabel.Text = "Please provide a first name";
            }
            else if (string.IsNullOrEmpty(lastNameTextbox.Text))
            {
                errorLabel.Text = "Please provide a last name";
            }
            else if (string.IsNullOrEmpty(addressTextbox.Text))
            {
                errorLabel.Text = "Please provide an address";
            }
            else if (string.IsNullOrEmpty(cityTextbox.Text))
            {
                errorLabel.Text = "Please provide a city";
            }
            else if (string.IsNullOrEmpty(zipTextbox.Text) || zipTextbox.Text.Length != 5)
            {
                errorLabel.Text = "Please provide a valid zip code";
            }
            else if (string.IsNullOrEmpty(ssnTextbox.Text) || ssnTextbox.Text.Length != 9)
            {
                errorLabel.Text = "Please provide a valid SSN";
            }
            else if (string.IsNullOrEmpty(phoneTextbox.Text) || phoneTextbox.Text.Length != 10)
            {
                errorLabel.Text = "Please provide a valid phone number";
            }
            else
            {
                try
                {
                    long zip = ParseNumbers(zipTextbox.Text, "zip code");
                    long ssn = ParseNumbers(ssnTextbox.Text, "SSN");
                    long phone = ParseNumbers(phoneTextbox.Text, "phone number");

                    DialogResult dialogResult = MessageBox.Show("Are you sure you would like to update this Nurse?"
                        , "Confirm Update", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        UpdateNurse();
                    }
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

        private void SetControls()
        {
            firstNameTextbox.Enabled = false;
            lastNameTextbox.Enabled = false;
            addressTextbox.Enabled = false;
            cityTextbox.Enabled = false;
            stateComboBox.Enabled = false;
            zipTextbox.Enabled = false;
            dateOfBirthTimePicker.Enabled = false;
            ssnTextbox.Enabled = false;
            phoneTextbox.Enabled = false;
        }

        private void OpenControls()
        {
            firstNameTextbox.Enabled = true;
            lastNameTextbox.Enabled = true;
            addressTextbox.Enabled = true;
            cityTextbox.Enabled = true;
            stateComboBox.Enabled = true;
            zipTextbox.Enabled = true;
            dateOfBirthTimePicker.Enabled = true;
            ssnTextbox.Enabled = true;
            phoneTextbox.Enabled = true;
        }

        private bool CheckChanges()
        {
            if (individual.FirstName.Equals(firstNameTextbox.Text) && individual.LastName.Equals(lastNameTextbox.Text) 
                && individual.StreetAddress.Equals(addressTextbox.Text) && individual.City.Equals(cityTextbox.Text) &&
                individual.State.Equals(states[stateComboBox.SelectedItem.ToString()]) && individual.ZipCode.Equals(zipTextbox.Text) &&
                individual.DateOfBirth.Equals(dateOfBirthTimePicker.Value) && individual.SSN.Equals(ssnTextbox.Text) &&
                individual.PhoneNumber.Equals(phoneTextbox.Text))
            {
                return true;
            }
            else
            {
                return false;
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

        private void UpdateNurse()
        {
            Individual newIndividual = new Individual();

            newIndividual.FirstName = firstNameTextbox.Text;
            newIndividual.LastName = lastNameTextbox.Text;
            newIndividual.StreetAddress = addressTextbox.Text;
            newIndividual.City = cityTextbox.Text;
            newIndividual.State = states[stateComboBox.SelectedItem.ToString()];
            newIndividual.ZipCode = zipTextbox.Text;
            newIndividual.DateOfBirth = dateOfBirthTimePicker.Value;
            newIndividual.SSN = ssnTextbox.Text;
            newIndividual.PhoneNumber = phoneTextbox.Text;

            if(individualController.UpdateIndividual(newIndividual))
            {
                errorLabel.Text = "Nurse was successfully updated";
            }
            else
            {
                errorLabel.Text = "Nurse was not updated. Check your info and try again.";
            }
        }
    }
}
