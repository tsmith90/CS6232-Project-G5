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
        private NurseController nurseController;
        private Nurse nurse;

        /// <summary>
        /// 0-parameter constructor for the NurseDashboard class
        /// </summary>
        public NurseDashboard()
        {
            InitializeComponent();
            nurseController = new NurseController();
        }

        /// <summary>
        /// Method to set the userLabel upon login
        /// </summary>
        /// <param name = "user">the name of the user</param> 
        public void SetUsername(string user)
        {
            nameLabel.Text = "Welcome Nurse " + user + "!";
        }

        public void SetNurse(string user)
        {
            nurse = nurseController.GetNurseByUsername(user);
            this.visitInformationUserControl1.Nurse = nurse;
            this.visitInformationUserControl2.Nurse = nurse;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
        }

        private void NurseDashboardTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 
}
