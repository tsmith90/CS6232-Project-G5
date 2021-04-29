using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class DeletePatientForm : Form
    {
        public DeletePatientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the patient ID for Visit information
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void SetPatient(int patinentID)
        {
            if (patinentID > 0)
            {
                deletePatientUserControl1.SetPatient(patinentID);
            }
        }
    }
}
