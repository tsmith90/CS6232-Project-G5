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
    public partial class TestReportUserControl : UserControl
    {
        public TestReportUserControl()
        {
            InitializeComponent();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FindReportbutton_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime("01/01/1999");
            DateTime end = Convert.ToDateTime("12/01/2021");

            errorLabel.Text = "start";

            this.getMostPerformedTestsDuringDatesTableAdapter.Fill(this.testsPerformedDataSet.getMostPerformedTestsDuringDates, start, end);
            this.reportViewer1.RefreshReport();
        }
    }
}
