using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to interact and create new appointments in the application
    /// </summary>
    public partial class NewAppointmentUserControl : UserControl
    {
        private readonly AppointmentController appointmentController;
        private readonly DoctorController doctorController;
        private readonly PatientController patientController;
        private readonly IndividualController individualController;
        private readonly Patient patient;
        private readonly Individual individual;

        /// <summary>
        /// 0-parameter constructor for NewAppointmentUserControl
        /// </summary>
        public NewAppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            this.patientController = new PatientController();
            this.FillDoctorComboBox();
            this.datePortionDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.datePortionDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.timePortionDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.timePortionDateTimePicker.CustomFormat = "hh':'mm tt";
            this.timePortionDateTimePicker.ShowUpDown = true;

            //TODO: Placeholder to get patentID
            int pid = 0;
            if(pid > 0)
            {
                this.patient = this.patientController.GetPatientByID(pid);
                if(this.patient.IndividualID > 0)
                {
                    this.individual = this.individualController.GetIndividualByID(this.patient.IndividualID);
                    if(this.individual != null)
                    {
                        this.lnameTextBox.Text = this.individual.LastName;
                        this.fnameTextBox.Text = this.individual.FirstName;
                    }
                }
            }

        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fnameTextBox.Text == String.Empty || this.lnameTextBox.Text == String.Empty || this.docComboBox.SelectedIndex == 0 || this.datePortionDateTimePicker.Value == null)
                {
                    string message = "Please enter the required values!!";
                    if (this.fnameTextBox.Text == String.Empty)
                    {
                        message += "\n-First name is missing";
                    }
                    if (this.lnameTextBox.Text == String.Empty)
                    {
                        message += "\n-Last name is missing";
                    }
                    if (docComboBox.SelectedIndex == 0)
                    {
                        message += "\n-Doctor is not selected";
                    }
                    if (datePortionDateTimePicker.Value == null)
                    {
                        message += "\n-DateTime is not selected";
                    }
                    this.messageLabel.Text = message;
                    this.messageLabel.ForeColor = Color.Red;
                }
                else
                {
                    this.messageLabel.Text = "";
                    var fname = this.fnameTextBox.Text;
                    var lname = this.lnameTextBox.Text;
                    var doctorID = int.Parse(this.docComboBox.SelectedValue.ToString());
                    DateTime apptDateTime = this.datePortionDateTimePicker.Value.Date + this.timePortionDateTimePicker.Value.TimeOfDay;
                    int apptAvailable = this.appointmentController.CheckAvailability(doctorID, apptDateTime);
                    if (apptAvailable == 0)
                    {
                        Appointment newAppointment = new Appointment();
                        newAppointment.PatientID = this.patient.PatientID;
                        newAppointment.DoctorID = doctorID;
                        newAppointment.Time = apptDateTime;
                        //bool apptAdded = this.appointmentController.InsertNewAppointment(newAppointment);
                        bool apptAdded = false;
                        if (apptAdded)
                        {
                            this.ClearForm();
                            this.messageLabel.Text = "Appointment is added!";
                            this.messageLabel.ForeColor = Color.Black;
                        }
                        else
                        {
                            this.messageLabel.Text = "Unable to add the Appointment at this time!";
                            this.messageLabel.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        this.messageLabel.Text = "The Appointment is not available at the selected date and time!";
                        this.messageLabel.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void VisitInfoButton_Click(object sender, EventArgs e)
        {

        }

        private void FillDoctorComboBox()
        {
            List<Doctor> doctorList = new List<Doctor>();
            doctorList = this.doctorController.GetAllDoctors();
            Doctor notDoc = new Doctor();
            notDoc.Name = "--Select One--";
            notDoc.DoctorID = 0;
            doctorList.Insert(0, notDoc);
            //Setup data binding
            this.docComboBox.DataSource = doctorList;
            this.docComboBox.DisplayMember = "Name";
            this.docComboBox.ValueMember = "DoctorID";
        }

        private void ClearForm()
        {
            this.fnameTextBox.Text = "";
            this.lnameTextBox.Text = "";
            this.reasonTextBox.Text = "";
            this.docComboBox.SelectedIndex = 0;
            this.datePortionDateTimePicker.Value = DateTimePicker.MinimumDateTime;
        }

        private void ApptDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var diff = this.timePortionDateTimePicker.Value.TimeOfDay.Minutes % 15;
            if (diff != 0)
            {
                this.timePortionDateTimePicker.Value = this.timePortionDateTimePicker.Value.AddMinutes(15 - diff);
            }
            if (datePortionDateTimePicker.Value == DateTimePicker.MinimumDateTime)
            {
                datePortionDateTimePicker.Value = DateTime.Now;
                datePortionDateTimePicker.Format = DateTimePickerFormat.Custom;
                datePortionDateTimePicker.CustomFormat = " ";
            }
            else
            {
                datePortionDateTimePicker.Format = DateTimePickerFormat.Short;
            }
        }
    }
}
