
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
            this.appointmentTabPage = new System.Windows.Forms.TabPage();
            this.viewAppointmentsByPatientIDUserControl1 = new ClinicSupport.UserControls.ViewAppointmentsByPatientIDUserControl();
            this.visitInformationTabPage = new System.Windows.Forms.TabPage();
            this.visitInformationUserControl2 = new ClinicSupport.UserControls.VisitInformationUserControl();
            this.visitInformationUserControl1 = new ClinicSupport.UserControls.VisitInformationUserControl();
            this.deletePatientTabPage = new System.Windows.Forms.TabPage();
            this.deletePatientUserControl1 = new ClinicSupport.UserControls.DeletePatientUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.nurseDashboardTabControl.SuspendLayout();
            this.searchPatientsTabPage.SuspendLayout();
            this.addPatientTabPage.SuspendLayout();
            this.appointmentTabPage.SuspendLayout();
            this.visitInformationTabPage.SuspendLayout();
            this.deletePatientTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 622);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(859, 12);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(77, 34);
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
            this.nurseDashboardTabControl.Controls.Add(this.appointmentTabPage);
            this.nurseDashboardTabControl.Controls.Add(this.visitInformationTabPage);
            this.nurseDashboardTabControl.Controls.Add(this.deletePatientTabPage);
            this.nurseDashboardTabControl.Location = new System.Drawing.Point(3, 49);
            this.nurseDashboardTabControl.Name = "nurseDashboardTabControl";
            this.nurseDashboardTabControl.SelectedIndex = 0;
            this.nurseDashboardTabControl.Size = new System.Drawing.Size(936, 570);
            this.nurseDashboardTabControl.TabIndex = 3;
            // 
            // searchPatientsTabPage
            // 
            this.searchPatientsTabPage.Controls.Add(this.searchPatientUserControl1);
            this.searchPatientsTabPage.Location = new System.Drawing.Point(4, 29);
            this.searchPatientsTabPage.Name = "searchPatientsTabPage";
            this.searchPatientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPatientsTabPage.Size = new System.Drawing.Size(928, 537);
            this.searchPatientsTabPage.TabIndex = 0;
            this.searchPatientsTabPage.Text = "Search Patients";
            this.searchPatientsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchPatientUserControl1
            // 
            this.searchPatientUserControl1.Location = new System.Drawing.Point(7, 8);
            this.searchPatientUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPatientUserControl1.Name = "searchPatientUserControl1";
            this.searchPatientUserControl1.Size = new System.Drawing.Size(914, 521);
            this.searchPatientUserControl1.TabIndex = 0;
            // 
            // addPatientTabPage
            // 
            this.addPatientTabPage.Controls.Add(this.addPatientUserControl1);
            this.addPatientTabPage.Location = new System.Drawing.Point(4, 29);
            this.addPatientTabPage.Name = "addPatientTabPage";
            this.addPatientTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPatientTabPage.Size = new System.Drawing.Size(928, 537);
            this.addPatientTabPage.TabIndex = 1;
            this.addPatientTabPage.Text = "Add Patient";
            this.addPatientTabPage.UseVisualStyleBackColor = true;
            // 
            // addPatientUserControl1
            // 
            this.addPatientUserControl1.Location = new System.Drawing.Point(189, 17);
            this.addPatientUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPatientUserControl1.Name = "addPatientUserControl1";
            this.addPatientUserControl1.Size = new System.Drawing.Size(582, 524);
            this.addPatientUserControl1.TabIndex = 0;
            // 
            // appointmentTabPage
            // 
            this.appointmentTabPage.Controls.Add(this.viewAppointmentsByPatientIDUserControl1);
            this.appointmentTabPage.Location = new System.Drawing.Point(4, 29);
            this.appointmentTabPage.Margin = new System.Windows.Forms.Padding(1);
            this.appointmentTabPage.Name = "appointmentTabPage";
            this.appointmentTabPage.Size = new System.Drawing.Size(928, 537);
            this.appointmentTabPage.TabIndex = 3;
            this.appointmentTabPage.Text = "Appointment Info";
            this.appointmentTabPage.UseVisualStyleBackColor = true;
            // 
            // viewAppointmentsByPatientIDUserControl1
            // 
            this.viewAppointmentsByPatientIDUserControl1.Location = new System.Drawing.Point(5, 7);
            this.viewAppointmentsByPatientIDUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.viewAppointmentsByPatientIDUserControl1.Name = "viewAppointmentsByPatientIDUserControl1";
            this.viewAppointmentsByPatientIDUserControl1.Size = new System.Drawing.Size(778, 539);
            this.viewAppointmentsByPatientIDUserControl1.TabIndex = 0;
            // 
            // visitInformationTabPage
            // 
            this.visitInformationTabPage.Controls.Add(this.visitInformationUserControl2);
            this.visitInformationTabPage.Controls.Add(this.visitInformationUserControl1);
            this.visitInformationTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitInformationTabPage.Location = new System.Drawing.Point(4, 29);
            this.visitInformationTabPage.Name = "visitInformationTabPage";
            this.visitInformationTabPage.Size = new System.Drawing.Size(928, 537);
            this.visitInformationTabPage.TabIndex = 2;
            this.visitInformationTabPage.Text = "Visit Information";
            this.visitInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // visitInformationUserControl2
            // 
            this.visitInformationUserControl2.Location = new System.Drawing.Point(15, 18);
            this.visitInformationUserControl2.Name = "visitInformationUserControl2";
            this.visitInformationUserControl2.Nurse = null;
            this.visitInformationUserControl2.Size = new System.Drawing.Size(894, 498);
            this.visitInformationUserControl2.TabIndex = 1;
            // 
            // visitInformationUserControl1
            // 
            this.visitInformationUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitInformationUserControl1.Location = new System.Drawing.Point(-4, 0);
            this.visitInformationUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visitInformationUserControl1.Name = "visitInformationUserControl1";
            this.visitInformationUserControl1.Nurse = null;
            this.visitInformationUserControl1.Size = new System.Drawing.Size(0, 0);
            this.visitInformationUserControl1.TabIndex = 0;
            // 
            // deletePatientTabPage
            // 
            this.deletePatientTabPage.Controls.Add(this.deletePatientUserControl1);
            this.deletePatientTabPage.Location = new System.Drawing.Point(4, 29);
            this.deletePatientTabPage.Name = "deletePatientTabPage";
            this.deletePatientTabPage.Size = new System.Drawing.Size(928, 537);
            this.deletePatientTabPage.TabIndex = 4;
            this.deletePatientTabPage.Text = "Delete Patient";
            this.deletePatientTabPage.UseVisualStyleBackColor = true;
            // 
            // deletePatientUserControl1
            // 
            this.deletePatientUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientUserControl1.Location = new System.Drawing.Point(17, 24);
            this.deletePatientUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletePatientUserControl1.Name = "deletePatientUserControl1";
            this.deletePatientUserControl1.Size = new System.Drawing.Size(893, 494);
            this.deletePatientUserControl1.TabIndex = 0;
            // 
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.appointmentTabPage.ResumeLayout(false);
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
        private UserControls.AddPatientUserControl addPatientUserControl1;
        private UserControls.SearchPatientUserControl searchPatientUserControl1;
        private System.Windows.Forms.TabPage appointmentTabPage;
        private UserControls.ViewAppointmentsByPatientIDUserControl viewAppointmentsByPatientIDUserControl1;
        private System.Windows.Forms.TabPage deletePatientTabPage;
        private UserControls.DeletePatientUserControl deletePatientUserControl1;
    }
}