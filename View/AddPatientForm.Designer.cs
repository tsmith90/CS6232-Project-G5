
namespace ClinicSupport.View
{
    partial class AddPatientForm
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
            this.addPatientUserControl1 = new ClinicSupport.UserControls.AddPatientUserControl();
            this.SuspendLayout();
            // 
            // addPatientUserControl1
            // 
            this.addPatientUserControl1.Location = new System.Drawing.Point(17, 16);
            this.addPatientUserControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addPatientUserControl1.Name = "addPatientUserControl1";
            this.addPatientUserControl1.Size = new System.Drawing.Size(1072, 839);
            this.addPatientUserControl1.TabIndex = 0;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 890);
            this.Controls.Add(this.addPatientUserControl1);
            this.Name = "AddPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Patient";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.AddPatientUserControl addPatientUserControl1;
    }
}