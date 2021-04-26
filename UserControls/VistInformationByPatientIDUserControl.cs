
using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class VistInformationByPatientIDUserControl : UserControl
    {
        private readonly VisitController visitController;
        private readonly IndividualController individualController;
        private readonly PatientController patientController;
        private int patientID;

        public VistInformationByPatientIDUserControl()
        {
            InitializeComponent();
            this.visitController = new VisitController();
            this.individualController = new IndividualController();
            this.patientController = new PatientController();
        }

        /// <summary>
        /// Sets the patient information to the various input fields of the form
        /// </summary>
        /// <param name="patientID">Patient whose information is to be displayed on the user control input fields</param>
        public void SetVisit(int patientID)
        {
            if (patientID > 0)
            {
                this.patientID = patientID;
                this.GetVisitInfo(patientID);
            }
        }

        private void GetVisitInfo(int patientID)
        {
            List<Visit> visitsList = new List<Visit>();
            try
            {
                Patient _patient = this.patientController.GetPatientByID(patientID);
                if (_patient.IndividualID > 0)
                {
                    Individual _individual = this.individualController.GetIndividualByID(_patient.IndividualID);
                    if (_individual != null)
                    {
                        this.messageLabel.Text = "Viist Information for: " + _individual.LastName + " " + _individual.FirstName;
                    }
                }
                visitsList = this.visitController.GetVisitsByID(patientID);

                if (visitsList.Count > 0)
                {
                    visitDataGridView.DataSource = visitsList;
                    
                }
                else
                {
                    messageLabel.Text = "There are no visits for this Patient ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.OK;
        }
    }
}
