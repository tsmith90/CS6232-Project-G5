using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form to create new Appointments in the Nurse Dashboard
    /// </summary>
    public partial class NewAppointmentForm : Form
    {
        public int _currentPatientID { get; set; }

        /// <summary>
        /// 0-parameter constructor for the NewAppointmentForm
        /// </summary>
        public NewAppointmentForm()
        {
            InitializeComponent();
        }
    }
}
