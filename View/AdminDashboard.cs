using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        public void SetUsername(string user)
        {
            nameLabel.Text = user;
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
        }
    }
}
