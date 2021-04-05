using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
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
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            patientsDataGridView.DataSource = patients;
        }
    }
}
