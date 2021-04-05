using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class ViewPatientAppointmentForm : Form
    {
        public int _currentPatientID { get; set; }

        public ViewPatientAppointmentForm()
        {
            InitializeComponent();
            _currentPatientID = this.viewAppointmentsByPatientIDUserControl1.GetCurrentPatientID();
        }

    }
}
