using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// Usercontrol to update lab tests
    /// </summary>
    public partial class UpdateLabTestUserControl : UserControl
    {
        /// <summary>
        /// 0-parameter constructor for UpdateLabTestUserControl
        /// </summary>
        public UpdateLabTestUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the Lab test to be used in the order test user control
        /// </summary>
        public void SetLabTest(LabTests test)
        {
            orderTestUserControl1.ForUpdatingTests(test);
        }
    }
}
