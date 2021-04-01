
namespace ClinicSupport.UserControls
{
    partial class NewAppointmentUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.visitInfoButton = new System.Windows.Forms.Button();
            this.apptDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(79, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient\'s First Name:";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fnameTextBox.Location = new System.Drawing.Point(85, 165);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(360, 53);
            this.fnameTextBox.TabIndex = 1;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lnameTextBox.Location = new System.Drawing.Point(85, 298);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(360, 53);
            this.lnameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(79, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient\'s Last Name:";
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.doctorTextBox.Location = new System.Drawing.Point(716, 298);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(360, 53);
            this.doctorTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(710, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(710, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Appointment Date:";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(85, 443);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(1003, 293);
            this.reasonTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(79, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reason for visit:";
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.AutoSize = true;
            this.addAppointmentButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addAppointmentButton.Location = new System.Drawing.Point(262, 779);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(245, 68);
            this.addAppointmentButton.TabIndex = 10;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelButton.Location = new System.Drawing.Point(843, 779);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(245, 68);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(371, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 54);
            this.label6.TabIndex = 12;
            this.label6.Text = "New Appointment";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.messageLabel.Location = new System.Drawing.Point(85, 853);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 32);
            this.messageLabel.TabIndex = 13;
            // 
            // visitInfoButton
            // 
            this.visitInfoButton.AutoSize = true;
            this.visitInfoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.visitInfoButton.Location = new System.Drawing.Point(554, 779);
            this.visitInfoButton.Name = "visitInfoButton";
            this.visitInfoButton.Size = new System.Drawing.Size(245, 68);
            this.visitInfoButton.TabIndex = 14;
            this.visitInfoButton.Text = "Visit Information";
            this.visitInfoButton.UseVisualStyleBackColor = true;
            this.visitInfoButton.Click += new System.EventHandler(this.VisitInfoButton_Click);
            // 
            // apptDateTimePicker
            // 
            this.apptDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.apptDateTimePicker.Location = new System.Drawing.Point(716, 165);
            this.apptDateTimePicker.Name = "apptDateTimePicker";
            this.apptDateTimePicker.Size = new System.Drawing.Size(360, 45);
            this.apptDateTimePicker.TabIndex = 15;
            // 
            // NewAppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apptDateTimePicker);
            this.Controls.Add(this.visitInfoButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewAppointmentUserControl";
            this.Size = new System.Drawing.Size(1167, 962);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button visitInfoButton;
        private System.Windows.Forms.DateTimePicker apptDateTimePicker;
    }
}
