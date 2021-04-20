using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class AddLabTestUserControl : UserControl
    {
        public AddLabTestUserControl()
        {
            InitializeComponent();
            orderTestUserControl1.ForOrderingTests();
        }
    }
}
