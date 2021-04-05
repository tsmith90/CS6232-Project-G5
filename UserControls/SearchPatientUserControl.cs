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
            dobTextField.Text = "";
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
            firstLastNameTextBox.Text = "";
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
            dobLastNameTextBox.Text = "";
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
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Please make sure all values are entered", "Not all values entered");
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            patientsDataGridView.DataSource = patients;
            AddEditColumnToGV();
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
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Please make sure all values are entered", "Not all values entered");
            }
            patientsDataGridView.DataSource = patients;
            AddEditColumnToGV();
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
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Please make sure all values are entered", "Not all values entered");
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            patientsDataGridView.DataSource = patients;
            AddEditColumnToGV();
        }

        private void AddEditColumnToGV()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            Editlink.Width = 60;
            patientsDataGridView.Columns.Add(Editlink);
        }

        private void PatientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Edit column 
            if (e.ColumnIndex == 8)
            {               
                var lname = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[0].Value);
                var fname = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[1].Value);
                var dob = Convert.ToDateTime(patientsDataGridView.Rows[e.RowIndex].Cells[2].Value);
                var address = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[3].Value);
                var city = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[4].Value);
                var state = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[5].Value);
                var zip = Convert.ToInt32(patientsDataGridView.Rows[e.RowIndex].Cells[6].Value);
                var phone = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[7].Value);
                Individual patient = new Individual();
                patient.FirstName = fname;
                patient.LastName = lname;
                patient.DateOfBirth = dob;
                patient.PhoneNumber = phone;
                patient.StreetAddress = address;
                patient.City = city;
                patient.State = state;
                patient.ZipCode = zip;
                MessageBox.Show(patient.StreetAddress);
                /*
                ViewPatientInformationForm infoForm = new ViewPatientInformationForm();
                infoForm.SetPatient(patient);
                DialogResult result = infoForm.ShowDialog();
                patientsDataGridView.Refresh();*/
            }
        }
    }
}
