using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    public partial class ViewUpdateNurseUserControl : UserControl
    {
        public ViewUpdateNurseUserControl()
        {
            InitializeComponent();
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
