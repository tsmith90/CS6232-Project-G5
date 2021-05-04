using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form to work with Lab Tests
    /// </summary>
    public partial class LabTestForm : Form
    {
        /// <summary>
        /// 0-parameter constructor for the LabTestForm
        /// </summary>
        public LabTestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the appointment test time and user control information
        /// </summary>
        /// <param name="appointment">The appointment time for getting the labtests</param>
        public void SetAppointmentTest(Appointment appointment)
        {
            viewLabTestByApptAndPIdUserControl1.SetAppointmentTest(appointment);
        }
    }
}
