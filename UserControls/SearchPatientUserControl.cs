using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// Usercontrol to search patient information in the Nurse Dashboard
    /// </summary>
    public partial class SearchPatientUserControl : UserControl
    {
        private PatientController patientController;
        /// <summary>
        /// 0-parameter constructor for the SearchPatientUserControl
        /// </summary>
        public SearchPatientUserControl()
        {
            InitializeComponent();
            searchCriteriaTableLayout.Hide();
            this.patientController = new PatientController();
           //patientInformationUserControl1.Hide();
            //patientInformationUserControl1.HideNewButton();
        }

        private void SearchDOBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchCriteriaTableLayout.Show();
            dobTextField.Show();
            searchDOBButton.Show();
            firstLastNameTextBox.Hide();
            searchNameButton.Hide();
            dobLastNameTextBox.Hide();
            searchDOBAndLastNameButton.Hide();
        }

        private void SearchFirstLastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchCriteriaTableLayout.Show();
            dobTextField.Hide();
            searchDOBButton.Hide();
            firstLastNameTextBox.Show();
            searchNameButton.Show();
            dobLastNameTextBox.Hide();
            searchDOBAndLastNameButton.Hide();
        }

        private void SearchDOBLastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchCriteriaTableLayout.Show();
            dobTextField.Hide();
            searchDOBButton.Hide();
            firstLastNameTextBox.Hide();
            searchNameButton.Hide();
            dobLastNameTextBox.Show();
            searchDOBAndLastNameButton.Show();
        }

        private void SearchDOBButton_Click(object sender, EventArgs e)
        {
            List<Individual> patients = new List<Individual>();
            try
            {
                DateTime dob = Convert.ToDateTime(dobTextField.Text);
                patients = this.patientController.GetPatientsByDOB(dob);

                if (patients.Count == 0)
                {
                    MessageBox.Show("No patient found with the date of birth entered", "No Patient Found");
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            patientsDataGridView.DataSource = patients;
        }

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            List<Individual> patients = new List<Individual>();
            try
            {
                string fname = firstLastNameTextBox.Text.Split(' ')[0];
                string lname = firstLastNameTextBox.Text.Split(' ')[1];
                patients = this.patientController.GetPatientsByFirstAndLastName(fname, lname);

                if (patients.Count == 0)
                {
                    MessageBox.Show("No patient found with the first and last name entered", "No Patient Found");
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            patientsDataGridView.DataSource = patients;
        }

        private void SearchDOBAndLastNameButton_Click(object sender, EventArgs e)
        {
            List<Individual> patients = new List<Individual>();
            try
            {
                string lname = dobLastNameTextBox.Text.Split(' ')[0];
                string dobString = dobLastNameTextBox.Text.Split(' ')[1];
                DateTime dob = Convert.ToDateTime(dobString);
                patients = this.patientController.GetPatientsByLastNameAndDOB(lname, dob);
                
                if (patients.Count == 0)
                {
                    MessageBox.Show("No patient found with the last name and date of birth entered", "No Patient Found");
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            patientsDataGridView.DataSource = patients;
        }
    }
}
