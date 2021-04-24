using ClinicSupport.Controller;
using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Form to show Nurse UserControls and options
    /// </summary>
    public partial class NurseDashboard : Form
    {
        private readonly NurseController nurseController;
        private Nurse nurse;

        /// <summary>
        /// 0-parameter constructor for the NurseDashboard Form
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
            nameLabel.Text = "Welcome " + nurse.FirstName + " " + nurse.LastName + "!";
            usernameLabel.Text = "Username:" + user;
        }

        /// <summary>
        /// Method to set the User to a nurse object
        /// </summary>
        /// <param name="user">The currently logged in user</param>
        public void SetNurse(string user)
        {
            nurse = nurseController.GetNurseByUsername(user);
            visitInformationUserControl1.Nurse = nurse;
            visitInformationUserControl2.Nurse = nurse;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
        }
    }
}
