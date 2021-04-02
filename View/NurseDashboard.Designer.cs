
namespace ClinicSupport.View
{
    partial class NurseDashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nurseDashboardTabControl = new System.Windows.Forms.TabControl();
            this.searchPatientsTabPage = new System.Windows.Forms.TabPage();
            this.addPatientTabPage = new System.Windows.Forms.TabPage();
            this.patientInformationUserControl1 = new ClinicSupport.UserControls.PatientInformationUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.nurseDashboardTabControl.SuspendLayout();
            this.addPatientTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Controls.Add(this.logoutLinkLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nurseDashboardTabControl, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(758, 12);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(77, 23);
            this.logoutLinkLabel.TabIndex = 2;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(251, 29);
            this.nameLabel.TabIndex = 0;
            // 
            // nurseDashboardTabControl
            // 
            this.nurseDashboardTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.nurseDashboardTabControl, 3);
            this.nurseDashboardTabControl.Controls.Add(this.searchPatientsTabPage);
            this.nurseDashboardTabControl.Controls.Add(this.addPatientTabPage);
            this.nurseDashboardTabControl.Location = new System.Drawing.Point(3, 49);
            this.nurseDashboardTabControl.Name = "nurseDashboardTabControl";
            this.nurseDashboardTabControl.SelectedIndex = 0;
            this.nurseDashboardTabControl.Size = new System.Drawing.Size(842, 403);
            this.nurseDashboardTabControl.TabIndex = 3;
            this.nurseDashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.NurseDashboardTabControl_SelectedIndexChanged);
            // 
            // searchPatientsTabPage
            // 
            this.searchPatientsTabPage.Location = new System.Drawing.Point(4, 29);
            this.searchPatientsTabPage.Name = "searchPatientsTabPage";
            this.searchPatientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPatientsTabPage.Size = new System.Drawing.Size(834, 370);
            this.searchPatientsTabPage.TabIndex = 0;
            this.searchPatientsTabPage.Text = "Search Patients";
            this.searchPatientsTabPage.UseVisualStyleBackColor = true;
            // 
            // addPatientTabPage
            // 
            this.addPatientTabPage.Controls.Add(this.patientInformationUserControl1);
            this.addPatientTabPage.Location = new System.Drawing.Point(4, 29);
            this.addPatientTabPage.Name = "addPatientTabPage";
            this.addPatientTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPatientTabPage.Size = new System.Drawing.Size(834, 370);
            this.addPatientTabPage.TabIndex = 1;
            this.addPatientTabPage.Text = "Add Patient";
            this.addPatientTabPage.UseVisualStyleBackColor = true;
            // 
            // patientInformationUserControl1
            // 
            this.patientInformationUserControl1.Location = new System.Drawing.Point(151, 8);
            this.patientInformationUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientInformationUserControl1.Name = "patientInformationUserControl1";
            this.patientInformationUserControl1.Size = new System.Drawing.Size(517, 354);
            this.patientInformationUserControl1.TabIndex = 0;
            // 
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(850, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NurseDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.nurseDashboardTabControl.ResumeLayout(false);
            this.addPatientTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl nurseDashboardTabControl;
        private System.Windows.Forms.TabPage searchPatientsTabPage;
        private System.Windows.Forms.TabPage addPatientTabPage;
        private UserControls.PatientInformationUserControl patientInformationUserControl1;
    }
}