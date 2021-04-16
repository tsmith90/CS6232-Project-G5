using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class UpdateNursePasswordUserControl : UserControl
    {
        private Nurse nurse;
        private readonly NurseController nurseController;
        private readonly LoginController loginController;

        public UpdateNursePasswordUserControl()
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
            confirmPasswordTextbox.ReadOnly = true;
            updateLoginButton.Enabled = false;
        }

        private void OpenControls()
        {
            newPasswordTextbox.ReadOnly = false;
            confirmPasswordTextbox.ReadOnly = false;
            updateLoginButton.Enabled = true;
        }

        public void ClearControls()
        {
            findUserTextbox.Text = "";
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
            if (string.IsNullOrEmpty(newPasswordTextbox.Text) && string.IsNullOrEmpty(confirmPasswordTextbox.Text)) 
            {
                errorLabel.Text = "Please enter a valid update for the password";
            }
            else if (!newPasswordTextbox.Text.Equals(confirmPasswordTextbox.Text))
            {
                errorLabel.Text = "The passwords do not match";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to update this user password?", "Confirm Password Update", MessageBoxButtons.YesNo);
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
            string password = confirmPasswordTextbox.Text;
            
            if(loginController.SetLoginInformation(username, password))
            {
                errorLabel.Text = "Nurse's password was successfully updated";
            }
            else
            {
                errorLabel.Text = "Nurse's password was not updated";
            }
        }
    }
}
