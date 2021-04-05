using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class AddPatientUserControl : UserControl
    {
        public AddPatientUserControl()
        {
            InitializeComponent();
            patientInformationUserControl1.HideUpdateButton();
        }
    }
}
