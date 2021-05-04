using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form class to view patient appointments
    /// </summary>
    public partial class ViewPatientAppointmentForm : Form
    {
        /// <summary>
        /// 0-parameter constructor for the ViewPatientAppointmentForm
        /// </summary>
        public ViewPatientAppointmentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the appointment information to the various input fields of the form
        /// </summary>
        /// <param name="patientID">Patient whose information is to be displayed on the user control input fields</param>
        public void SetAppointment(int patientID)
        {
            viewAppointmentsByPatientIDUserControl1.SetAppointment(patientID);
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
