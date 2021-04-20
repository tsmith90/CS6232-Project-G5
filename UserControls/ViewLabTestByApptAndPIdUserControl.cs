using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to view lab tests by appointment and patient id
    /// </summary>
    public partial class ViewLabTestByApptAndPIdUserControl : UserControl
    {
        private Appointment appointment;
        private List<LabTests> labTestList;
        private readonly LabTestController labTestController;
        private readonly PatientController patientController;
        private readonly IndividualController individualController;

        /// <summary>
        /// 0-parameter constructor for ViewLabTestByApptAndPIdUserControl
        /// </summary>
        public ViewLabTestByApptAndPIdUserControl()
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.patientController = new PatientController();
            this.individualController = new IndividualController();
            this.appointment = new Appointment();
        }

        /// <summary>
        /// Method to set appointment tests
        /// </summary>
        /// <param name="_appt">The appointment to be set or changed</param>
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
                Individual indv = this.individualController.GetIndividualByID(patient.IndividualID);
                this.titleLabel.Text = "View LabTest(s) for " + indv.FirstName + " " + indv.LastName + " for appointment date: " + _appt.Time;

                this.labTestList = this.labTestController.GetLabTestsByPatientID(_appt.PatientID, _appt.Time);
                labTestsDataGridView.DataSource = this.labTestList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.OK;
        }
    }
}
