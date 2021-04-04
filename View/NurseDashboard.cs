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
        public Nurse Nurse { get; set; }

        /// <summary>
        /// 0-parameter constructor for the NurseDashboard class
        /// </summary>
        public NurseDashboard()
        {
            InitializeComponent();
            Nurse = new Nurse();
            nurseController = new NurseController();
        }

        /// <summary>
        /// Method to set the userLabel upon login
        /// </summary>
        /// <param user = "user">the name of the user</param> 
        public void SetUsername(string user)
        {
            nameLabel.Text = "Welcome Nurse " + user + "!";
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
        /// <param name = "nurseUsername">the username of the Nurse</param> 
        public void NurseInformation (string nurseUsername)
        {
            if (nurseUsername == null)
            {
                throw new ArgumentNullException("Please enter valid credentials");
            }

            Nurse = nurseController.GetNurseByUsername(nurseUsername);
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
