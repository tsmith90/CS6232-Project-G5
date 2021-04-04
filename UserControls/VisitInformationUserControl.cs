using ClinicSupport.Controller;
using ClinicSupport.Model;
using ClinicSupport.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to retrieve information about visits by a given patient
    /// </summary>
    public partial class VisitInformationUserControl : UserControl
    {
        private readonly VisitController visitController;
        private readonly CheckupForm checkupForm;

        /// <summary>
        /// 0-parameter constructor for the VisitInformationUserControl
        /// </summary>
        public VisitInformationUserControl()
        {
            InitializeComponent();
            visitController = new VisitController();
            checkupForm = new CheckupForm();
        }

        private void PatientIDTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void FindPatientButton_Click(object sender, EventArgs e)
        {
            int id = ParseID();
            List<Visit> visitsList = new List<Visit>();
            visitListView.Items.Clear();

            if (id > 0)
            {
                try
                {
                    visitsList = visitController.GetVisitsByID(id);

                    if (visitsList.Count > 0)
                    {
                        Visit visit;

                        for (int i = 0; i < visitsList.Count; i++)
                        {
                            visit = visitsList[i];

                            visitListView.Items.Add(visit.DateTime.ToString());
                            visitListView.Items[i].SubItems.Add(visit.NurseID.ToString());
                            visitListView.Items[i].SubItems.Add(visit.Weight.ToString());
                            visitListView.Items[i].SubItems.Add(visit.Systolic.ToString());
                            visitListView.Items[i].SubItems.Add(visit.Diastolic.ToString());
                            visitListView.Items[i].SubItems.Add(visit.Temperature.ToString());
                            visitListView.Items[i].SubItems.Add(visit.Pulse.ToString());
                            visitListView.Items[i].SubItems.Add(visit.Symptoms);
                            visitListView.Items[i].SubItems.Add(visit.InitialDiagnosis);
                            if (String.IsNullOrEmpty(visit.FinalDiagnosis))
                            {
                                visitListView.Items[i].SubItems.Add("none entered");
                            }
                            else
                            {
                                visitListView.Items[i].SubItems.Add(visit.FinalDiagnosis);
                            }
                        }
                    } 
                    else
                    {
                        errorLabel.Text = "There are no visits for this Patient ID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }  
        }

        private int ParseID()
        {
            int id = -1;

            try
            {
                id = Int32.Parse(patientIDTextBox.Text);
            }
            catch (FormatException)
            {
                errorLabel.Text = "Please enter a valid ID";
            }

            return id;
        }

        private void EnterInformationButton_Click(object sender, EventArgs e)
        {
            checkupForm.ShowDialog();
        }
    }
}
