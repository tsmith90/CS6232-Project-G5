using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicSupport.Controller;
using ClinicSupport.Model;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// Usercontrol to add tests which need to be ordered
    /// </summary>
    public partial class OrderTestUserControl : UserControl
    {
        private LabTestController labTestController;
        private TestController testController;
        private Appointment appointment;
        private PatientController patientController;
        private IndividualController individualController;
        private int pid;
        private LabTests labTest;
        private Individual individual;

        /// <summary>
        /// 0-parameter constructor for OrderTestUserControl
        /// </summary>
        public OrderTestUserControl()
        {
            InitializeComponent();
            testController = new TestController();
            labTestController = new LabTestController();
            this.patientController = new PatientController();
            this.individualController = new IndividualController();
            this.appointment = new Appointment();
            this.individual = new Individual();
            SetTests();
        }

        private void OrderTestUserControlOrderTestUserControl_Load(object sender, System.EventArgs e)
        {
            if (this.pid > 0)
            {
                Patient patient = this.patientController.GetPatientByID(this.pid);
                this.individual = this.individualController.GetIndividualByID(patient.IndividualID);
                this.titleLabel.Text = "Order new Lab Test for " + this.individual.FirstName + " " + this.individual.LastName;
            }
        }

        /// <summary>
        /// Hides all the fields that are not needed when adding a test
        /// </summary>
        public void ForOrderingTests()
        {
            dateTakenLabel.Visible = false;
            dateTakenTextBox.Visible = false;
            dateReturnedLabel.Visible = false;
            dateReturnedTextBox.Visible = false;
            resultLabel.Visible = false;
            resultTextArea.Visible = false;
            normalLabel.Visible = false;
            normalGroupBox.Visible = false;
            updateTestButton.Visible = false;
        }

        /// <summary>
        /// Hides the Order button, and set the combo box to read only since those things are needed for updating a test
        /// </summary>
        public void ForUpdatingTests(LabTests test)
        {
            if(test != null)
            {
                this.labTest = test;
                Patient patient = this.patientController.GetPatientByID(test.PatientID);
                this.individual = this.individualController.GetIndividualByID(patient.IndividualID);
                this.titleLabel.Text = "Edit Lab Test for " + this.individual.FirstName + " " + this.individual.LastName;

                testComboBox.SelectedValue = test.Code;
                dateTakenTextBox.Text = test.DateTaken.ToString();
                dateReturnedTextBox.Text = test.DateReturned.ToString();
                resultTextArea.Text = test.Result;
                if(test.Normal > 0)
                {
                    yesRadioButton.Checked = true;
                    noRadioButton.Checked = false;
                }
                else
                {
                    noRadioButton.Checked = true;
                    yesRadioButton.Checked = false;
                }
            }
            orderTestTitleLabel.Text = "Edit Lab Test";
            testOrderLabel.Text = "Test ordered:";
            testComboBox.Enabled = false;
            normalLabel.Visible = true;
            normalGroupBox.Visible = true;
            orderTestButton.Visible = false;
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
                string message = "";
                if (this.testComboBox.SelectedIndex == -1)
                {
                    message += "Test was not selected";
                    MessageBox.Show(message, "Missing Information");
                }
                else
                {
                    LabTests newLabTest = new LabTests();
                    newLabTest.PatientID = this.appointment.PatientID;
                    newLabTest.AppointmentDate = this.appointment.Time;
                    Test selectedTest = (Test)testComboBox.SelectedItem;
                    newLabTest.Code = selectedTest.Code;
                    var result = this.labTestController.AddLabTest(newLabTest);
                    if (result)
                    {
                        this.messageLabel.Text = "Lab test has been added";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure all of the information is correct" + Environment.NewLine + ex.Message,
                    "Error", MessageBoxButtons.OK);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }

        private void UpdateTestButton_Click(object sender, EventArgs e)
        {
            if(this.labTest != null)
            {
                try
                {
                    LabTests newLabTest = new LabTests();
                    newLabTest.PatientID = this.labTest.PatientID;
                    newLabTest.AppointmentDate = this.labTest.AppointmentDate;
                    newLabTest.Code = (int)testComboBox.SelectedValue;
                    newLabTest.Result = this.resultTextArea.Text;
                    newLabTest.Normal = Convert.ToInt32(this.yesRadioButton.Checked);
                    newLabTest.DateTaken = Convert.ToDateTime(this.dateTakenTextBox.Text);
                    newLabTest.DateReturned = Convert.ToDateTime(this.dateReturnedTextBox.Text);

                    bool success = this.labTestController.UpdateLabTest(newLabTest, this.labTest);
                    if (success)
                    {
                        this.ParentForm.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update LabTest at this time." + Environment.NewLine + ex.Message,
                        "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
