using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Class Form to show Admin UserControls and options
    /// </summary>
    public partial class AdminDashboard : Form
    {
        /// <summary>
        /// 0-parameter constructor for the AdminDashboard class
        /// </summary>
        public AdminDashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to set the userLabel upon login
        /// </summary>
        /// <param name = "user">the name of the user</param> 
        public void SetUsername(string user)
        {
            nameLabel.Text = user;
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
