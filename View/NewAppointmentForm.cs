using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form to create new appointments
    /// </summary>
    public partial class NewAppointmentForm : Form
    {

        /// <summary>
        /// 0-parameter constructor for NewAppointmentForm
        /// </summary>
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
