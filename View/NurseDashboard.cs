using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Class Form to show Nurse UserControls and options
    /// </summary>
    public partial class NurseDashboard : Form
    {
        private readonly NurseController nurseController;
        private Nurse nurse;

        /// <summary>
        /// 0-parameter constructor for the NurseDashboard class
        /// </summary>
        public NurseDashboard()
        {
            InitializeComponent();
            nurseController = new NurseController();
            nurse = new Nurse();
        }

        /// <summary>
        /// Method to set the userLabel upon login
        /// </summary>
        /// <param user = "user">the name of the user</param> 
        public void SetUsername(string user)
        {
            nameLabel.Text = "Welcome nurse " + user + "!";
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// Method to set the current Nurse logged into the application
        /// </summary>
        /// <param nurseUsername = "nurseUsername">the username of the Nurse</param> 
        public void SetNurse (string nurseUsername)
        {
            if (nurseUsername == null)
            {
                throw new ArgumentNullException("Please enter valid credentials");
            }

            nurse = nurseController.GetNurseByUsername(nurseUsername);
        }

        private void NurseDashboardTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nurseDashboardTabControl.SelectedTab.Text == "Search Patients")
            {
                this.patientInformationUserControl1.HideNewButton();
            }
            if (nurseDashboardTabControl.SelectedTab.Text == "Add Patient")
            {
                this.patientInformationUserControl1.HideUpdateButton();
            }
        }
    }
 
}
