
namespace ClinicSupport.UserControls
{
    partial class VisitInformationUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.visitListView = new System.Windows.Forms.ListView();
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nurseColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.systolicColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diastolicColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.temperatureColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pulseColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.symptomsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.initialDiagnosisColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finalDiagnosisColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.findPatientButton = new System.Windows.Forms.Button();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.bannerLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.enterInformationButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.visitListView, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.findPatientButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.bannerLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.enterInformationButton, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.patientIDLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.patientIDTextBox, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // visitListView
            // 
            this.visitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeColumn,
            this.nurseColumn,
            this.weightColumn,
            this.systolicColumn,
            this.diastolicColumn,
            this.temperatureColumn,
            this.pulseColumn,
            this.symptomsColumn,
            this.initialDiagnosisColumn,
            this.finalDiagnosisColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.visitListView, 6);
            this.visitListView.HideSelection = false;
            this.visitListView.Location = new System.Drawing.Point(3, 132);
            this.visitListView.Name = "visitListView";
            this.visitListView.Size = new System.Drawing.Size(886, 357);
            this.visitListView.TabIndex = 3;
            this.visitListView.UseCompatibleStateImageBehavior = false;
            this.visitListView.View = System.Windows.Forms.View.Details;
            // 
            // timeColumn
            // 
            this.timeColumn.Text = "Time";
            // 
            // nurseColumn
            // 
            this.nurseColumn.Text = "NurseID";
            this.nurseColumn.Width = 54;
            // 
            // weightColumn
            // 
            this.weightColumn.Text = "Weight";
            this.weightColumn.Width = 53;
            // 
            // systolicColumn
            // 
            this.systolicColumn.Text = "Systolic";
            // 
            // diastolicColumn
            // 
            this.diastolicColumn.Text = "Diastolic";
            // 
            // temperatureColumn
            // 
            this.temperatureColumn.Text = "Temperature";
            this.temperatureColumn.Width = 80;
            // 
            // pulseColumn
            // 
            this.pulseColumn.Text = "Pulse";
            // 
            // symptomsColumn
            // 
            this.symptomsColumn.Text = "Symptoms";
            // 
            // initialDiagnosisColumn
            // 
            this.initialDiagnosisColumn.Text = "Initial Diagnosis";
            this.initialDiagnosisColumn.Width = 103;
            // 
            // finalDiagnosisColumn
            // 
            this.finalDiagnosisColumn.Text = "Final Diagnosis";
            this.finalDiagnosisColumn.Width = 168;
            // 
            // findPatientButton
            // 
            this.findPatientButton.Location = new System.Drawing.Point(466, 92);
            this.findPatientButton.Name = "findPatientButton";
            this.findPatientButton.Size = new System.Drawing.Size(133, 26);
            this.findPatientButton.TabIndex = 2;
            this.findPatientButton.Text = "Find Patient";
            this.findPatientButton.UseVisualStyleBackColor = true;
            this.findPatientButton.Click += new System.EventHandler(this.FindPatientButton_Click);
            // 
            // patientIDTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.patientIDTextBox, 2);
            this.patientIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTextBox.Location = new System.Drawing.Point(296, 92);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(147, 26);
            this.patientIDTextBox.TabIndex = 1;
            this.patientIDTextBox.TextChanged += new System.EventHandler(this.PatientIDTextBox_TextChanged);
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.Location = new System.Drawing.Point(108, 89);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(178, 29);
            this.patientIDLabel.TabIndex = 0;
            this.patientIDLabel.Text = "Patient ID:";
            this.patientIDLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // bannerLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bannerLabel, 3);
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(296, 0);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(312, 51);
            this.bannerLabel.TabIndex = 4;
            this.bannerLabel.Text = "Patient Visit Information";
            this.bannerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.errorLabel, 3);
            this.errorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(296, 51);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(312, 38);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterInformationButton
            // 
            this.enterInformationButton.Location = new System.Drawing.Point(614, 92);
            this.enterInformationButton.Name = "enterInformationButton";
            this.enterInformationButton.Size = new System.Drawing.Size(187, 26);
            this.enterInformationButton.TabIndex = 6;
            this.enterInformationButton.Text = "Enter Checkup Information";
            this.enterInformationButton.UseVisualStyleBackColor = true;
            this.enterInformationButton.Click += new System.EventHandler(this.EnterInformationButton_Click);
            // 
            // VisitInformationUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VisitInformationUserControl";
            this.Size = new System.Drawing.Size(893, 494);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.Button findPatientButton;
        private System.Windows.Forms.ListView visitListView;
        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ColumnHeader timeColumn;
        private System.Windows.Forms.ColumnHeader nurseColumn;
        private System.Windows.Forms.ColumnHeader weightColumn;
        private System.Windows.Forms.ColumnHeader systolicColumn;
        private System.Windows.Forms.ColumnHeader diastolicColumn;
        private System.Windows.Forms.ColumnHeader temperatureColumn;
        private System.Windows.Forms.ColumnHeader pulseColumn;
        private System.Windows.Forms.ColumnHeader symptomsColumn;
        private System.Windows.Forms.ColumnHeader initialDiagnosisColumn;
        private System.Windows.Forms.ColumnHeader finalDiagnosisColumn;
        private System.Windows.Forms.Button enterInformationButton;
    }
}
