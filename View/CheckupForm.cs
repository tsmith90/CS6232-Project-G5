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
        private readonly NurseController nurseController;
        private readonly VisitController visitController;
        private Nurse nurse;
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
            nurseController = new NurseController();
            visitController = new VisitController();
            visit = new Visit();
            nurse = new Nurse();
            checkupButton.Enabled = false;
            SetControls();
        }

        /// <summary>
        /// Method to set the Nurse object across forms
        /// </summary>
        /// <param name="name">The name of the Nurse</param>
        public void SetNurse(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Please enter a valid nurse name");
            }

            nurse = nurseController.GetNurseByUsername(name);
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
                SetControls();
                ClearControls();
                checkupButton.Enabled = true;
                PopulateComboBox();
            }
            else
            {
                errorLabel.Text = "Please enter a valid ID";
                SetControls();
                ClearControls();
                appointmentComboBox.DataSource = null;
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
                    appointmentComboBox.DataSource = null;
                    checkupButton.Enabled = false;
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
                checkupButton.Enabled = true;
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
            appointmentComboBox.DataSource = null;
            checkupButton.Enabled = false;
            patientIDTextBox.Text = "";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearControls()
        {
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
            nurseTextBox.ReadOnly = true;
            weightTextBox.ReadOnly = true;
            temperatureTextBox.ReadOnly = true;
            systolicTextBox.ReadOnly = true;
            diastolicTextBox.ReadOnly = true;
            pulseTextBox.ReadOnly = true;
            symptomsTextBox.ReadOnly = true;
            initialDiagnosisTextBox.ReadOnly = true;
            finalDiagnosisTextBox.ReadOnly = true;
            enterButton.Enabled = false;
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
            if (visit.NurseID == nurse.NurseID)
            {
                ClearControls();
                SetTexts();
                OpenControls();
                enterButton.Enabled = true;
            } 
            else if (visit.NurseID == 0)
            {
                ClearControls();
                OpenControls();
                nurseTextBox.Text = nurse.NurseID.ToString();
                nurseTextBox.Enabled = false;
                enterButton.Enabled = true;
                errorLabel.Text = "Enter new visit patient checkup information";
            }
            else
            {
                ClearControls();
                SetTexts();
                SetControls();
                checkupButton.Enabled = true;
                errorLabel.Text = "Only the assigned nurse may make changes.";
            }
        }

        private void SetTexts()
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
        } 
    }
}
