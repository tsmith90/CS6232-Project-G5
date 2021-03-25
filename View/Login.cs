using ClinicSupport.Controller;
using System;
using System.Windows.Forms;

namespace ClinicSupport
{
    /// <summary>
    /// Class to create a Form to be used to login to the Support controls
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly LoginController loginController;

        /// <summary>
        /// 0-parameter constructor for the LoginForm class
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            errorLabel.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string privileges = loginController.GetLoginInformation(user, password);

            if (privileges.Equals("Nurse"))
            {
                errorLabel.Text = "Nurse Logged in";
            }
            else if (privileges.Equals("Admin"))
            {
                errorLabel.Text = "Admin Logged in";
            }
            else if (privileges.Equals("Doctor"))
            {
                //I'm not sure if we need this one or not...
            }
            else
            {
                errorLabel.Text = "Sorry, that user isn't registered.";
            }
        }
    }
}
