
namespace ClinicSupport.View
{
    partial class VisitByPatientIDForm
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
            this.vistInformationByPatientIDUserControl1 = new ClinicSupport.UserControls.VistInformationByPatientIDUserControl();
            this.SuspendLayout();
            // 
            // vistInformationByPatientIDUserControl1
            // 
            this.vistInformationByPatientIDUserControl1.Location = new System.Drawing.Point(-17, 33);
            this.vistInformationByPatientIDUserControl1.Name = "vistInformationByPatientIDUserControl1";
            this.vistInformationByPatientIDUserControl1.Size = new System.Drawing.Size(1436, 861);
            this.vistInformationByPatientIDUserControl1.TabIndex = 0;
            // 
            // VisitByPatientIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 899);
            this.Controls.Add(this.vistInformationByPatientIDUserControl1);
            this.Name = "VisitByPatientIDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisitByPatientIDForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.VistInformationByPatientIDUserControl vistInformationByPatientIDUserControl1;
    }
}