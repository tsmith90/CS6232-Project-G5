using ClinicSupport.Controller;
using ClinicSupport.Model;
using ClinicSupport.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class ViewLabTestByApptAndPIdUserControl : UserControl
    {
        private Appointment appointment;
        private int pid;
        private List<LabTests> labTestList;
        private readonly LabTestController labTestController;
        private readonly PatientController patientController;
        private readonly IndividualController individualController;

        public ViewLabTestByApptAndPIdUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.patientController = new PatientController();
            this.individualController = new IndividualController();
            this.labTestList = new List<LabTests>();
            this.appointment = new Appointment();
        }

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
                    Patient patient = this.patientController.GetPatientByID(this.pid);
                    Individual individual = this.individualController.GetIndividualByID(patient.IndividualID);
                    this.titleLabel.Text = "View LabTest(s) for " + individual.FirstName + " " + individual.LastName;

                    this.labTestList = this.labTestController.GetLabTestsByPatientID(this.pid);

                    this.labTestsDataGridView.DataSource = this.labTestList;
                    this.orderTestButton.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
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
        }
    }
}
