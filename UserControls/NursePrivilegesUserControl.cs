using ClinicSupport.Controller;
using ClinicSupport.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to retrieve and update information about Employee privileges 
    /// </summary>
    public partial class NursePrivilegesUserControl : UserControl
    {
        private readonly NurseController nurseController;
        private Nurse nurse;

        /// <summary>
        /// 0-parameter constructor for EmployeePrivilegesUserControl
        /// </summary>
        public NursePrivilegesUserControl()
        {
            InitializeComponent();
            nurseController = new NurseController();
            nurse = new Nurse();
            CloseControls();
        }

        /// <summary>
        /// method to set controls to readonly
        /// </summary>
        public void CloseControls()
        {
            updateButton.Enabled = false;
            privilegesComboBox.Enabled = false;
        }

        /// <summary>
        /// method to clear controls' content
        /// </summary>
        public void ClearControls()
        {
            privilegesComboBox.DataSource = null;
            usernameTextBox.Text = "";
            errorLabel.Text = "";
        }

        private void OpenControls()
        {
            updateButton.Enabled = true;
            privilegesComboBox.Enabled = true;
        }

        private void SetComboBox()
        {
            List<string> privileges = new List<string>
            {
                "Active",
                "Inactive"
            };

            privilegesComboBox.DataSource = privileges;

            if (nurse.Privilege.Equals("Nurse"))
            {
                privilegesComboBox.SelectedItem = "Active";
            }
            else
            {
                privilegesComboBox.SelectedItem = "Inactive";
            }
        }

        private void FindUserButton_Click(object sender, System.EventArgs e)
        {
            string name = usernameTextBox.Text;

            nurse = nurseController.GetNurseByUsername(name);

            if (nurse.IndividualID != 0)
            {
                OpenControls();
                SetComboBox();
            }
            else
            {
                privilegesComboBox.DataSource = null;
                CloseControls();
                errorLabel.Text = "Sorry, that isn't a registered nurse";
            }
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            string privilege = privilegesComboBox.Text;
            
            if (privilege.Equals("Active"))
            {
                nurse.Privilege = "Nurse";
                UpdateNurse();
            }
            else
            {
                nurse.Privilege = "Inactive";
                UpdateNurse();
            }
        }

        private void UpdateNurse()
        {
            try
            {
                if (nurseController.UpdateNurse(nurse))
                {
                    errorLabel.Text = "Nurse privilege was updated";
                }
                else
                {
                    errorLabel.Text = "Nurse privilege was not updated";
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
