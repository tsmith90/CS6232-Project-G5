using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Class Form to show Nurse UserControls and options
    /// </summary>
    public partial class NurseDashboard : Form
    {
        private NewOrEditPatientInformation newOrEditPatientInformation;
        /// <summary>
        /// 0-parameter constructor for the NurseDashboard class
        /// </summary>
        public NurseDashboard()
        {
            InitializeComponent();
            newOrEditPatientInformation = new NewOrEditPatientInformation();
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

        private void NewPatientButton_Click(object sender, System.EventArgs e)
        {
            newOrEditPatientInformation.ShowDialog();
        }
    }
 
}
