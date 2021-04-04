using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class SearchPatientUserControl : UserControl
    {
        public SearchPatientUserControl()
        {
            InitializeComponent();
            searchCriteriaTableLayout.Hide();
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
