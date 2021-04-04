
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
            this.appointmentLabel = new System.Windows.Forms.Label();
            this.appointmentComboBox = new System.Windows.Forms.ComboBox();
            this.checkupButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getPatientButton
            // 
            this.getPatientButton.Location = new System.Drawing.Point(492, 88);
            this.getPatientButton.Name = "getPatientButton";
            this.getPatientButton.Size = new System.Drawing.Size(126, 26);
            this.getPatientButton.TabIndex = 4;
            this.getPatientButton.Text = "Find Appointments";
            this.getPatientButton.UseVisualStyleBackColor = true;
            this.getPatientButton.Click += new System.EventHandler(this.GetPatientButton_Click);
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTextBox.Location = new System.Drawing.Point(307, 88);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(179, 26);
            this.patientIDTextBox.TabIndex = 3;
            this.patientIDTextBox.TextChanged += new System.EventHandler(this.PatientIDTextBox_TextChanged);
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.Location = new System.Drawing.Point(194, 85);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(107, 29);
            this.patientIDLabel.TabIndex = 2;
            this.patientIDLabel.Text = "Patient ID:";
            this.patientIDLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bannerLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.bannerLabel, 3);
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(194, 14);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(424, 25);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "Checkup Information";
            this.bannerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.errorLabel, 3);
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(194, 50);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(424, 23);
            this.errorLabel.TabIndex = 1;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bannerLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientIDLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.patientIDTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.getPatientButton, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.appointmentLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.appointmentComboBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkupButton, 4, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 532);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentLabel.Location = new System.Drawing.Point(194, 136);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(107, 28);
            this.appointmentLabel.TabIndex = 5;
            this.appointmentLabel.Text = "Appointment:";
            this.appointmentLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // appointmentComboBox
            // 
            this.appointmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentComboBox.FormattingEnabled = true;
            this.appointmentComboBox.Location = new System.Drawing.Point(307, 139);
            this.appointmentComboBox.Name = "appointmentComboBox";
            this.appointmentComboBox.Size = new System.Drawing.Size(179, 28);
            this.appointmentComboBox.TabIndex = 6;
            // 
            // checkupButton
            // 
            this.checkupButton.Location = new System.Drawing.Point(492, 139);
            this.checkupButton.Name = "checkupButton";
            this.checkupButton.Size = new System.Drawing.Size(126, 25);
            this.checkupButton.TabIndex = 7;
            this.checkupButton.Text = "Find Checkup";
            this.checkupButton.UseVisualStyleBackColor = true;
            this.checkupButton.Click += new System.EventHandler(this.CheckupButton_Click);
            // 
            // CheckupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 536);
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
    }
}