using ClinicSupport.Controller;
using ClinicSupport.Model;
using ClinicSupport.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// Usercontrol to view lab tests by pid and appointment date
    /// </summary>
    public partial class ViewLabTestByApptAndPIdUserControl : UserControl
    {
        private Appointment appointment;
        private int pid;
        private List<LabTests> labTestList;
        private readonly LabTestController labTestController;
        private readonly PatientController patientController;
        private readonly AppointmentController appointmentController;
        private readonly IndividualController individualController;

        /// <summary>
        /// 0-parameter constructor for the ViewLabTestByApptAndPIdUserControl
        /// </summary>
        public ViewLabTestByApptAndPIdUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.patientController = new PatientController();
            this.individualController = new IndividualController();
            this.appointmentController = new AppointmentController();
            this.labTestList = new List<LabTests>();
            this.appointment = new Appointment();
        }

        /// <summary>
        /// Method to set appointment tests
        /// </summary>
        /// <param name="_appt">The appointment needed to get the test</param>
        public void SetAppointmentTest(Appointment _appt)
        {
            this.appointment = _appt;
            this.GetPatientLabTestsForAppointment(this.appointment);
        }

        private void ViewAppointmentsByPatientIDUserControl_Load(object sender, System.EventArgs e)
        {
            if (this.appointment != null)
            {
                this.GetPatientLabTestsForAppointment(this.appointment);
            }
        }

        private void GetPatientLabTestsForAppointment(Appointment _appt)
        {
            if (_appt == null)
            {
                throw new ArgumentNullException("Appointment cannot null");
            }
            try
            {
                Patient patient = this.patientController.GetPatientByID(_appt.PatientID);
                Individual individual = this.individualController.GetIndividualByID(patient.IndividualID);
                this.titleLabel.Text = "View LabTest(s) for " + individual.FirstName + " " + individual.LastName + " for appointment date: " + _appt.Time;

                this.labTestList = this.labTestController.GetLabTestsByPatientIDAndAppt(_appt.PatientID, _appt.Time);
                labTestsDataGridView.DataSource = this.labTestList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.pid = ParsePatientID();
            if(this.pid > 0)
            {
                try
                {
                    this.messageLabel.Text = string.Empty;
                    this.labTestsDataGridView.Columns.Clear();
                    this.labTestsDataGridView.DataSource = null;
                    Patient patient = this.patientController.GetPatientByID(this.pid);
                    Individual individual = this.individualController.GetIndividualByID(patient.IndividualID);
                    this.titleLabel.Text = "View LabTest(s) for " + individual.FirstName + " " + individual.LastName;

                    this.labTestList = this.labTestController.GetLabTestsByPatientID(this.pid);

                    this.labTestsDataGridView.DataSource = this.labTestList;
                    this.AddEditColumnToGV();
                    this.orderTestButton.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }

        }

        private void AddEditColumnToGV()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            Editlink.Width = 60;
            this.labTestsDataGridView.Columns.Add(Editlink);
        }


        private void LabTestsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string text = this.labTestsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (text == "Edit") {
                var pid = Convert.ToInt32(labTestsDataGridView.Rows[e.RowIndex].Cells[0].Value);
                var apptDate = Convert.ToDateTime(labTestsDataGridView.Rows[e.RowIndex].Cells[1].Value);
                var code = Convert.ToInt32(labTestsDataGridView.Rows[e.RowIndex].Cells[2].Value);
                var dateTaken = Convert.ToDateTime(labTestsDataGridView.Rows[e.RowIndex].Cells[3].Value);
                var dateReturn = Convert.ToDateTime(labTestsDataGridView.Rows[e.RowIndex].Cells[4].Value);
                var testResult = Convert.ToString(labTestsDataGridView.Rows[e.RowIndex].Cells[5].Value);
                var normal = Convert.ToInt32(labTestsDataGridView.Rows[e.RowIndex].Cells[6].Value);

                LabTests labTest = new LabTests();
                labTest.PatientID = pid;
                labTest.AppointmentDate = apptDate;
                labTest.Code = code;
                labTest.DateTaken = dateTaken;
                labTest.DateReturned = dateReturn;
                labTest.Result = testResult;
                labTest.Normal = normal;

                UpdateLabTestView updateTestForm = new UpdateLabTestView();
                updateTestForm.SetLabTest(labTest);
                DialogResult result = updateTestForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.messageLabel.Text = "LabTest successfully updated!";
                    this.labTestsDataGridView.Columns.Clear();
                    this.labTestsDataGridView.DataSource = null;
                    this.labTestList = this.labTestController.GetLabTestsByPatientID(this.pid);

                    this.labTestsDataGridView.DataSource = this.labTestList;
                    this.AddEditColumnToGV();
                }
                else
                {
                    this.messageLabel.Text = "";
                }
            }
        }

        private int ParsePatientID()
        {
            int id = -1;
            try
            {
                id = Int32.Parse(patientIDTextBox.Text);
            }
            catch (FormatException)
            {
                titleLabel.Text = "Please enter a valid ID";
            }
            return id;
        }

        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            AddLabTestForm orderTest = new AddLabTestForm();
            orderTest.SetPatient(this.pid);
            DialogResult result = orderTest.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.messageLabel.Text = "LabTest successfully ordered!";
                this.labTestsDataGridView.Columns.Clear();
                this.labTestsDataGridView.DataSource = null;
                this.labTestList = this.labTestController.GetLabTestsByPatientID(this.pid);

                this.labTestsDataGridView.DataSource = this.labTestList;
                this.AddEditColumnToGV();
            }
            else
            {
                this.messageLabel.Text = "";
            }
        }
    }
}
