using System.Windows.Forms;

namespace ClinicSupport.View
{
    public partial class NurseDashboard : Form
    {

        public NurseDashboard()
        {
            InitializeComponent();
        }

        public void SetUsername(string user)
        {
            nameLabel.Text = user;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
        }
    }
 
}
