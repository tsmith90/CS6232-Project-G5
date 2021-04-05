using System;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// Usercontrol to search patient information in the Nurse Dashboard
    /// </summary>
    public partial class SearchPatientUserControl : UserControl
    {
        /// <summary>
        /// 0-parameter constructor for the SearchPatientUserControl
        /// </summary>
        public SearchPatientUserControl()
        {
            InitializeComponent();
            searchCriteriaTableLayout.Hide();
           //patientInformationUserControl1.Hide();
            patientInformationUserControl1.HideNewButton();
        }

        private void SearchDOBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchCriteriaTableLayout.Show();
            dobTextField.Show();
            searchDOBButton.Show();
            firstLastNameTextBox.Hide();
            searchNameButton.Hide();
            dobLastNameTextBox.Hide();
            searchDOBAndLastNameButton.Hide();
        }

        private void SearchFirstLastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchCriteriaTableLayout.Show();
            dobTextField.Hide();
            searchDOBButton.Hide();
            firstLastNameTextBox.Show();
            searchNameButton.Show();
            dobLastNameTextBox.Hide();
            searchDOBAndLastNameButton.Hide();
        }

        private void SearchDOBLastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchCriteriaTableLayout.Show();
            dobTextField.Hide();
            searchDOBButton.Hide();
            firstLastNameTextBox.Hide();
            searchNameButton.Hide();
            dobLastNameTextBox.Show();
            searchDOBAndLastNameButton.Show();
        }
    }
}
