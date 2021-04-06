﻿using ClinicSupport.Model;
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
