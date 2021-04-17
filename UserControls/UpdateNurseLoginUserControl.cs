using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to update a nurse password in the DB
    /// </summary>
    public partial class UpdateNurseLoginUserControl : UserControl
    {
        private Nurse nurse;
        private readonly NurseController nurseController;
        private readonly LoginController loginController;

        /// <summary>
        /// 0-parameter constructor for UpdateNursePasswordUserControl
        /// </summary>
        public UpdateNurseLoginUserControl()
        {
            InitializeComponent();
            SetControls();
            nurse = new Nurse();
            nurseController = new NurseController();
            loginController = new LoginController();
        }

        private void FindUserButton_Click(object sender, System.EventArgs e)
        {
            string name = findUserTextbox.Text;

            nurse = nurseController.GetNurseByUsername(name);

            if (nurse.IndividualID != 0)
            {
                OpenControls();
            }
            else
            {
                ClearControls();
                SetControls();
                errorLabel.Text = "Sorry, that isn't a registered nurse";
            }
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void SetControls()
        {
            newPasswordTextbox.ReadOnly = true;
            newUsernameTextbox.ReadOnly = true;
            confirmPasswordTextbox.ReadOnly = true;
            updateLoginButton.Enabled = false;
        }

        private void OpenControls()
        {
            newPasswordTextbox.ReadOnly = false;
            newUsernameTextbox.ReadOnly = false;
            confirmPasswordTextbox.ReadOnly = false;
            updateLoginButton.Enabled = true;
        }

        /// <summary>
        /// Clears the current controls' content
        /// </summary>
        public void ClearControls()
        {
            findUserTextbox.Text = "";
            newUsernameTextbox.Text = "";
            newPasswordTextbox.Text = "";
            confirmPasswordTextbox.Text = "";
            errorLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            findUserTextbox.Text = nurse.Username;
        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newUsernameTextbox.Text) && string.IsNullOrEmpty(newPasswordTextbox.Text) && string.IsNullOrEmpty(confirmPasswordTextbox.Text)) 
            {
                errorLabel.Text = "Please enter a valid update";
            }
            else if (string.IsNullOrEmpty(newUsernameTextbox.Text) || string.IsNullOrEmpty(newPasswordTextbox.Text) || string.IsNullOrEmpty(confirmPasswordTextbox.Text))
            {
                errorLabel.Text = "Please enter a valid update";
            }
            else if (!newPasswordTextbox.Text.Equals(confirmPasswordTextbox.Text))
            {
                errorLabel.Text = "The passwords do not match";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to update this user?", "Confirm Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        UpdateNurse();
                    }
                    catch (Exception ex)
                    {
                        errorLabel.Text = ex.Message;
                    }
                }
                else
                {
                    errorLabel.Text = "Please correct any errors";
                }
            }
        }

        private void UpdateNurse()
        {
            string username = nurse.Username;
            string newUsername = newUsernameTextbox.Text;
            string password = confirmPasswordTextbox.Text;
            
            if(loginController.SetLoginInformation(username, newUsername, password))
            {
                errorLabel.Text = "Nurse's Login was successfully updated";
            }
            else
            {
                errorLabel.Text = "Nurse's Login was not updated";
            }
        }
    }
}
