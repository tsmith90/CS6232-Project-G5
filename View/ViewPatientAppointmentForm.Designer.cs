
namespace ClinicSupport.View
{
    partial class ViewPatientAppointmentForm
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
            this.viewAppointmentsByPatientIDUserControl1 = new ClinicSupport.UserControls.ViewAppointmentsByPatientIDUserControl();
            this.SuspendLayout();
            // 
            // viewAppointmentsByPatientIDUserControl1
            // 
            this.viewAppointmentsByPatientIDUserControl1.Location = new System.Drawing.Point(-8, -1);
            this.viewAppointmentsByPatientIDUserControl1.Name = "viewAppointmentsByPatientIDUserControl1";
            this.viewAppointmentsByPatientIDUserControl1.Size = new System.Drawing.Size(1324, 952);
            this.viewAppointmentsByPatientIDUserControl1.TabIndex = 0;
            // 
            // ViewPatientAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 1112);
            this.Controls.Add(this.viewAppointmentsByPatientIDUserControl1);
            this.Name = "ViewPatientAppointmentForm";
            this.Text = "ViewPatitentAppointmentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ViewAppointmentsByPatientIDUserControl viewAppointmentsByPatientIDUserControl1;
    }
}