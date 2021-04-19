namespace ClinicSupport.UserControls
{
    partial class AddPatientUserControl
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
            this.patientInformationUserControl1 = new ClinicSupport.UserControls.PatientInformationUserControl();
            this.SuspendLayout();
            // 
            // patientInformationUserControl1
            // 
            this.patientInformationUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientInformationUserControl1.Location = new System.Drawing.Point(0, 0);
            this.patientInformationUserControl1.Name = "patientInformationUserControl1";
            this.patientInformationUserControl1.Size = new System.Drawing.Size(402, 330);
            this.patientInformationUserControl1.TabIndex = 0;
            // 
            // AddPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientInformationUserControl1);
            this.Name = "AddPatientUserControl";
            this.Size = new System.Drawing.Size(402, 354);
            this.ResumeLayout(false);

        }

        #endregion

        private PatientInformationUserControl patientInformationUserControl1;
    }
}
