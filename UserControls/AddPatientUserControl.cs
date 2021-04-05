using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// Usercontrol for adding patients in the Nurse Dashboard
    /// </summary>
    public partial class AddPatientUserControl : UserControl
    {
        /// <summary>
        /// 0-parameter constructor for the AddPatientUserControl
        /// </summary>
        public AddPatientUserControl()
        {
            InitializeComponent();
            patientInformationUserControl1.HideUpdateButton();
        }
    }
}
