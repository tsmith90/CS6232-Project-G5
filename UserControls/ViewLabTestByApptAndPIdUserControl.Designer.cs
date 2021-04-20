
namespace ClinicSupport.UserControls
{
    partial class ViewLabTestByApptAndPIdUserControl
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
            this.labTestsDataGridView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.labTestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labTestsDataGridView
            // 
            this.labTestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labTestsDataGridView.Location = new System.Drawing.Point(13, 139);
            this.labTestsDataGridView.Name = "labTestsDataGridView";
            this.labTestsDataGridView.RowHeadersWidth = 102;
            this.labTestsDataGridView.RowTemplate.Height = 40;
            this.labTestsDataGridView.Size = new System.Drawing.Size(1195, 411);
            this.labTestsDataGridView.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(13, 48);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 32);
            this.titleLabel.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.Location = new System.Drawing.Point(572, 582);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 42);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ViewLabTestByApptAndPIdUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.labTestsDataGridView);
            this.Name = "ViewLabTestByApptAndPIdUserControl";
            this.Size = new System.Drawing.Size(1221, 683);
            ((System.ComponentModel.ISupportInitialize)(this.labTestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView labTestsDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button okButton;
    }
}
