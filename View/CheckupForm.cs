using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form class to retrieve and fill out check up information
    /// </summary>
    public partial class CheckupForm : Form
    {
        private readonly AppointmentController appointmentController;
        private readonly VisitController visitController;
        private Visit visit;
        private int patientID;

        /// <summary>
        /// 0-parameter constructor for the CheckupForm form
        /// </summary>
        public CheckupForm()
        {
            InitializeComponent();
            patientID = -1;
            appointmentController = new AppointmentController();
            visitController = new VisitController();
            visit = new Visit();
            SetControls();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void GetPatientButton_Click(object sender, EventArgs e)
        {
            patientID = ParseID();

            if (patientID > -1)
            {
                PopulateComboBox();
            }
            else
            {
                errorLabel.Text = "Please enter a valid ID";
                ClearControls();
                checkupButton.Enabled = false;
            }
        }

        private void PopulateComboBox()
        {
            try
            {
                List<string> dateList = new List<string>();
                List<Appointment> appointmentsList = appointmentController.GetAppointmentsByPID(patientID);
                if (appointmentsList.Count == 0)
                {
                    errorLabel.Text = "There are no appointments for that Patient ID";
                    ClearControls();
                } 
                else
                {
                    foreach (Appointment a in appointmentsList)
                    {
                        dateList.Add(a.Time.ToString());
                    }

                    appointmentComboBox.DataSource = dateList;
                    checkupButton.Enabled = true;
                }
            }
            catch (Exception)
            {
                errorLabel.Text = "Please enter a valid ID";
            }
        }

        private int ParseID()
        {
            int id = -1;

            try
            {
                id = Int32.Parse(patientIDTextBox.Text);
            }
            catch (FormatException)
            {
                errorLabel.Text = "Please enter a valid ID";
            }

            return id;
        }

        private void CheckupButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                DateTime dateTime = DateTime.Parse(appointmentComboBox.Text);

                visit = this.visitController.GetVisitByKeys(dateTime, patientID);

                PopulateControls();
            }
            catch (Exception)
            {
                errorLabel.Text = "There is a problem with your validation.";
            }
        }

        private void Form_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            patientIDTextBox.Text = "";
        }

        private void ClearControls()
        {
            appointmentComboBox.DataSource = null;
            checkupButton.Enabled = false;
            nurseTextBox.Text = "";
            weightTextBox.Text = "";
            temperatureTextBox.Text = "";
            systolicTextBox.Text = "";
            diastolicTextBox.Text = "";
            pulseTextBox.Text = "";
            symptomsTextBox.Text = "";
            initialDiagnosisTextBox.Text = "";
            finalDiagnosisTextBox.Text = "";
            SetControls();
        }

        private void SetControls()
        {
            checkupButton.Enabled = false;
            nurseTextBox.ReadOnly = true;
            weightTextBox.ReadOnly = true;
            temperatureTextBox.ReadOnly = true;
            systolicTextBox.ReadOnly = true;
            diastolicTextBox.ReadOnly = true;
            pulseTextBox.ReadOnly = true;
            symptomsTextBox.ReadOnly = true;
            initialDiagnosisTextBox.ReadOnly = true;
            finalDiagnosisTextBox.ReadOnly = true;
        }

        private void OpenControls()
        {
            nurseTextBox.ReadOnly = false;
            weightTextBox.ReadOnly = false;
            temperatureTextBox.ReadOnly = false;
            systolicTextBox.ReadOnly = false;
            diastolicTextBox.ReadOnly = false;
            pulseTextBox.ReadOnly = false;
            symptomsTextBox.ReadOnly = false;
            initialDiagnosisTextBox.ReadOnly = false;
            finalDiagnosisTextBox.ReadOnly = false;
        }

        private void PopulateControls()
        {
            if (visit.NurseID != 0)
            {
                nurseTextBox.Text = visit.NurseID.ToString();
                weightTextBox.Text = visit.Weight.ToString();
                temperatureTextBox.Text = visit.Temperature.ToString();
                systolicTextBox.Text = visit.Systolic.ToString();
                diastolicTextBox.Text = visit.Diastolic.ToString();
                pulseTextBox.Text = visit.Pulse.ToString();
                symptomsTextBox.Text = visit.Symptoms;
                initialDiagnosisTextBox.Text = visit.InitialDiagnosis;
                finalDiagnosisTextBox.Text = visit.FinalDiagnosis;
                OpenControls();
            } 
            else
            {
                errorLabel.Text = "Please enter new visit information";
                OpenControls();
            }
        }
    }
}
