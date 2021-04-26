
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
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewAppointmentsByPatientIDUserControl1
            // 
            this.viewAppointmentsByPatientIDUserControl1.Location = new System.Drawing.Point(12, 12);
            this.viewAppointmentsByPatientIDUserControl1.Name = "viewAppointmentsByPatientIDUserControl1";
            this.viewAppointmentsByPatientIDUserControl1.Size = new System.Drawing.Size(1357, 895);
            this.viewAppointmentsByPatientIDUserControl1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(579, 937);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(116, 62);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ViewPatientAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 1051);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.viewAppointmentsByPatientIDUserControl1);
            this.Name = "ViewPatientAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPatitentAppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ViewAppointmentsByPatientIDUserControl viewAppointmentsByPatientIDUserControl1;
        private System.Windows.Forms.Button closeButton;
    }
}