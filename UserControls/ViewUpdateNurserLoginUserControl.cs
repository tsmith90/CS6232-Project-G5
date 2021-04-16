using System;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class ViewUpdateNurserUserControl : UserControl
    {
        public ViewUpdateNurserUserControl()
        {
            InitializeComponent();
            SetControls();
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void SetControls()
        {
            newUsernameTextbox.ReadOnly = true;
            newPasswordTextbox.ReadOnly = true;
            confirmPasswordTextbox.ReadOnly = true;
            updateLoginButton.Enabled = false;
        }

        private void OpenControls()
        {
            newUsernameTextbox.ReadOnly = false;
            newPasswordTextbox.ReadOnly = false;
            confirmPasswordTextbox.ReadOnly = false;
            updateLoginButton.Enabled = true;
        }

        private void ClearControls()
        {
            newUsernameTextbox.Text = "";
            newPasswordTextbox.Text = "";
            confirmPasswordTextbox.Text = "";
            errorLabel.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
