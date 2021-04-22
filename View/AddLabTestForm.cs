using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form to add lab tests and results
    /// </summary>
    public partial class AddLabTestForm : Form
    {
        /// <summary>
        /// 0-parameter constructor for AddLabTestForm
        /// </summary>
        public AddLabTestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// sets the patient and appointment for ordering a test
        /// </summary>
        /// <param name="_appt">Appointment object used to obtain the patientID and apptDate</param>
        public void SetPatientAndAppointment(Appointment _appt)
        {
            addLabTestUserControl1.SetPatientAndAppointment(_appt);
        }

        /// <summary>
        /// sets the patient and appointment for ordering a test
        /// </summary>
        /// <param name="_appt">Appointment object used to obtain the patientID and apptDate</param>
        public void SetPatient(int pid)
        {
            addLabTestUserControl1.SetPatient(pid);
        }
    }
}
