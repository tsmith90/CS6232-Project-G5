namespace ClinicSupport.View
{
    partial class UpdateLabTestView
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
            this.updateLabTestUserControl1 = new ClinicSupport.UserControls.UpdateLabTestUserControl();
            this.SuspendLayout();
            // 
            // updateLabTestUserControl1
            // 
            this.updateLabTestUserControl1.Location = new System.Drawing.Point(12, 9);
            this.updateLabTestUserControl1.Name = "updateLabTestUserControl1";
            this.updateLabTestUserControl1.Size = new System.Drawing.Size(400, 429);
            this.updateLabTestUserControl1.TabIndex = 0;
            // 
            // UpdateLabTestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.updateLabTestUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateLabTestView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Lab Test";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UpdateLabTestUserControl updateLabTestUserControl1;
    }
}