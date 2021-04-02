
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
            this.newAppointmentUserControl1.Location = new System.Drawing.Point(2, 0);
            this.newAppointmentUserControl1.Name = "newAppointmentUserControl1";
            this.newAppointmentUserControl1.Size = new System.Drawing.Size(1167, 962);
            this.newAppointmentUserControl1.TabIndex = 0;
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 1000);
            this.Controls.Add(this.newAppointmentUserControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAppointmentForm";
            this.Text = "New Appointment Form";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.NewAppointmentUserControl newAppointmentUserControl1;
    }
}