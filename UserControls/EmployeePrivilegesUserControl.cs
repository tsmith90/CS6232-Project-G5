using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// UserControl to retrieve and update information about Employee privileges 
    /// </summary>
    public partial class EmployeePrivilegesUserControl : UserControl
    {
        /// <summary>
        /// 0-parameter constructor for EmployeePrivilegesUserControl
        /// </summary>
        public EmployeePrivilegesUserControl()
        {
            InitializeComponent();
            SetControls();
        }

        private void SetControls()
        {
            updateButton.Enabled = false;
            privilegesComboBox.Enabled = false;
        }

        private void OpenControls()
        {
            updateButton.Enabled = true;
            privilegesComboBox.Enabled = true;
        }

        private void FindUserButton_Click(object sender, System.EventArgs e)
        {
            User user = new User();
            user.Username = usernameTextBox.Text;


        }
    }
}
