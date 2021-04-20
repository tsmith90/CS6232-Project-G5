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
            this.addLabTestUserControl1.Location = new System.Drawing.Point(12, 10);
            this.addLabTestUserControl1.Name = "addLabTestUserControl1";
            this.addLabTestUserControl1.Size = new System.Drawing.Size(412, 428);
            this.addLabTestUserControl1.TabIndex = 0;
            // 
            // AddLabTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.addLabTestUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddLabTestForm";
            this.Text = "Add Lab Test Form";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.AddLabTestUserControl addLabTestUserControl1;
    }
}