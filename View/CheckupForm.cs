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
        public void SetNurse(Nurse nurse)
        {
            this.nurse = nurse ?? throw new ArgumentNullException("Please enter a valid nurse");
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            patientIDTextBox.Text = "";
            appointmentComboBox.DataSource = null;
            ClearControls();
            SetControls();
            Hide();
        }

        private void GetPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                patientID = GetInt(patientIDTextBox.Text, "patient ID");
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
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
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


        private void CheckupButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = DateTime.Parse(appointmentComboBox.Text);
                visit = this.visitController.GetVisitByKeys(dateTime, patientID);
                visit.PatientID = patientID;
                visit.DateTime = dateTime;

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
            if (visit.NurseID == 0 && visit.Temperature == 0)
            {
                try
                {
                    Visit firstVisit = ParseVisit();

                    if (visitController.EnterVisit(firstVisit))
                    {
                        errorLabel.Text = "The checkup has been successfully entered";
                    }
                    else
                    {
                        errorLabel.Text = "The checkup wasn't entered. There was an error.";
                    }
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
            else
            {
                try
                {
                    Visit updateVisit = ParseVisit();

                    if (visitController.UpdateVisit(updateVisit))
                    {
                        errorLabel.Text = "The checkup has been successfully updated";
                    }
                    else
                    {
                        errorLabel.Text = "The checkup wasn't updated. There was an error.";
                    }

                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
        }

        private int GetInt(string number, string source)
        {
            try
            {
                int id = -1;
                id = Int32.Parse(number);
                if (id < 0)
                {
                    throw new FormatException();
                }
                return id;
            }
            catch (Exception)
            {
                throw new FormatException("Please enter a valid " + source);
            }
        }
        private decimal GetDecimal(string numbered, string source)
        {
            try
            {
                decimal id = -1;
                id = Decimal.Parse(numbered);
                return id;
            }
            catch (Exception)
            {
                throw new FormatException("Please enter a valid " + source);
            }
        }
        private Visit ParseVisit()
        {
            Visit newVisit = new Visit();
            newVisit.PatientID = visit.PatientID;
            newVisit.DateTime = visit.DateTime;
            newVisit.NurseID = GetInt(nurseTextBox.Text, "Nurse ID");
            newVisit.Weight = GetDecimal(weightTextBox.Text, "weight");
            newVisit.Temperature = GetDecimal(temperatureTextBox.Text, "temperature");
            newVisit.Systolic = GetInt(systolicTextBox.Text, "systolic number");
            newVisit.Diastolic = GetInt(diastolicTextBox.Text, "diastolic number");
            newVisit.Pulse = GetInt(pulseTextBox.Text, "pulse");

            if (symptomsTextBox.Text.Length > 254)
            {
                DialogResult dialogResult = MessageBox.Show("only 254 letters are allowed for symptoms. Would you like to trim to 254?",
                    "The symptoms description is too big!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    newVisit.Symptoms = symptomsTextBox.Text.Substring(0, 253);
                    symptomsTextBox.Text = symptomsTextBox.Text.Substring(0, 253);
                }
                else
                {
                    throw new Exception();
                }
            }
            else if (String.IsNullOrEmpty(symptomsTextBox.Text))
            {
                throw new Exception("Please fill out symptoms");
            }
            else
            {
                newVisit.Symptoms = symptomsTextBox.Text;
            }

            if (initialDiagnosisTextBox.Text.Length > 254)
            {
                DialogResult dialogResult = MessageBox.Show("only 254 letters are allowed for initial diagnosis. Would you like to trim to 254?",
                    "The symptoms description is too big!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    newVisit.InitialDiagnosis = initialDiagnosisTextBox.Text.Substring(0, 253);
                    initialDiagnosisTextBox.Text = initialDiagnosisTextBox.Text.Substring(0, 253);
                }
                else
                {
                    throw new Exception();
                }
            }
            else if (String.IsNullOrEmpty(initialDiagnosisTextBox.Text))
            {
                throw new Exception("Please fill out an initial diagnosis");
            }
            else
            {
                newVisit.InitialDiagnosis = initialDiagnosisTextBox.Text;
            }

            if (finalDiagnosisTextBox.Text.Length > 254)
            {
                DialogResult dialogResult = MessageBox.Show("only 254 letters are allowed for final diagnosis. Would you like to trim to 254?",
                    "The symptoms description is too big!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    newVisit.FinalDiagnosis = finalDiagnosisTextBox.Text.Substring(0, 253);
                    finalDiagnosisTextBox.Text = finalDiagnosisTextBox.Text.Substring(0, 253);
                }
                else
                {
                    throw new Exception();
                }
            }
            else if (String.IsNullOrEmpty(finalDiagnosisTextBox.Text))
            {
                newVisit.FinalDiagnosis = "None currently entered";
            }
            else
            {
                newVisit.FinalDiagnosis = finalDiagnosisTextBox.Text;
            }

            return newVisit;
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
                errorLabel.Text = "Enter new patient checkup information.";
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
