using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSupport.Controller;
using ClinicSupport.Model;

namespace ClinicSupport.UserControls
{
    public partial class OrderTestUserControl : UserControl
    {
        private TestController testController;
        public OrderTestUserControl()
        {
            InitializeComponent();
            testController = new TestController();
            SetTests();
        }

        /// <summary>
        /// Hides all the fields that are not needed when adding a test
        /// </summary>
        public void ForOrderingTests()
        {
            dateTakenLabel.Visible = false;
            dateTakenTextBox.Visible = false;
            dateReturnedLabel.Visible = false;
            dateReturnedTextBox.Visible = false;
            resultLabel.Visible = false;
            resultTextArea.Visible = false;
            normalLabel.Visible = false;
            yesRadioButton.Visible = false;
            updateTestButton.Visible = false;
        }

        /// <summary>
        /// Hides the Order button, and set the combo box to read only since those things are needed for updating a test
        /// </summary>
        public void ForUpdatingTests()
        {
            testOrderLabel.Text = "Test ordered:";
            testComboBox.Enabled = false;
            orderTestButton.Visible = false;
        }

        private void SetTests()
        {
            List<Test> tests = testController.GetTests();

            testComboBox.DataSource = tests;
            testComboBox.DisplayMember = "name";
            testComboBox.SelectedIndex = -1;
        }
    }
}
