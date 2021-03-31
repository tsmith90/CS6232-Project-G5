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
            this.pationInfoLabel = new System.Windows.Forms.Label();
            this.generalInfoLabel = new System.Windows.Forms.Label();
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createPatientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pationInfoLabel
            // 
            this.pationInfoLabel.AutoSize = true;
            this.pationInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pationInfoLabel.Location = new System.Drawing.Point(118, 6);
            this.pationInfoLabel.Name = "pationInfoLabel";
            this.pationInfoLabel.Size = new System.Drawing.Size(144, 20);
            this.pationInfoLabel.TabIndex = 0;
            this.pationInfoLabel.Text = "Patient Information";
            // 
            // generalInfoLabel
            // 
            this.generalInfoLabel.AutoSize = true;
            this.generalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalInfoLabel.Location = new System.Drawing.Point(21, 37);
            this.generalInfoLabel.Name = "generalInfoLabel";
            this.generalInfoLabel.Size = new System.Drawing.Size(137, 17);
            this.generalInfoLabel.TabIndex = 1;
            this.generalInfoLabel.Text = "General Information:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(24, 65);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(27, 82);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(24, 105);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(24, 144);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(69, 13);
            this.dobLabel.TabIndex = 5;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Location = new System.Drawing.Point(24, 184);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneNumLabel.TabIndex = 6;
            this.phoneNumLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(214, 65);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(214, 105);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(214, 144);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 9;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(214, 184);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(27, 13);
            this.zipLabel.TabIndex = 10;
            this.zipLabel.Text = "ZIP:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(27, 121);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // dobTextBox
            // 
            this.dobTextBox.Location = new System.Drawing.Point(27, 161);
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(148, 20);
            this.dobTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(27, 201);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(148, 20);
            this.phoneTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(217, 81);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(151, 20);
            this.addressTextBox.TabIndex = 14;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(217, 120);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(151, 20);
            this.cityTextBox.TabIndex = 15;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(217, 159);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(151, 21);
            this.stateComboBox.TabIndex = 16;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(217, 200);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(151, 20);
            this.zipTextBox.TabIndex = 17;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(27, 256);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(293, 256);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // createPatientButton
            // 
            this.createPatientButton.Location = new System.Drawing.Point(166, 256);
            this.createPatientButton.Name = "createPatientButton";
            this.createPatientButton.Size = new System.Drawing.Size(75, 23);
            this.createPatientButton.TabIndex = 20;
            this.createPatientButton.Text = "Create";
            this.createPatientButton.UseVisualStyleBackColor = true;
            // 
            // PatientInformationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createPatientButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.dobTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.generalInfoLabel);
            this.Controls.Add(this.pationInfoLabel);
            this.Name = "PatientInformationUserControl";
            this.Size = new System.Drawing.Size(394, 334);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pationInfoLabel;
        private System.Windows.Forms.Label generalInfoLabel;
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createPatientButton;
    }
}
