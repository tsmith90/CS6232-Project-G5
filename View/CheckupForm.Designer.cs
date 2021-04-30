
namespace ClinicSupport.View
{
    partial class CheckupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckupForm));
            this.getPatientButton = new System.Windows.Forms.Button();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.bannerLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nurseIDLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.systolicLabel = new System.Windows.Forms.Label();
            this.diastolicLabel = new System.Windows.Forms.Label();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.nurseTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.systolicTextBox = new System.Windows.Forms.TextBox();
            this.diastolicTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.symptomsLabel = new System.Windows.Forms.Label();
            this.appointmentLabel = new System.Windows.Forms.Label();
            this.appointmentComboBox = new System.Windows.Forms.ComboBox();
            this.checkupButton = new System.Windows.Forms.Button();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.initialDiagnosisLabel = new System.Windows.Forms.Label();
            this.initialDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.finalFiagnosisLabel = new System.Windows.Forms.Label();
            this.finalDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.nurseNameLabel = new System.Windows.Forms.Label();
            this.nurseNameTextbox = new System.Windows.Forms.TextBox();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.doctorNameTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getPatientButton
            // 
            this.getPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPatientButton.Location = new System.Drawing.Point(241, 88);
            this.getPatientButton.Name = "getPatientButton";
            this.getPatientButton.Size = new System.Drawing.Size(105, 28);
            this.getPatientButton.TabIndex = 4;
            this.getPatientButton.Text = "Find";
            this.getPatientButton.UseVisualStyleBackColor = true;
            this.getPatientButton.Click += new System.EventHandler(this.GetPatientButton_Click);
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTextBox.Location = new System.Drawing.Point(132, 88);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.patientIDTextBox.TabIndex = 3;
            this.patientIDTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.Location = new System.Drawing.Point(11, 85);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(115, 29);
            this.patientIDLabel.TabIndex = 2;
            this.patientIDLabel.Text = "Patient ID:";
            this.patientIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bannerLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bannerLabel, 4);
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(241, 14);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(430, 25);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "Checkup Information";
            this.bannerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.errorLabel, 4);
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(241, 50);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(430, 23);
            this.errorLabel.TabIndex = 1;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Controls.Add(this.nurseIDLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.weightLabel, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.temperatureLabel, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.systolicLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.diastolicLabel, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.pulseLabel, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.nurseTextBox, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.weightTextBox, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.temperatureTextBox, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.bannerLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.systolicTextBox, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.diastolicTextBox, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.pulseTextBox, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.symptomsLabel, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.patientIDLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.patientIDTextBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.getPatientButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.appointmentLabel, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.appointmentComboBox, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkupButton, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.symptomsTextBox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.initialDiagnosisLabel, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.initialDiagnosisTextBox, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.finalFiagnosisLabel, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.finalDiagnosisTextBox, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.enterButton, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.nurseNameLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.nurseNameTextbox, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.doctorLabel, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.doctorNameTextbox, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 2, 11);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nurseIDLabel
            // 
            this.nurseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseIDLabel.Location = new System.Drawing.Point(11, 164);
            this.nurseIDLabel.Name = "nurseIDLabel";
            this.nurseIDLabel.Size = new System.Drawing.Size(115, 29);
            this.nurseIDLabel.TabIndex = 8;
            this.nurseIDLabel.Text = "NurseID:";
            this.nurseIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // weightLabel
            // 
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(241, 164);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(105, 29);
            this.weightLabel.TabIndex = 9;
            this.weightLabel.Text = "Weight:";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.Location = new System.Drawing.Point(501, 164);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(146, 29);
            this.temperatureLabel.TabIndex = 10;
            this.temperatureLabel.Text = "Temperature:";
            this.temperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // systolicLabel
            // 
            this.systolicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicLabel.Location = new System.Drawing.Point(11, 209);
            this.systolicLabel.Name = "systolicLabel";
            this.systolicLabel.Size = new System.Drawing.Size(115, 29);
            this.systolicLabel.TabIndex = 11;
            this.systolicLabel.Text = "Systolic:";
            this.systolicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // diastolicLabel
            // 
            this.diastolicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicLabel.Location = new System.Drawing.Point(241, 209);
            this.diastolicLabel.Name = "diastolicLabel";
            this.diastolicLabel.Size = new System.Drawing.Size(105, 29);
            this.diastolicLabel.TabIndex = 12;
            this.diastolicLabel.Text = "Diastolic:";
            this.diastolicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pulseLabel
            // 
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseLabel.Location = new System.Drawing.Point(501, 209);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(146, 29);
            this.pulseLabel.TabIndex = 13;
            this.pulseLabel.Text = "Pulse:";
            this.pulseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nurseTextBox
            // 
            this.nurseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseTextBox.Location = new System.Drawing.Point(132, 167);
            this.nurseTextBox.Name = "nurseTextBox";
            this.nurseTextBox.Size = new System.Drawing.Size(100, 26);
            this.nurseTextBox.TabIndex = 14;
            this.nurseTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(352, 167);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 26);
            this.weightTextBox.TabIndex = 15;
            this.weightTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(653, 167);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(100, 26);
            this.temperatureTextBox.TabIndex = 16;
            this.temperatureTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // systolicTextBox
            // 
            this.systolicTextBox.Location = new System.Drawing.Point(132, 212);
            this.systolicTextBox.Name = "systolicTextBox";
            this.systolicTextBox.Size = new System.Drawing.Size(100, 26);
            this.systolicTextBox.TabIndex = 17;
            this.systolicTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // diastolicTextBox
            // 
            this.diastolicTextBox.Location = new System.Drawing.Point(352, 212);
            this.diastolicTextBox.Name = "diastolicTextBox";
            this.diastolicTextBox.Size = new System.Drawing.Size(100, 26);
            this.diastolicTextBox.TabIndex = 18;
            this.diastolicTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Location = new System.Drawing.Point(653, 212);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(100, 26);
            this.pulseTextBox.TabIndex = 19;
            this.pulseTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.Location = new System.Drawing.Point(11, 323);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(95, 26);
            this.symptomsLabel.TabIndex = 20;
            this.symptomsLabel.Text = "Symptoms:";
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentLabel.Location = new System.Drawing.Point(352, 85);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(143, 28);
            this.appointmentLabel.TabIndex = 5;
            this.appointmentLabel.Text = "Appointment:";
            this.appointmentLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // appointmentComboBox
            // 
            this.appointmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appointmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentComboBox.FormattingEnabled = true;
            this.appointmentComboBox.Location = new System.Drawing.Point(501, 88);
            this.appointmentComboBox.Name = "appointmentComboBox";
            this.appointmentComboBox.Size = new System.Drawing.Size(146, 28);
            this.appointmentComboBox.TabIndex = 6;
            this.appointmentComboBox.SelectedIndexChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // checkupButton
            // 
            this.checkupButton.Location = new System.Drawing.Point(653, 88);
            this.checkupButton.Name = "checkupButton";
            this.checkupButton.Size = new System.Drawing.Size(126, 28);
            this.checkupButton.TabIndex = 7;
            this.checkupButton.Text = "Find Checkup";
            this.checkupButton.UseVisualStyleBackColor = true;
            this.checkupButton.Click += new System.EventHandler(this.CheckupButton_Click);
            // 
            // symptomsTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.symptomsTextBox, 2);
            this.symptomsTextBox.Location = new System.Drawing.Point(11, 352);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(221, 142);
            this.symptomsTextBox.TabIndex = 22;
            this.symptomsTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // initialDiagnosisLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.initialDiagnosisLabel, 2);
            this.initialDiagnosisLabel.Location = new System.Drawing.Point(241, 323);
            this.initialDiagnosisLabel.Name = "initialDiagnosisLabel";
            this.initialDiagnosisLabel.Size = new System.Drawing.Size(124, 26);
            this.initialDiagnosisLabel.TabIndex = 21;
            this.initialDiagnosisLabel.Text = "Initial Diagnosis:";
            // 
            // initialDiagnosisTextBox
            // 
            this.initialDiagnosisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.initialDiagnosisTextBox, 2);
            this.initialDiagnosisTextBox.Location = new System.Drawing.Point(241, 352);
            this.initialDiagnosisTextBox.Multiline = true;
            this.initialDiagnosisTextBox.Name = "initialDiagnosisTextBox";
            this.initialDiagnosisTextBox.Size = new System.Drawing.Size(254, 142);
            this.initialDiagnosisTextBox.TabIndex = 23;
            this.initialDiagnosisTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // finalFiagnosisLabel
            // 
            this.finalFiagnosisLabel.Location = new System.Drawing.Point(501, 323);
            this.finalFiagnosisLabel.Name = "finalFiagnosisLabel";
            this.finalFiagnosisLabel.Size = new System.Drawing.Size(146, 26);
            this.finalFiagnosisLabel.TabIndex = 24;
            this.finalFiagnosisLabel.Text = "Final Diagnosis:";
            // 
            // finalDiagnosisTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.finalDiagnosisTextBox, 2);
            this.finalDiagnosisTextBox.Location = new System.Drawing.Point(501, 352);
            this.finalDiagnosisTextBox.Multiline = true;
            this.finalDiagnosisTextBox.Name = "finalDiagnosisTextBox";
            this.finalDiagnosisTextBox.Size = new System.Drawing.Size(269, 142);
            this.finalDiagnosisTextBox.TabIndex = 25;
            this.finalDiagnosisTextBox.TextChanged += new System.EventHandler(this.Form_TextChanged);
            // 
            // clearButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.clearButton, 2);
            this.clearButton.Location = new System.Drawing.Point(132, 508);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 50);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(501, 508);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(140, 50);
            this.enterButton.TabIndex = 27;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // nurseNameLabel
            // 
            this.nurseNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nurseNameLabel.Location = new System.Drawing.Point(13, 265);
            this.nurseNameLabel.Name = "nurseNameLabel";
            this.nurseNameLabel.Size = new System.Drawing.Size(113, 29);
            this.nurseNameLabel.TabIndex = 28;
            this.nurseNameLabel.Text = "Nurse\'s Name:";
            this.nurseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nurseNameTextbox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nurseNameTextbox, 2);
            this.nurseNameTextbox.Enabled = false;
            this.nurseNameTextbox.Location = new System.Drawing.Point(132, 268);
            this.nurseNameTextbox.Name = "nurseNameTextbox";
            this.nurseNameTextbox.Size = new System.Drawing.Size(214, 26);
            this.nurseNameTextbox.TabIndex = 29;
            // 
            // doctorLabel
            // 
            this.doctorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorLabel.Location = new System.Drawing.Point(370, 265);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(125, 29);
            this.doctorLabel.TabIndex = 30;
            this.doctorLabel.Text = "Doctor\'s Name:";
            this.doctorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // doctorNameTextbox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.doctorNameTextbox, 2);
            this.doctorNameTextbox.Enabled = false;
            this.doctorNameTextbox.Location = new System.Drawing.Point(501, 268);
            this.doctorNameTextbox.Name = "doctorNameTextbox";
            this.doctorNameTextbox.Size = new System.Drawing.Size(215, 26);
            this.doctorNameTextbox.TabIndex = 31;
            // 
            // CheckupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkup Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getPatientButton;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label appointmentLabel;
        private System.Windows.Forms.ComboBox appointmentComboBox;
        private System.Windows.Forms.Button checkupButton;
        private System.Windows.Forms.Label nurseIDLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label systolicLabel;
        private System.Windows.Forms.Label diastolicLabel;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.TextBox nurseTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox systolicTextBox;
        private System.Windows.Forms.TextBox diastolicTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.Label symptomsLabel;
        private System.Windows.Forms.Label initialDiagnosisLabel;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox initialDiagnosisTextBox;
        private System.Windows.Forms.Label finalFiagnosisLabel;
        private System.Windows.Forms.TextBox finalDiagnosisTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label nurseNameLabel;
        private System.Windows.Forms.TextBox nurseNameTextbox;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.TextBox doctorNameTextbox;
    }
}