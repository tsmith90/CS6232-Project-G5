using System.Windows.Forms;
using ClinicSupport.Model;

namespace ClinicSupport.UserControls
{
    public partial class PatientInformationUserControl : UserControl
    {
        public PatientInformationUserControl()
        {
            InitializeComponent();
        }

        public void HideUpdateButton()
        {
            updateButton.Visible = false;
        }

        public void HideNewButton()
        {
            createPatientButton.Visible = false;
        }

        public void SetPatient(Patient patient)
        {
            
        }
    }
}
