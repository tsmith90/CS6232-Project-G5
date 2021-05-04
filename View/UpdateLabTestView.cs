using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form to view and update lab tests
    /// </summary>
    public partial class UpdateLabTestView : Form
    {
        /// <summary>
        /// 0-parameter constructor for UpdateLabTestView
        /// </summary>
        public UpdateLabTestView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the Lab test information
        /// </summary>
        /// <param name="test">the test information used to set a new lab test</param>
        public void SetLabTest(LabTests test)
        {
            if (test != null)
            {
                updateLabTestUserControl1.SetLabTest(test);
            }
        }
    }
}
