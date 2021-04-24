using ClinicSupport.Controller;
using ClinicSupport.Model;
using ClinicSupport.View;
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
        private readonly NurseDashboard nurseDashboard;
        private readonly AdminDashboard adminDashboard;

        /// <summary>
        /// 0-parameter constructor for the LoginForm class
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController();
            nurseDashboard = new NurseDashboard();
            adminDashboard = new AdminDashboard();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string privileges = "";
            User newUser = new User();
            string user = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                newUser = loginController.GetLoginInformation(user, password);
                privileges = newUser.Privileges + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            if (privileges.Equals("Nurse"))
            {
                nurseDashboard.SetNurse(newUser.Username);
                nurseDashboard.SetUsername(newUser.Username);
                Hide();
                nurseDashboard.ShowDialog();
                ClearForm();
                Show();
            }
            else if (privileges.Equals("Admin"))
            {
                adminDashboard.SetUsername(newUser.Username);
                Hide();
                adminDashboard.ShowDialog();
                ClearForm();
                Show();
            }
            else
            {
                errorLabel.Text = "Sorry, that user isn't registered.";
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ClearForm()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            errorLabel.Text = "";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
