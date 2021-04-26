
using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class VisitByPatientIDForm : Form
    {
        public VisitByPatientIDForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the patient ID for Visit information
        /// </summary>
        /// <param name="patientID">Patient whose information is to be displayed on the user control input fields</param>
        public void SetVisit(int patientID)
        {
            if (patientID > 0)
            {
                vistInformationByPatientIDUserControl1.SetVisit(patientID);
            }
        }
    }
}
