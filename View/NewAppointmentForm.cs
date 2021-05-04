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
        /// Sets the appointment information to the various input fields of the new appointment user control
        /// </summary>
        /// <param name="appointment">appointment information to be displayed on the user control input fields</param>
        public void SetAppointment(Appointment appointment)
        {
            newAppointmentUserControl1.SetAppointment(appointment);
        }
    }
}
