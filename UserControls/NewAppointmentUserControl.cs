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
        private readonly Patient patient;

        /// <summary>
        /// 0-parameter constructor for NewAppointmentUserControl
        /// </summary>
        public NewAppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            //this.FillDoctorComboBox();
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.fnameTextBox.Text == String.Empty || this.lnameTextBox.Text == String.Empty || this.docComboBox.SelectedIndex == 0 || this.apptDateTimePicker.Value == null)
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
                    if (apptDateTimePicker.Value == null)
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
                    var apptDateTime = Convert.ToDateTime(this.apptDateTimePicker.Value.ToString());
                    int apptAvailable = this.appointmentController.CheckAvailability(doctorID, apptDateTime);
                    if (apptAvailable > 0)
                    {
                        Appointment newAppointment = new Appointment();
                        newAppointment.PatientID = this.patient.PatientID;
                        newAppointment.DoctorID = doctorID;
                        newAppointment.Time = apptDateTime;
                        this.appointmentController.InsertNewAppointment(newAppointment);
                        this.ClearForm();
                        this.messageLabel.Text = "Appointment is added!";
                        this.messageLabel.ForeColor = Color.Black;
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
            this.docComboBox.ValueMember = "did";
        }

        private void ClearForm()
        {
            this.fnameTextBox.Text = "";
            this.lnameTextBox.Text = "";
            this.reasonTextBox.Text = "";
            this.docComboBox.SelectedIndex = 0;
            this.apptDateTimePicker.Value = DateTimePicker.MinimumDateTime;
        }

        private void ApptDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (apptDateTimePicker.Value == DateTimePicker.MinimumDateTime)
            {
                apptDateTimePicker.Value = DateTime.Now;
                apptDateTimePicker.Format = DateTimePickerFormat.Custom;
                apptDateTimePicker.CustomFormat = " ";
            }
            else
            {
                apptDateTimePicker.Format = DateTimePickerFormat.Short;
            }
        }

    }
}
