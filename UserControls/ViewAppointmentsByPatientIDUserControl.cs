using ClinicSupport.Controller;
using ClinicSupport.Model;
using ClinicSupport.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// Usercontrol to View Appointments by a given Patient ID in the Nurse Dashboard
    /// </summary>
    public partial class ViewAppointmentsByPatientIDUserControl : UserControl
    {
        private Patient patient;
        private List<Appointment> appointmentList;
        private readonly AppointmentController appointmentController;
        private readonly PatientController patientController;
        private NewAppointmentForm _patientAppointmentForm;

        /// <summary>
        /// 0-parameter constructor for the ViewAppointmentByPatientIDUserControl
        /// </summary>
        public ViewAppointmentsByPatientIDUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.patientController = new PatientController();
        }

        private void ViewAppointmentsByPatientIDUserControl_Load(object sender, System.EventArgs e)
        {
            //this.GetPatientData();
        }

        private void GetPatientData(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentNullException("patientID cannot be a negative number");
            }

            try
            {
                // Get the list of Appointment objects
                // and bind the DataGridView control to the list
                appointmentList = this.appointmentController.GetAppointmentsByPID(patientID);
                appointmentDataGridView.DataSource = appointmentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //edit column 
            if (e.ColumnIndex == 0)
            {
                var pid = Convert.ToInt32(appointmentDataGridView.Rows[e.RowIndex].Cells[2].Value);
                var time = Convert.ToDateTime(appointmentDataGridView.Rows[e.RowIndex].Cells[3].Value);
                var did = Convert.ToInt32(appointmentDataGridView.Rows[e.RowIndex].Cells[4].Value);
                var reason = Convert.ToString(appointmentDataGridView.Rows[e.RowIndex].Cells[5].Value);
                Appointment _appt = new Appointment();
                _appt.DoctorID = did;
                _appt.PatientID = pid;
                _appt.Reason = reason;
                _appt.Time = time;

                ViewPatientAppointmentForm apptForm = new ViewPatientAppointmentForm();
                apptForm.Show();
                appointmentDataGridView.Refresh();
            }
            //delete column
            if (e.ColumnIndex == 1)
            {
                var pid = Convert.ToString(appointmentDataGridView.Rows[e.RowIndex].Cells[2].Value);
                appointmentDataGridView.Refresh();
            }
        }

        private void SearchApptButton_Click(object sender, EventArgs e)
        {
            if (this.fnameTextBox.Text == String.Empty || this.lnameTextBox.Text == string.Empty || !this.dobDateTimePicker.Checked )
            {
                string message = "Please enter the required values!!";
                this.messageLabel.Text = message;
                this.messageLabel.ForeColor = Color.Red;
            }
            try
            {
                this.patient = this.patientController.GetPatientbyNameAndDOB(this.fnameTextBox.Text, this.lnameTextBox.Text, this.dobDateTimePicker.Value);
                if (this.patient.PatientID > 0)
                {
                    this.GetPatientData(this.patient.PatientID);
                    DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                    Editlink.UseColumnTextForLinkValue = true;
                    Editlink.HeaderText = "Edit";
                    Editlink.DataPropertyName = "lnkColumn";
                    Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                    Editlink.Text = "Edit";
                    Editlink.Width = 60;
                    appointmentDataGridView.Columns.Add(Editlink);

                    DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                    Deletelink.UseColumnTextForLinkValue = true;
                    Deletelink.HeaderText = "delete";
                    Deletelink.DataPropertyName = "lnkColumn";
                    Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                    Deletelink.Text = "Delete";
                    Deletelink.Width = 60;
                    appointmentDataGridView.Columns.Add(Deletelink);

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

        private void NewApptButton_Click(object sender, EventArgs e)
        {
            this._patientAppointmentForm = new NewAppointmentForm();
            this._patientAppointmentForm._currentPatientID = this.patient.PatientID;

            if (this._patientAppointmentForm.ShowDialog() == DialogResult.OK)
            {
                this.GetPatientData(this.patient.PatientID);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method to retrieve the current Patient ID
        /// </summary>
        /// <returns>the current Patient ID</returns>
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
