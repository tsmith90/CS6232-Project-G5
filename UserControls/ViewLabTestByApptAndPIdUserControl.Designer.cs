
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
            this.orderTestButton = new System.Windows.Forms.Button();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labTestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labTestsDataGridView
            // 
            this.labTestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labTestsDataGridView.Location = new System.Drawing.Point(36, 216);
            this.labTestsDataGridView.Name = "labTestsDataGridView";
            this.labTestsDataGridView.RowHeadersWidth = 102;
            this.labTestsDataGridView.RowTemplate.Height = 40;
            this.labTestsDataGridView.Size = new System.Drawing.Size(1195, 411);
            this.labTestsDataGridView.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(43, 144);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 32);
            this.titleLabel.TabIndex = 1;
            // 
            // orderTestButton
            // 
            this.orderTestButton.AutoSize = true;
            this.orderTestButton.Enabled = false;
            this.orderTestButton.Location = new System.Drawing.Point(969, 77);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(232, 61);
            this.orderTestButton.TabIndex = 3;
            this.orderTestButton.Text = "Order New Test";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.orderTestButton_Click);
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Location = new System.Drawing.Point(36, 89);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(270, 38);
            this.patientIDTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(323, 77);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 61);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Patient by ID:";
            // 
            // ViewLabTestByApptAndPIdUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.orderTestButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.labTestsDataGridView);
            this.Name = "ViewLabTestByApptAndPIdUserControl";
            this.Size = new System.Drawing.Size(1288, 760);
            ((System.ComponentModel.ISupportInitialize)(this.labTestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView labTestsDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
    }
}
