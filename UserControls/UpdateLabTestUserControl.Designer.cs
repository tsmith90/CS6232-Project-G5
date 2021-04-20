namespace ClinicSupport.UserControls
{
    partial class UpdateLabTestUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderTestUserControl1 = new ClinicSupport.UserControls.OrderTestUserControl();
            this.SuspendLayout();
            // 
            // orderTestUserControl1
            // 
            this.orderTestUserControl1.Location = new System.Drawing.Point(3, 3);
            this.orderTestUserControl1.Name = "orderTestUserControl1";
            this.orderTestUserControl1.Size = new System.Drawing.Size(397, 407);
            this.orderTestUserControl1.TabIndex = 0;
            // 
            // UpdateLabTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderTestUserControl1);
            this.Name = "UpdateLabTestUserControl";
            this.Size = new System.Drawing.Size(400, 429);
            this.ResumeLayout(false);

        }

        #endregion

        private OrderTestUserControl orderTestUserControl1;
    }
}
