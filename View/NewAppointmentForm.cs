
using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class NewAppointmentForm : Form
    {

        public NewAppointmentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void SetAppointment(Appointment appt)
        {
            newAppointmentUserControl1.SetAppointment(appt);
        }
    }
}
