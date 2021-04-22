namespace ClinicSupport.UserControls
{
    partial class PatientInformationUserControl
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
            this.patientInfoLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dobTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createPatientButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.apptButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientInfoLabel
            // 
            this.patientInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientInfoLabel.AutoSize = true;
            this.patientInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInfoLabel.Location = new System.Drawing.Point(417, 10);
            this.patientInfoLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.patientInfoLabel.Name = "patientInfoLabel";
            this.patientInfoLabel.Size = new System.Drawing.Size(354, 46);
            this.patientInfoLabel.TabIndex = 0;
            this.patientInfoLabel.Text = "Patient Information";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 16);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(160, 32);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(8, 55);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(388, 38);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(8, 112);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(159, 32);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // dobLabel
            // 
            this.dobLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(8, 208);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(385, 32);
            this.dobLabel.TabIndex = 5;
            this.dobLabel.Text = "Date of Birth: (MM-DD-YYYY)";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.phoneNumLabel.Location = new System.Drawing.Point(8, 305);
            this.phoneNumLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(395, 31);
            this.phoneNumLabel.TabIndex = 6;
            this.phoneNumLabel.Text = "Phone (XXXXXXXXXX):";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(602, 16);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(127, 32);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(602, 112);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(72, 32);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(602, 208);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(90, 32);
            this.stateLabel.TabIndex = 9;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(602, 304);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(66, 32);
            this.zipLabel.TabIndex = 10;
            this.zipLabel.Text = "ZIP:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(8, 151);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(388, 38);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // dobTextBox
            // 
            this.dobTextBox.Location = new System.Drawing.Point(8, 247);
            this.dobTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(388, 38);
            this.dobTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(8, 343);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(388, 38);
            this.phoneTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(602, 55);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(396, 38);
            this.addressTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(602, 151);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(396, 38);
            this.cityTextBox.TabIndex = 7;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(602, 247);
            this.stateComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(396, 39);
            this.stateComboBox.TabIndex = 8;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(602, 343);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(396, 38);
            this.zipTextBox.TabIndex = 9;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(8, 7);
            this.clearButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(200, 48);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(800, 7);
            this.updateButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 48);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // createPatientButton
            // 
            this.createPatientButton.Location = new System.Drawing.Point(404, 7);
            this.createPatientButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.createPatientButton.Name = "createPatientButton";
            this.createPatientButton.Size = new System.Drawing.Size(200, 48);
            this.createPatientButton.TabIndex = 10;
            this.createPatientButton.Text = "Create";
            this.createPatientButton.UseVisualStyleBackColor = true;
            this.createPatientButton.Click += new System.EventHandler(this.CreatePatientButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.patientInfoLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 67);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.firstNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.firstNameTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lastNameLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lastNameTextBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dobLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.zipTextBox, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.dobTextBox, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.zipLabel, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.stateComboBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.phoneNumLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.cityTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.phoneTextBox, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.addressLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addressTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cityLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.stateLabel, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.ssnLabel, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.ssnTextBox, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1189, 489);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // ssnLabel
            // 
            this.ssnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(8, 400);
            this.ssnLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(81, 32);
            this.ssnLabel.TabIndex = 11;
            this.ssnLabel.Text = "SSN:";
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ssnTextBox.Location = new System.Drawing.Point(8, 444);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(383, 38);
            this.ssnTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.clearButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.createPatientButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.updateButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 556);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1189, 62);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(2, 698);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 32);
            this.messageLabel.TabIndex = 15;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(812, 686);
            this.closeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(200, 55);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // apptButton
            // 
            this.apptButton.AutoSize = true;
            this.apptButton.Location = new System.Drawing.Point(375, 637);
            this.apptButton.Name = "apptButton";
            this.apptButton.Size = new System.Drawing.Size(269, 62);
            this.apptButton.TabIndex = 17;
            this.apptButton.Text = "View Appointments";
            this.apptButton.UseVisualStyleBackColor = true;
            this.apptButton.Click += new System.EventHandler(this.apptButton_Click);
            // 
            // PatientInformationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apptButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PatientInformationUserControl";
            this.Size = new System.Drawing.Size(1189, 941);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientInfoLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox dobTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createPatientButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Button apptButton;
    }
}
