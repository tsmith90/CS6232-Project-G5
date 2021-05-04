
namespace ClinicSupport.UserControls
{
    partial class TestReportUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getMostPerformedTestsDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsPerformedDataSet = new ClinicSupport.TestsPerformedDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bannerLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.findReportbutton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getMostPerformedTestsDuringDatesTableAdapter = new ClinicSupport.TestsPerformedDataSetTableAdapters.getMostPerformedTestsDuringDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getMostPerformedTestsDuringDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsPerformedDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getMostPerformedTestsDuringDatesBindingSource
            // 
            this.getMostPerformedTestsDuringDatesBindingSource.DataMember = "getMostPerformedTestsDuringDates";
            this.getMostPerformedTestsDuringDatesBindingSource.DataSource = this.testsPerformedDataSet;
            // 
            // testsPerformedDataSet
            // 
            this.testsPerformedDataSet.DataSetName = "TestsPerformedDataSet";
            this.testsPerformedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.Controls.Add(this.bannerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startDateTimePicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.startDateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.endDateLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.endDateTimePicker, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.findReportbutton, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bannerLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bannerLabel, 6);
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(3, 0);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(743, 36);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "Multiple Tests Performed Between Given Dates Report ";
            this.bannerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(124, 53);
            this.startDateTimePicker.MaxDate = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            this.startDateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(151, 26);
            this.startDateTimePicker.TabIndex = 2;
            this.startDateTimePicker.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startDateLabel.Location = new System.Drawing.Point(3, 53);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(115, 29);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "Start Date: ";
            this.startDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endDateLabel.Location = new System.Drawing.Point(311, 53);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(81, 29);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Date:";
            this.endDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(399, 53);
            this.endDateTimePicker.MaxDate = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            this.endDateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(155, 26);
            this.endDateTimePicker.TabIndex = 4;
            this.endDateTimePicker.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // findReportbutton
            // 
            this.findReportbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.findReportbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findReportbutton.Location = new System.Drawing.Point(598, 53);
            this.findReportbutton.Name = "findReportbutton";
            this.findReportbutton.Size = new System.Drawing.Size(112, 26);
            this.findReportbutton.TabIndex = 5;
            this.findReportbutton.Text = "Find Tests";
            this.findReportbutton.UseVisualStyleBackColor = true;
            this.findReportbutton.Click += new System.EventHandler(this.FindReportbutton_Click);
            // 
            // errorLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.errorLabel, 6);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(3, 82);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(743, 30);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.reportViewer1, 6);
            this.reportViewer1.DocumentMapWidth = 22;
            reportDataSource1.Name = "TestsPerformedDataSet";
            reportDataSource1.Value = this.getMostPerformedTestsDuringDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ClinicSupport.TestsPerformedReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(743, 248);
            this.reportViewer1.TabIndex = 7;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // getMostPerformedTestsDuringDatesTableAdapter
            // 
            this.getMostPerformedTestsDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // TestReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TestReportUserControl";
            this.Size = new System.Drawing.Size(756, 376);
            ((System.ComponentModel.ISupportInitialize)(this.getMostPerformedTestsDuringDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsPerformedDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button findReportbutton;
        private System.Windows.Forms.Label errorLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getMostPerformedTestsDuringDatesBindingSource;
        private TestsPerformedDataSet testsPerformedDataSet;
        private TestsPerformedDataSetTableAdapters.getMostPerformedTestsDuringDatesTableAdapter getMostPerformedTestsDuringDatesTableAdapter;
    }
}
