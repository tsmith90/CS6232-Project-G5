using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class AddLabTestUserControl : UserControl
    {
        public AddLabTestUserControl()
        {
            InitializeComponent();
            orderTestUserControl1.ForOrderingTests();
        }

        /// <summary>
        /// sets the patient and appointment for ordering a test
        /// </summary>
        /// <param name="_appt">Appointment object used to obtain the patientID and apptDate</param>
        public void SetPatientAndAppointment(Appointment _appt)
        {
            orderTestUserControl1.SetPatientAndAppointment(_appt);
        }
    }
}
