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
    public partial class AddPatientUserControl : UserControl
    {
        public AddPatientUserControl()
        {
            InitializeComponent();
            patientInformationUserControl1.HideUpdateButton();
        }
    }
}
