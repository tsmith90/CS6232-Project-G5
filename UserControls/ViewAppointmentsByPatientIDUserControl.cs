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
        private int patientID;
        private List<Appointment> appointmentList;
        private readonly AppointmentController appointmentController;
        private readonly PatientController patientController;
        private NewAppointmentForm apptForm;

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
            
        }
        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patientID">Patient whose information is to be displayed on the user control input fields</param>
        public void SetAppointment(int patientID)
        {
            if(patientID > 0)
            {
                this.patientID = patientID;
                this.GetPatientData(patientID);
            }
        }


        private void GetPatientData(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentNullException("patientID cannot be a negative number");
            }
            try
            {
                this.appointmentList = this.appointmentController.GetAppointmentsByPID(patientID);
                this.appointmentDataGridView.DataSource = this.GetAppointmentTable();
                this.appointmentDataGridView.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private DataTable GetAppointmentTable()
        {
            DataTable apptDataTable = new DataTable();
            apptDataTable.Columns.Add("Patient ID", typeof(string));
            apptDataTable.Columns.Add("Doctor ID", typeof(string));
            apptDataTable.Columns.Add("Reason", typeof(string));
            apptDataTable.Columns.Add("Appointment Time", typeof(DateTime));
            apptDataTable.Columns.Add("Action", typeof(string));

            foreach (Appointment appt in this.appointmentList)
            {
                if (appt.Time > DateTime.Now.AddHours(24))
                {
                    apptDataTable.Rows.Add(appt.PatientID, appt.DoctorID, appt.Reason, appt.Time, "Edit");
                }
                else
                    apptDataTable.Rows.Add(appt.PatientID, appt.DoctorID, appt.Reason, appt.Time, "View");
            }
            return apptDataTable;
        }

        private void AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string text = appointmentDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //edit column 
            if (text == "Edit" || text == "View")
            {
                this.messageLabel.Text = "";
                this.messageLabel.ForeColor = Color.Black;
                var pid = Convert.ToInt32(appointmentDataGridView.Rows[e.RowIndex].Cells[0].Value);
                var did = Convert.ToInt32(appointmentDataGridView.Rows[e.RowIndex].Cells[1].Value);
                var reason = Convert.ToString(appointmentDataGridView.Rows[e.RowIndex].Cells[2].Value);
                var time = Convert.ToDateTime(appointmentDataGridView.Rows[e.RowIndex].Cells[3].Value);
                Appointment _appt = new Appointment();
                _appt.DoctorID = did;
                _appt.PatientID = pid;
                _appt.Reason = reason;
                _appt.Time = time;
                
                this.apptForm = new NewAppointmentForm();
                this.apptForm.SetAppointment(_appt);
                DialogResult result = this.apptForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (text == "Edit") { 
                        string message = "The Appointment have been updated!";
                        this.messageLabel.Text = message;
                        this.messageLabel.ForeColor = Color.Black;
                    }
                    this.GetPatientData(this.patientID);
                }
                else if (result == DialogResult.Abort)
                {
                    string message = "Unable to update the Appointment at this time!";
                    this.messageLabel.Text = message;
                    this.messageLabel.ForeColor = Color.Red;
                }
            }
        }

        private void NewApptButton_Click(object sender, EventArgs e)
        {
            this.messageLabel.Text = "";
            this.messageLabel.ForeColor = Color.Black;

            Appointment _appt = new Appointment();
            _appt.PatientID = this.patientID;
            this.apptForm = new NewAppointmentForm();
            this.apptForm.SetAppointment(_appt);
            DialogResult result = this.apptForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.GetPatientData(this.patientID);
            }
        }
    }
}
