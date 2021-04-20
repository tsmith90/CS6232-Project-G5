﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicSupport.Controller;
using ClinicSupport.Model;

namespace ClinicSupport.UserControls
{
    public partial class OrderTestUserControl : UserControl
    {
        private LabTestController labTestController;
        private TestController testController;
        private Appointment appointment;
        public OrderTestUserControl()
        {
            InitializeComponent();
            testController = new TestController();
            labTestController = new LabTestController();
            appointment = new Appointment();
            normalLabel.Visible = false;
            yesRadioButton.Visible = false;
            SetTests();
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
            yesRadioButton.Visible = false;
            updateTestButton.Visible = false;
        }

        /// <summary>
        /// Hides the Order button, and set the combo box to read only since those things are needed for updating a test
        /// </summary>
        public void ForUpdatingTests()
        {
            orderTestTitleLabel.Text = "Edit Lab Test";
            testOrderLabel.Text = "Test ordered:";
            testComboBox.Enabled = false;
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

        private void SetTests()
        {
            List<Test> tests = testController.GetTests();

            testComboBox.DataSource = tests;
            testComboBox.DisplayMember = "name";
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
    }
}
