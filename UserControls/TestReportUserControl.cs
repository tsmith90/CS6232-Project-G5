using System;
using System.Windows.Forms;

namespace ClinicSupport.UserControls
{

    /// <summary>
    /// Usercontrol to generate test reports from LabTests
    /// </summary>
    public partial class TestReportUserControl : UserControl
    {
        /// <summary>
        /// 0-parameter constructor for TestReportUserControl
        /// </summary>
        public TestReportUserControl()
        {
            InitializeComponent();
        }

        private void ReportViewer1_Load(object sender, EventArgs e) { }

        private void FindReportbutton_Click(object sender, EventArgs e)
        {
            DateTime start = startDateTimePicker.Value;
            DateTime end = endDateTimePicker.Value;

            if (start <= end)
            {
                _ = this.getMostPerformedTestsDuringDatesTableAdapter.Fill(this.testsPerformedDataSet.getMostPerformedTestsDuringDates, start, end);
                reportViewer1.RefreshReport();
            }
            else
            {
                errorLabel.Text = "Start date can't be after end date.";
                reportViewer1.Clear();
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
