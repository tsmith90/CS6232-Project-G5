using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class CheckupForm : Form
    {
        private readonly AppointmentController appointmentController;
        private int patientID;

        public CheckupForm()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void GetPatientButton_Click(object sender, EventArgs e)
        {
            patientID = ParseID();

            appointmentComboBox.DataSource = null;

            if (patientID != 0)
            {
                PopulateComboBox();
            }
            else
            {
                errorLabel.Text = "There are no appointments for that Patient ID";
            }
        }

        private void PopulateComboBox()
        {
            try
            {
                List<string> dateList = new List<string>();
                List<Appointment> appointmentsList = appointmentController.GetAppointmentsByPID(patientID);
                if (appointmentsList.Count == 0)
                {
                    errorLabel.Text = "There are no appointments for that Patient ID";
                } 
                else
                {
                    foreach (Appointment a in appointmentsList)
                    {
                        dateList.Add(a.Time.ToString());
                    }

                    appointmentComboBox.DataSource = dateList;
                }
            }
            catch (Exception)
            {
                errorLabel.Text = "Please enter a valid ID";
            }
        }

        private int ParseID()
        {
            int id = 0;

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

        private void CheckupButton_Click(object sender, EventArgs e)
        {

        }

        private void PatientIDTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
