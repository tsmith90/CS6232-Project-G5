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
        public Nurse Nurse { get; set; }
        private readonly VisitController visitController;
        private CheckupForm checkupForm;
        private int id;

        /// <summary>
        /// 0-parameter constructor for the VisitInformationUserControl
        /// </summary>
        public VisitInformationUserControl()
        {
            InitializeComponent();
            visitController = new VisitController();
            id = -1;
        }

        private void PatientIDTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void FindPatientButton_Click(object sender, EventArgs e)
        {
            SetVisits();
        }

        private void SetVisits()
        {
            _ = new List<Visit>();
            visitListView.Items.Clear();
            id = ParseID();
            if (id > 0)
            {
                try
                {
                    List<Visit> visitsList = visitController.GetVisitsByID(id);

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
                        visitListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        visitListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    } 
                    else
                    {
                        errorLabel.Text = "There are no visits for this Patient ID";
                    }
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            } 
            else
            {
                errorLabel.Text = "Please enter a valid patient ID";
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
                errorLabel.Text = "Please enter a patient ID";
            }

            return id;
        }

        private void EnterInformationButton_Click(object sender, EventArgs e)
        {
            if(ParseID() > 0)
            {
                checkupForm = new CheckupForm(ParseID());
            }
            else
            {
                errorLabel.Text = "";
                checkupForm = new CheckupForm();
            }

            checkupForm.SetNurse(Nurse);
            visitListView.Items.Clear();
            checkupForm.ShowDialog();
            SetVisits();
        }
    }
}
