using ClinicSupport.Controller;
using ClinicSupport.Model;
using ClinicSupport.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// Usercontrol to view appointments by Patient id
    /// </summary>
    public partial class ViewAppointmentsByPatientIDUserControl : UserControl
    {
        private Patient patient;
        private List<Appointment> appointmentList;
        private readonly AppointmentController appointmentController;
        private readonly PatientController patientController;
        private NewAppointmentForm _patientAppointmentForm;

        /// <summary>
        /// 0-parameter constructor for ViewAppointmentsByPatientIDUserControl
        /// </summary>
        public ViewAppointmentsByPatientIDUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.patientController = new PatientController();
        }

        private void ViewAppointmentsByPatientIDUserControl_Load(object sender, System.EventArgs e)
        {
            this.dobDateTimePicker.Checked = false;
        }

        private void GetPatientData(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentNullException("patientID cannot be a negative number");
            }

            try
            {
                appointmentList = this.appointmentController.GetAppointmentsByPID(patientID);
                appointmentDataGridView.DataSource = this.GetAppointmentTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string text = appointmentDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //edit column 
            if (text == "Edit"){

                var pid = Convert.ToInt32(appointmentDataGridView.Rows[e.RowIndex].Cells[0].Value);
                var did = Convert.ToInt32(appointmentDataGridView.Rows[e.RowIndex].Cells[1].Value);
                var reason = Convert.ToString(appointmentDataGridView.Rows[e.RowIndex].Cells[2].Value);
                var time = Convert.ToDateTime(appointmentDataGridView.Rows[e.RowIndex].Cells[3].Value);
                Appointment _appt = new Appointment();
                _appt.DoctorID = did;
                _appt.PatientID = pid;
                _appt.Reason = reason;
                _appt.Time = time;

                NewAppointmentForm apptForm = new NewAppointmentForm();
                apptForm.SetAppointment(_appt);
                apptForm.Show();
                appointmentDataGridView.Refresh();
            }
        }

        private void SearchApptButton_Click(object sender, EventArgs e)
        {
            if (this.fnameTextBox.Text == String.Empty || this.lnameTextBox.Text == string.Empty || !this.dobDateTimePicker.Checked)
            {
                string message = "Please enter the required values!!";
                this.messageLabel.Text = message;
                this.messageLabel.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    this.messageLabel.Text = "";
                    this.patient = this.patientController.GetPatientbyNameAndDOB(this.fnameTextBox.Text, this.lnameTextBox.Text, this.dobDateTimePicker.Value);
                    if (this.patient.PatientID > 0)
                    {
                        appointmentDataGridView.DataBindings.Clear();
                        this.GetPatientData(this.patient.PatientID);

                        this.appointmentDataGridView.Visible = true;
                        this.newApptButton.Enabled = true;
                    }
                    else
                    {
                        this.appointmentDataGridView.Visible = false;
                        this.newApptButton.Enabled = false;
                        this.messageLabel.Text = "Cannot find the patient by the provided information!";
                        this.messageLabel.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid inte!!!!" + Environment.NewLine + ex.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private DataTable GetAppointmentTable()
        {
            DataTable apptDataTable = new DataTable();
            apptDataTable.Columns.Add("Patient ID", typeof(string));
            apptDataTable.Columns.Add("Doctor ID", typeof(string));
            apptDataTable.Columns.Add("Reason", typeof(string));
            apptDataTable.Columns.Add("Appointment Time", typeof(string));
            apptDataTable.Columns.Add(" ", typeof(string));

            foreach (Appointment appt in this.appointmentList)
            {
                if (appt.Time > DateTime.Now.AddHours(24))
                {
                    apptDataTable.Rows.Add(appt.PatientID, appt.DoctorID, appt.Reason, appt.Time, "Edit");
                }
                else
                    apptDataTable.Rows.Add(appt.PatientID, appt.DoctorID, appt.Reason, appt.Time, " ");
            }

            return apptDataTable;
        }

        private void NewApptButton_Click(object sender, EventArgs e)
        {
            Appointment _appt = new Appointment();
            _appt.PatientID = this.patient.PatientID;
            this._patientAppointmentForm = new NewAppointmentForm();
            this._patientAppointmentForm.SetAppointment(_appt);

            if (this._patientAppointmentForm.ShowDialog() == DialogResult.OK)
            {
                this.GetPatientData(this.patient.PatientID);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.fnameTextBox.Text = "";
            this.lnameTextBox.Text = "";
        }

        /// <summary>
        /// Method to get current patient by their pid
        /// </summary>
        /// <returns>an int of the patient id</returns>
        public int GetCurrentPatientID()
        {
            if (this.patient != null)
            {
                return this.patient.PatientID;
            }
            else
                return 0;
        }
    }
}
