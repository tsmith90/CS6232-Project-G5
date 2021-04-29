
namespace ClinicSupport.View
{
    partial class DeletePatientForm
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
            this.deletePatientUserControl1 = new ClinicSupport.UserControls.DeletePatientUserControl();
            this.SuspendLayout();
            // 
            // deletePatientUserControl1
            // 
            this.deletePatientUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePatientUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientUserControl1.Location = new System.Drawing.Point(13, 14);
            this.deletePatientUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletePatientUserControl1.Name = "deletePatientUserControl1";
            this.deletePatientUserControl1.Size = new System.Drawing.Size(1292, 911);
            this.deletePatientUserControl1.TabIndex = 0;
            // 
            // DeletePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 1064);
            this.Controls.Add(this.deletePatientUserControl1);
            this.Name = "DeletePatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletePatientForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.DeletePatientUserControl deletePatientUserControl1;
    }
}