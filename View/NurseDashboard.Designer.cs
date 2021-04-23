
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseDashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nurseDashboardTabControl = new System.Windows.Forms.TabControl();
            this.searchPatientsTabPage = new System.Windows.Forms.TabPage();
            this.searchPatientUserControl1 = new ClinicSupport.UserControls.SearchPatientUserControl();
            this.addPatientTabPage = new System.Windows.Forms.TabPage();
            this.addPatientUserControl1 = new ClinicSupport.UserControls.AddPatientUserControl();
            this.testsTabPage = new System.Windows.Forms.TabPage();
            this.viewLabTestByApptAndPIdUserControl1 = new ClinicSupport.UserControls.ViewLabTestByApptAndPIdUserControl();
            this.visitInformationTabPage = new System.Windows.Forms.TabPage();
            this.visitInformationUserControl2 = new ClinicSupport.UserControls.VisitInformationUserControl();
            this.visitInformationUserControl1 = new ClinicSupport.UserControls.VisitInformationUserControl();
            this.deletePatientTabPage = new System.Windows.Forms.TabPage();
            this.deletePatientUserControl1 = new ClinicSupport.UserControls.DeletePatientUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.nurseDashboardTabControl.SuspendLayout();
            this.searchPatientsTabPage.SuspendLayout();
            this.addPatientTabPage.SuspendLayout();
            this.testsTabPage.SuspendLayout();
            this.visitInformationTabPage.SuspendLayout();
            this.deletePatientTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1669F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel1.Controls.Add(this.logoutLinkLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nurseDashboardTabControl, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2512, 1483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(2290, 29);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(205, 81);
            this.logoutLinkLabel.TabIndex = 2;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(8, 29);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(669, 69);
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
            this.nurseDashboardTabControl.Controls.Add(this.testsTabPage);
            this.nurseDashboardTabControl.Controls.Add(this.visitInformationTabPage);
            this.nurseDashboardTabControl.Controls.Add(this.deletePatientTabPage);
            this.nurseDashboardTabControl.Location = new System.Drawing.Point(8, 117);
            this.nurseDashboardTabControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nurseDashboardTabControl.Name = "nurseDashboardTabControl";
            this.nurseDashboardTabControl.SelectedIndex = 0;
            this.nurseDashboardTabControl.Size = new System.Drawing.Size(2496, 1359);
            this.nurseDashboardTabControl.TabIndex = 3;
            // 
            // searchPatientsTabPage
            // 
            this.searchPatientsTabPage.Controls.Add(this.searchPatientUserControl1);
            this.searchPatientsTabPage.Location = new System.Drawing.Point(10, 63);
            this.searchPatientsTabPage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchPatientsTabPage.Name = "searchPatientsTabPage";
            this.searchPatientsTabPage.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchPatientsTabPage.Size = new System.Drawing.Size(2476, 1286);
            this.searchPatientsTabPage.TabIndex = 0;
            this.searchPatientsTabPage.Text = "Search Patients";
            this.searchPatientsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchPatientUserControl1
            // 
            this.searchPatientUserControl1.Location = new System.Drawing.Point(19, 19);
            this.searchPatientUserControl1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.searchPatientUserControl1.Name = "searchPatientUserControl1";
            this.searchPatientUserControl1.Size = new System.Drawing.Size(2437, 1242);
            this.searchPatientUserControl1.TabIndex = 0;
            // 
            // addPatientTabPage
            // 
            this.addPatientTabPage.Controls.Add(this.addPatientUserControl1);
            this.addPatientTabPage.Location = new System.Drawing.Point(10, 63);
            this.addPatientTabPage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addPatientTabPage.Name = "addPatientTabPage";
            this.addPatientTabPage.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addPatientTabPage.Size = new System.Drawing.Size(2476, 1286);
            this.addPatientTabPage.TabIndex = 1;
            this.addPatientTabPage.Text = "Add Patient";
            this.addPatientTabPage.UseVisualStyleBackColor = true;
            // 
            // addPatientUserControl1
            // 
            this.addPatientUserControl1.Location = new System.Drawing.Point(544, 55);
            this.addPatientUserControl1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.addPatientUserControl1.Name = "addPatientUserControl1";
            this.addPatientUserControl1.Size = new System.Drawing.Size(1469, 1207);
            this.addPatientUserControl1.TabIndex = 0;
            // 
            // testsTabPage
            // 
            this.testsTabPage.Controls.Add(this.viewLabTestByApptAndPIdUserControl1);
            this.testsTabPage.Location = new System.Drawing.Point(10, 63);
            this.testsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testsTabPage.Name = "testsTabPage";
            this.testsTabPage.Size = new System.Drawing.Size(2476, 1286);
            this.testsTabPage.TabIndex = 3;
            this.testsTabPage.Text = "LabTests Info";
            this.testsTabPage.UseVisualStyleBackColor = true;
            // 
            // viewLabTestByApptAndPIdUserControl1
            // 
            this.viewLabTestByApptAndPIdUserControl1.Location = new System.Drawing.Point(19, 29);
            this.viewLabTestByApptAndPIdUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.viewLabTestByApptAndPIdUserControl1.Name = "viewLabTestByApptAndPIdUserControl1";
            this.viewLabTestByApptAndPIdUserControl1.Size = new System.Drawing.Size(1954, 1080);
            this.viewLabTestByApptAndPIdUserControl1.TabIndex = 0;
            // 
            // visitInformationTabPage
            // 
            this.visitInformationTabPage.Controls.Add(this.visitInformationUserControl2);
            this.visitInformationTabPage.Controls.Add(this.visitInformationUserControl1);
            this.visitInformationTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitInformationTabPage.Location = new System.Drawing.Point(10, 63);
            this.visitInformationTabPage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.visitInformationTabPage.Name = "visitInformationTabPage";
            this.visitInformationTabPage.Size = new System.Drawing.Size(2476, 1286);
            this.visitInformationTabPage.TabIndex = 2;
            this.visitInformationTabPage.Text = "Visit Information";
            this.visitInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // visitInformationUserControl2
            // 
            this.visitInformationUserControl2.Location = new System.Drawing.Point(40, 43);
            this.visitInformationUserControl2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.visitInformationUserControl2.Name = "visitInformationUserControl2";
            this.visitInformationUserControl2.Nurse = null;
            this.visitInformationUserControl2.Size = new System.Drawing.Size(2384, 1188);
            this.visitInformationUserControl2.TabIndex = 1;
            // 
            // visitInformationUserControl1
            // 
            this.visitInformationUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitInformationUserControl1.Location = new System.Drawing.Point(-11, 0);
            this.visitInformationUserControl1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.visitInformationUserControl1.Name = "visitInformationUserControl1";
            this.visitInformationUserControl1.Nurse = null;
            this.visitInformationUserControl1.Size = new System.Drawing.Size(0, 0);
            this.visitInformationUserControl1.TabIndex = 0;
            // 
            // deletePatientTabPage
            // 
            this.deletePatientTabPage.Controls.Add(this.deletePatientUserControl1);
            this.deletePatientTabPage.Location = new System.Drawing.Point(10, 63);
            this.deletePatientTabPage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.deletePatientTabPage.Name = "deletePatientTabPage";
            this.deletePatientTabPage.Size = new System.Drawing.Size(2476, 1286);
            this.deletePatientTabPage.TabIndex = 4;
            this.deletePatientTabPage.Text = "Delete Patient";
            this.deletePatientTabPage.UseVisualStyleBackColor = true;
            // 
            // deletePatientUserControl1
            // 
            this.deletePatientUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientUserControl1.Location = new System.Drawing.Point(45, 57);
            this.deletePatientUserControl1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.deletePatientUserControl1.Name = "deletePatientUserControl1";
            this.deletePatientUserControl1.Size = new System.Drawing.Size(2381, 1178);
            this.deletePatientUserControl1.TabIndex = 0;
            // 
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2520, 1500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NurseDashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.nurseDashboardTabControl.ResumeLayout(false);
            this.searchPatientsTabPage.ResumeLayout(false);
            this.addPatientTabPage.ResumeLayout(false);
            this.testsTabPage.ResumeLayout(false);
            this.visitInformationTabPage.ResumeLayout(false);
            this.deletePatientTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl nurseDashboardTabControl;
        private System.Windows.Forms.TabPage searchPatientsTabPage;
        private System.Windows.Forms.TabPage addPatientTabPage;
        private System.Windows.Forms.TabPage visitInformationTabPage;
        private UserControls.VisitInformationUserControl visitInformationUserControl1;
        private UserControls.VisitInformationUserControl visitInformationUserControl2;
        private UserControls.SearchPatientUserControl searchPatientUserControl1;
        private System.Windows.Forms.TabPage testsTabPage;
        private System.Windows.Forms.TabPage deletePatientTabPage;
        private UserControls.DeletePatientUserControl deletePatientUserControl1;
        private UserControls.AddPatientUserControl addPatientUserControl1;
        private UserControls.ViewLabTestByApptAndPIdUserControl viewLabTestByApptAndPIdUserControl1;
    }
}