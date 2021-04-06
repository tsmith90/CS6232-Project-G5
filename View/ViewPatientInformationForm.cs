using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class ViewPatientInformationForm : Form
    {
        public ViewPatientInformationForm()
        {
            InitializeComponent();
            patientInformationUserControl1.HideNewButton();
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patient">Patient whose information is to be displayed on the user control input fields</param>
        public void SetPatient(Individual patient)
        {
            patientInformationUserControl1.SetPatient(patient);
        }
    }
}
