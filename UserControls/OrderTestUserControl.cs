﻿using System;
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
                this.visitDateTextBox.Text = test.AppointmentDate.ToString();
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
                    if (newLabTest.DateTaken < newLabTest.AppointmentDate || newLabTest.DateReturned < newLabTest.AppointmentDate)
                    {
                        string message = "";
                        message += "Test's DateTaken or DateReturned cannot be before visit date!";
                        MessageBox.Show(message, "Incorrect Information");
                    }
                    else
                    {
                        if (newLabTest.DateTaken > newLabTest.DateReturned)
                        {
                            string message = "";
                            message += "Test's DateReturned cannot be before DateTaken!";
                            MessageBox.Show(message, "Incorrect Information");
                        }
                        else
                        {
                            bool success = this.labTestController.UpdateLabTest(newLabTest, this.labTest);
                            if (success)
                            {
                                this.ParentForm.DialogResult = DialogResult.OK;
                            }
                        }
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
