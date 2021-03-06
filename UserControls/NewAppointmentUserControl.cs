﻿using ClinicSupport.Controller;
using ClinicSupport.Model;
using ClinicSupport.View;
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

        public int CurrentPatientID { get; set; }
        private readonly AppointmentController appointmentController;
        private readonly DoctorController doctorController;
        private readonly PatientController patientController;
        private readonly IndividualController individualController;
        private Patient patient;
        private Appointment appointment;
        private bool viewOnlyAppt;

        /// <summary>
        /// 0-parameter constructor for NewAppointmentUserControl
        /// </summary>
        public NewAppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            this.patientController = new PatientController();
            this.individualController = new IndividualController();
            this.FillDoctorComboBox();
            this.datePortionDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.datePortionDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.timePortionDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.timePortionDateTimePicker.CustomFormat = "hh':'mm tt";
            this.timePortionDateTimePicker.ShowUpDown = true;
            this.patient = new Patient();
            this.viewOnlyAppt = false;
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void SetAppointment(Appointment _appt)
        {
            this.FillAppointmentForm(_appt);
        }

        private void FillAppointmentForm(Appointment _appt)
        {
            this.appointment = _appt;
            if (_appt.PatientID > 0)
            {
                this.patient = this.patientController.GetPatientByID(_appt.PatientID);
                if (this.patient.IndividualID > 0)
                {
                    Individual _individual = this.individualController.GetIndividualByID(this.patient.IndividualID);
                    if (_individual != null)
                    {
                        this.lnameTextBox.Text = _individual.LastName;
                        this.fnameTextBox.Text = _individual.FirstName;
                    }
                }

                this.reasonTextBox.Text = _appt.Reason;
                this.docComboBox.SelectedValue = _appt.DoctorID;
                if (_appt.Time != DateTime.MinValue)
                {
                    this.datePortionDateTimePicker.Value = _appt.Time;
                    this.timePortionDateTimePicker.Value = _appt.Time;
                    if(_appt.Time > DateTime.Now.AddHours(24)) { 
                        this.titleLabel.Text = "Update Appointment";
                        this.addAppointmentButton.Text = "Update";
                        this.viewOnlyAppt = false;
                    }
                    else
                    {
                        this.titleLabel.Text = "View Appointment";
                        this.addAppointmentButton.Text = "OK";
                        this.datePortionDateTimePicker.Enabled = false;
                        this.timePortionDateTimePicker.Enabled = false;
                        this.fnameTextBox.ReadOnly = true;
                        this.lnameTextBox.ReadOnly = true;
                        this.reasonTextBox.ReadOnly = true;
                        this.docComboBox.Enabled = false;
                        this.viewOnlyAppt = true;
                        this.deleteButton.Enabled = false;
                    }
                }
                else
                {
                    this.titleLabel.Text = "New Appointment";
                    this.addAppointmentButton.Text = "Add";
                    this.deleteButton.Visible = false;
                    this.deleteButton.Enabled = false;
                    this.visitInfoButton.Enabled = false;
                    this.visitInfoButton.Visible = false;
                }
            }
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            if (!this.viewOnlyAppt)
            {
                try
                {
                    if (this.fnameTextBox.Text == String.Empty || this.lnameTextBox.Text == String.Empty || this.reasonTextBox.Text == String.Empty || this.docComboBox.SelectedIndex == 0 || this.datePortionDateTimePicker.Value == null)
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
                        if (this.reasonTextBox.Text == string.Empty)
                        {
                            message += "\n-Reason for visit is missing";
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
                        var reason = this.reasonTextBox.Text;
                        DateTime apptDateTime = this.datePortionDateTimePicker.Value.Date + DateTime.Parse(this.timePortionDateTimePicker.Value.ToString("HH:mm tt")).TimeOfDay;
                        int apptAvailable = this.appointmentController.CheckAvailability(doctorID, apptDateTime);

                        Appointment newAppointment = new Appointment();
                        newAppointment.PatientID = this.patient.PatientID;
                        newAppointment.DoctorID = doctorID;
                        newAppointment.Time = apptDateTime;
                        newAppointment.Reason = reason;
                        bool apptAdded = false;
                        if (this.appointment.Time != DateTime.MinValue)
                        {
                            Appointment oldAppt = this.appointmentController.GetAppointmentByIDsAndTime(this.appointment.PatientID, this.appointment.DoctorID, this.appointment.Time);
                            if (newAppointment.Time != oldAppt.Time || newAppointment.DoctorID != oldAppt.DoctorID)
                            {
                                if (apptAvailable == 0)
                                {
                                    apptAdded = this.appointmentController.UpdateAppointment(oldAppt, newAppointment);
                                    if (apptAdded)
                                    {
                                        this.ClearForm();
                                        this.ParentForm.DialogResult = DialogResult.OK;
                                    }
                                    else
                                    {
                                        this.ParentForm.DialogResult = DialogResult.Abort;
                                    }
                                }
                                else
                                {
                                    string message = "";
                                    message += "Unable to update appointment.  Conflict with the appointment of the same doctor at the same time";
                                    MessageBox.Show(message, "Conflict Information");
                                }
                            }
                            else
                            {
                                apptAdded = this.appointmentController.UpdateAppointment(oldAppt, newAppointment);
                                if (apptAdded)
                                {
                                    this.ClearForm();
                                    this.ParentForm.DialogResult = DialogResult.OK;
                                }
                                else
                                {
                                    this.ParentForm.DialogResult = DialogResult.Abort;
                                }
                            }
                        }
                        else
                        {
                            if (apptAvailable == 0)
                            {
                                apptAdded = this.appointmentController.InsertNewAppointment(newAppointment);
                                if (apptAdded)
                                {
                                    this.ClearForm();
                                    this.messageLabel.Text = "Appointment is added!";
                                    this.messageLabel.ForeColor = Color.Black;
                                    this.ParentForm.DialogResult = DialogResult.OK;
                                }
                                else
                                {
                                    this.messageLabel.Text = "Unable to add the Appointment at this time!";
                                    this.messageLabel.ForeColor = Color.Red;
                                    this.ParentForm.DialogResult = DialogResult.Abort;
                                }
                            }
                            else
                            {
                                string message = "";
                                message += "Unable to add appointment.  Conflict with the appointment of the same doctor at the same time";
                                MessageBox.Show(message, "Conflict Information");
                            }
                        }
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.ParentForm.DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }

        private void FillDoctorComboBox()
        {
            List<Doctor> doctorList = new List<Doctor>();
            doctorList = this.doctorController.GetAllDoctors();
            Doctor notDoc = new Doctor();
            notDoc.Name = "--Select One--";
            notDoc.DoctorID = 0;
            doctorList.Insert(0, notDoc);
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

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
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

        private void VisitInfoButton_Click(object sender, EventArgs e)
        {
            VisitByPatientIDForm vistForm = new VisitByPatientIDForm();
            vistForm.SetVisit(this.patient.PatientID);
            DialogResult result = vistForm.ShowDialog();
            if (result == DialogResult.OK)
            {
               
            }
            else
            {
                vistForm.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!this.viewOnlyAppt)
            {
                try
                {
                    if(this.appointment != null)
                    {
                        bool success = false;
                        success = this.appointmentController.DeleteAppointment(this.appointment);
                        if (success)
                        {
                            this.ParentForm.DialogResult = DialogResult.Yes;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
