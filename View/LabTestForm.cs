
using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class LabTestForm : Form
    {
        public LabTestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the patient appointment LabTests for input fields of the form
        /// </summary>
        /// <param name="patientID">PatientID whose information is to be displayed on the user control input fields</param>
        /// <param name="apptTime">The apptTime for getting the labtests</param>
        public void SetAppointmentTest(Appointment _appt)
        {
            viewLabTestByApptAndPIdUserControl1.SetAppointmentTest(_appt);
        }
    }
}
