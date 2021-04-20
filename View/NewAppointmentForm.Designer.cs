
namespace ClinicSupport.View
{
    partial class NewAppointmentForm
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
            this.newAppointmentUserControl1 = new ClinicSupport.UserControls.NewAppointmentUserControl();
            this.SuspendLayout();
            // 
            // newAppointmentUserControl1
            // 
            this.newAppointmentUserControl1.CurrentPatientID = 0;
            this.newAppointmentUserControl1.Location = new System.Drawing.Point(3, 0);
            this.newAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.newAppointmentUserControl1.Name = "newAppointmentUserControl1";
            this.newAppointmentUserControl1.Size = new System.Drawing.Size(1168, 961);
            this.newAppointmentUserControl1.TabIndex = 0;
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 999);
            this.Controls.Add(this.newAppointmentUserControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Form";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.NewAppointmentUserControl newAppointmentUserControl1;
    }
}