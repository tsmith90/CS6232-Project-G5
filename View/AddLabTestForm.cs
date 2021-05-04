using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form to add lab tests and results
    /// </summary>
    public partial class AddLabTestForm : Form
    {
        /// <summary>
        /// 0-parameter constructor for AddLabTestForm
        /// </summary>
        public AddLabTestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the patient for ordering a test
        /// </summary>
        /// <param name="pid">The patient id used to set the patient for appointments</param>
        public void SetPatient(int pid)
        {
            addLabTestUserControl1.SetPatient(pid);
        }
    }
}
