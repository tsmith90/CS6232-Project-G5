namespace ClinicSupport.View
{
    partial class AddLabTestForm
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
            this.addLabTestUserControl1 = new ClinicSupport.UserControls.AddLabTestUserControl();
            this.SuspendLayout();
            // 
            // addLabTestUserControl1
            // 
            this.addLabTestUserControl1.Location = new System.Drawing.Point(103, 36);
            this.addLabTestUserControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addLabTestUserControl1.Name = "addLabTestUserControl1";
            this.addLabTestUserControl1.Size = new System.Drawing.Size(1099, 1021);
            this.addLabTestUserControl1.TabIndex = 0;
            // 
            // AddLabTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 1073);
            this.Controls.Add(this.addLabTestUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddLabTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order LabTest Form";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.AddLabTestUserControl addLabTestUserControl1;
    }
}