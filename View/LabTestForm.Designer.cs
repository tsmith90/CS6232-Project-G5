
namespace ClinicSupport.View
{
    partial class LabTestForm
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
            this.viewLabTestByApptAndPIdUserControl1 = new ClinicSupport.UserControls.ViewLabTestByApptAndPIdUserControl();
            this.SuspendLayout();
            // 
            // viewLabTestByApptAndPIdUserControl1
            // 
            this.viewLabTestByApptAndPIdUserControl1.Location = new System.Drawing.Point(22, 37);
            this.viewLabTestByApptAndPIdUserControl1.Name = "viewLabTestByApptAndPIdUserControl1";
            this.viewLabTestByApptAndPIdUserControl1.Size = new System.Drawing.Size(1221, 683);
            this.viewLabTestByApptAndPIdUserControl1.TabIndex = 0;
            // 
            // LabTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 775);
            this.Controls.Add(this.viewLabTestByApptAndPIdUserControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabTests";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ViewLabTestByApptAndPIdUserControl viewLabTestByApptAndPIdUserControl1;
    }
}