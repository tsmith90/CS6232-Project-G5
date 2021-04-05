
using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class NewAppointmentForm : Form
    {
        public int _currentPatientID { get; set; }

        public NewAppointmentForm()
        {
            InitializeComponent();
        }
    }
}
