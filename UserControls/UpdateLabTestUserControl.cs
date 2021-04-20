using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class UpdateLabTestUserControl : UserControl
    {
        public UpdateLabTestUserControl()
        {
            InitializeComponent();
            orderTestUserControl1.ForUpdatingTests();
        }
    }
}
