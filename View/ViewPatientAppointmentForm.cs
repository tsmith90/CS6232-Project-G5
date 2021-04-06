using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form class to view patient appointments
    /// </summary>
    public partial class ViewPatientAppointmentForm : Form
    {
        public int _currentPatientID { get; set; }

        /// <summary>
        /// 0-parameter constructor for the ViewPatientAppointmentForm
        /// </summary>
        public ViewPatientAppointmentForm()
        {
            InitializeComponent();
            _currentPatientID = this.viewAppointmentsByPatientIDUserControl1.GetCurrentPatientID();
        }

    }
}
