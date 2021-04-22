namespace ClinicSupport.View
{
    partial class ViewPatientInformationForm
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
            this.patientInformationUserControl1 = new ClinicSupport.UserControls.PatientInformationUserControl();
            this.SuspendLayout();
            // 
            // patientInformationUserControl1
            // 
            this.patientInformationUserControl1.Location = new System.Drawing.Point(32, 29);
            this.patientInformationUserControl1.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.patientInformationUserControl1.Name = "patientInformationUserControl1";
            this.patientInformationUserControl1.Size = new System.Drawing.Size(1045, 749);
            this.patientInformationUserControl1.TabIndex = 0;
            // 
            // ViewPatientInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 904);
            this.Controls.Add(this.patientInformationUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPatientInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Information";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.PatientInformationUserControl patientInformationUserControl1;
    }
}