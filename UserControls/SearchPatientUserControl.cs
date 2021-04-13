using ClinicSupport.Controller;
using ClinicSupport.Model;
using ClinicSupport.View;
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
        private readonly PatientController patientController;

        private List<Individual> patients;

        /// <summary>
        /// 0-parameter constructor for the SearchPatientUserControl
        /// </summary>
        public SearchPatientUserControl()
        {
            InitializeComponent();
            searchCriteriaTableLayout.Hide();
            this.patientController = new PatientController();
            this.patients = new List<Individual>();
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
            if (patientsDataGridView.Columns.Count > 1)
            {
                patientsDataGridView.Columns.Clear();
                patientsDataGridView.DataSource = null;
            }
            try
            {
                DateTime dob = Convert.ToDateTime(dobTextField.Text);
                this.patients = this.patientController.GetPatientsByDOB(dob);

                if (this.patients.Count == 0)
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
                MessageBox.Show("Please make sure all values are entered", ioore.GetType().ToString());
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            patientsDataGridView.DataSource = this.patients;
            patientsDataGridView.Columns["LastName"].DisplayIndex = 2;
            patientsDataGridView.Columns["FirstName"].DisplayIndex = 1;

            AddEditColumnToGV();
        }

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            if (patientsDataGridView.Columns.Count > 1)
            {
                patientsDataGridView.Columns.Clear();
                patientsDataGridView.DataSource = null;
            }
            try
            {
                string fname = firstLastNameTextBox.Text.Split(' ')[0];
                string lname = firstLastNameTextBox.Text.Split(' ')[1];
                this.patients = this.patientController.GetPatientsByFirstAndLastName(fname, lname);

                if (this.patients.Count == 0)
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
                MessageBox.Show("Please make sure all values are entered", ioore.GetType().ToString());
            }
            patientsDataGridView.DataSource = this.patients;
            patientsDataGridView.Columns["LastName"].DisplayIndex = 2;
            patientsDataGridView.Columns["FirstName"].DisplayIndex = 1;
            AddEditColumnToGV();
        }

        private void SearchDOBAndLastNameButton_Click(object sender, EventArgs e)
        {
            if (patientsDataGridView.Columns.Count > 1)
            {
                patientsDataGridView.Columns.Clear();
                patientsDataGridView.DataSource = null;
            }
            try
            {
                string lname = dobLastNameTextBox.Text.Split(' ')[0];
                string dobString = dobLastNameTextBox.Text.Split(' ')[1];
                DateTime dob = Convert.ToDateTime(dobString);
                this.patients = this.patientController.GetPatientsByLastNameAndDOB(lname, dob);
                
                if (this.patients.Count == 0)
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
                MessageBox.Show("Please make sure all values are entered", ioore.GetType().ToString());
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            patientsDataGridView.DataSource = this.patients;
            patientsDataGridView.Columns["LastName"].DisplayIndex = 2;
            patientsDataGridView.Columns["FirstName"].DisplayIndex = 1;
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
            if (e.ColumnIndex == 9)
            {           
                var id = Convert.ToInt32(patientsDataGridView.Rows[e.RowIndex].Cells[0].Value);
                var fname = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[2].Value);
                var lname = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[1].Value);
                var dob = Convert.ToDateTime(patientsDataGridView.Rows[e.RowIndex].Cells[3].Value);
                var address = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[4].Value);
                var city = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[5].Value);
                var state = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[6].Value);
                var zip = Convert.ToInt32(patientsDataGridView.Rows[e.RowIndex].Cells[7].Value);
                var phone = Convert.ToString(patientsDataGridView.Rows[e.RowIndex].Cells[8].Value);
                Individual patient = new Individual();
                patient.IndividualID = id;
                patient.FirstName = fname;
                patient.LastName = lname;
                patient.DateOfBirth = dob;
                patient.PhoneNumber = phone;
                patient.StreetAddress = address;
                patient.City = city;
                patient.State = state;
                patient.ZipCode = zip;
                
                ViewPatientInformationForm infoForm = new ViewPatientInformationForm();
                infoForm.SetPatient(patient);
                infoForm.PutIndividualData(patient);
                infoForm.SetIndividualData();
                DialogResult result = infoForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    patientsDataGridView.Columns.Clear();
                    patientsDataGridView.DataSource = null;
                    // Find a way to refresh the patients list so that way the datasource can be up to date
                    patientsDataGridView.DataSource = this.patients;
                }
            }
        }

        private void ClearSearchesButton_Click(object sender, EventArgs e)
        {
            dobTextField.Text = "";
            firstLastNameTextBox.Text = "";
            dobLastNameTextBox.Text = "";
            if (patientsDataGridView.Columns.Count > 1)
            {
                patientsDataGridView.DataSource = null;
                patientsDataGridView.Columns.Clear();
            }
        }
    }
}
