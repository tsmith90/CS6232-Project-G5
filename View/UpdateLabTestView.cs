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
        /// Sets the patient ID for Visit information
        /// </summary>
        /// <param name="patientID">Patient whose information is to be displayed on the user control input fields</param>
        public void SetLabTest(LabTests test)
        {
            if (test != null)
            {
                updateLabTestUserControl1.SetLabTest(test);
            }
        }
    }
}
