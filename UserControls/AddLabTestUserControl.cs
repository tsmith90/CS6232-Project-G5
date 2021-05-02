using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to add lab tests
    /// </summary>
    public partial class AddLabTestUserControl : UserControl
    {
        private LabTestController labTestController;
        private TestController testController;
        private Appointment appointment;
        private PatientController patientController;
        private IndividualController individualController;
        private VisitController visitController;
        private int pid;
        private Individual individual;

        /// <summary>
        /// 0-parameter constructor for AddLabTestUserControl
        /// </summary>
        public AddLabTestUserControl()
        {
            InitializeComponent(); testController = new TestController();
            labTestController = new LabTestController();
            this.patientController = new PatientController();
            this.individualController = new IndividualController();
            this.visitController = new VisitController();
            this.appointment = new Appointment();
            this.individual = new Individual();
            this.SetTests();
        }

        private void OrderTestUserControlOrderTestUserControl_Load(object sender, System.EventArgs e)
        {
            if (this.pid > 0)
            {
                Patient patient = this.patientController.GetPatientByID(this.pid);
                this.individual = this.individualController.GetIndividualByID(patient.IndividualID);
                //this.titleLabel.Text = "Order new Lab Test for " + this.individual.FirstName + " " + this.individual.LastName;
            }
        }

        /// <summary>
        /// sets the patient and appointment for ordering a test
        /// </summary>
        /// <param name="_appt">Appointment object used to obtain the patientID and apptDate</param>
        public void SetPatientAndAppointment(Appointment _appt)
        {
            this.appointment = _appt;
        }

        /// <summary>
        /// sets the patient and appointment for ordering a test
        /// </summary>
        /// <param name="pid">Patient ID  used to obtain the patientobject</param>
        public void SetPatient(int pid)
        {
            this.pid = pid;
            if (this.pid > 0)
            {
                Patient patient = this.patientController.GetPatientByID(this.pid);
                Individual indv = this.individualController.GetIndividualByID(patient.IndividualID);
                this.titleLabel.Text = "Order new Lab Test for " + indv.FirstName + " " + indv.LastName;
                this.PopulateComboBox();
            }

        }

        private void SetTests()
        {
            List<Test> tests = testController.GetTests();

            testComboBox.DataSource = tests;
            testComboBox.DisplayMember = "name";
            testComboBox.ValueMember = "Code";
            testComboBox.SelectedIndex = -1;
        }
        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = false;
                string message = "";
                if (this.testListView.Items.Count == 0 || this.apptComboBox.SelectedIndex == -1)
                {
                    message += "Test and/or appointment date was not selected";
                    MessageBox.Show(message, "Missing Information");
                }
                else
                {
                    foreach (ListViewItem item in this.testListView.Items)
                    {
                        if (item.Checked)
                        {
                            LabTests newLabTest = new LabTests();
                            newLabTest.PatientID = this.pid;
                            newLabTest.AppointmentDate = Convert.ToDateTime(this.apptComboBox.SelectedItem);
                            newLabTest.Code = Convert.ToInt32(item.Name);
                            result = this.labTestController.AddLabTest(newLabTest);
                        }
                    }
                    if (result)
                    {
                        this.ParentForm.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure all of the information is correct" + Environment.NewLine + ex.Message,
                    "Error", MessageBoxButtons.OK);
            }
        }
        private void PopulateComboBox()
        {
            try
            {
                if (this.pid > 0)
                {
                    List<string> dateList = new List<string>();
                    List<Visit> visitsList = this.visitController.GetVisitsByID(this.pid);
                    if (visitsList.Count == 0)
                    {
                        this.messageLabel.Text = "There are no visit dates for that Patient ID";
                        this.apptComboBox.DataSource = null;
                    }
                    else
                    {
                        foreach (Visit v in visitsList)
                        {
                            dateList.Add(v.DateTime.ToString());
                        }

                        this.apptComboBox.DataSource = dateList;
                        this.apptComboBox.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong.  Try again." + Environment.NewLine + ex.Message,
                    "Error", MessageBoxButtons.OK);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (testComboBox.SelectedIndex != 0)
            {
                this.testListView.CheckBoxes = true;
                Test selectedTest = (Test)testComboBox.SelectedItem;
                ListViewItem item = new ListViewItem(selectedTest.Name);
                item.Name = selectedTest.Code.ToString();
                if (!this.testListView.Items.ContainsKey(selectedTest.Code.ToString()))
                {
                    item.Checked = true;
                    this.testListView.Items.Add(item);
                }
            }
        }

    }
}
