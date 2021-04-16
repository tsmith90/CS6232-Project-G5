
namespace ClinicSupport.View
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.nurseInformationTabPage = new System.Windows.Forms.TabPage();
            this.viewUpdateNurseUserControl1 = new ClinicSupport.UserControls.ViewUpdateNurseUserControl();
            this.addNurseTabPage = new System.Windows.Forms.TabPage();
            this.addNurseUserControl1 = new ClinicSupport.UserControls.AddNurseUserControl();
            this.privilegeTabPage = new System.Windows.Forms.TabPage();
            this.nursePrivilegesUserControl1 = new ClinicSupport.UserControls.NursePrivilegesUserControl();
            this.nursePasswordTabPage = new System.Windows.Forms.TabPage();
            this.viewUpdateNurserUserControl1 = new ClinicSupport.UserControls.UpdateNursePasswordUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.adminTabControl.SuspendLayout();
            this.nurseInformationTabPage.SuspendLayout();
            this.addNurseTabPage.SuspendLayout();
            this.privilegeTabPage.SuspendLayout();
            this.nursePasswordTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.logoutLinkLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.adminTabControl, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 459);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(585, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 24);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(698, 20);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(72, 23);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // adminTabControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.adminTabControl, 3);
            this.adminTabControl.Controls.Add(this.nurseInformationTabPage);
            this.adminTabControl.Controls.Add(this.addNurseTabPage);
            this.adminTabControl.Controls.Add(this.privilegeTabPage);
            this.adminTabControl.Controls.Add(this.nursePasswordTabPage);
            this.adminTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(3, 49);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(767, 407);
            this.adminTabControl.TabIndex = 2;
            // 
            // nurseInformationTabPage
            // 
            this.nurseInformationTabPage.Controls.Add(this.viewUpdateNurseUserControl1);
            this.nurseInformationTabPage.Location = new System.Drawing.Point(4, 29);
            this.nurseInformationTabPage.Name = "nurseInformationTabPage";
            this.nurseInformationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nurseInformationTabPage.Size = new System.Drawing.Size(759, 374);
            this.nurseInformationTabPage.TabIndex = 0;
            this.nurseInformationTabPage.Text = "View/Update Nurse";
            this.nurseInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // viewUpdateNurseUserControl1
            // 
            this.viewUpdateNurseUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUpdateNurseUserControl1.Location = new System.Drawing.Point(0, 0);
            this.viewUpdateNurseUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewUpdateNurseUserControl1.Name = "viewUpdateNurseUserControl1";
            this.viewUpdateNurseUserControl1.Size = new System.Drawing.Size(763, 381);
            this.viewUpdateNurseUserControl1.TabIndex = 0;
            // 
            // addNurseTabPage
            // 
            this.addNurseTabPage.Controls.Add(this.addNurseUserControl1);
            this.addNurseTabPage.Location = new System.Drawing.Point(4, 22);
            this.addNurseTabPage.Name = "addNurseTabPage";
            this.addNurseTabPage.Size = new System.Drawing.Size(192, 74);
            this.addNurseTabPage.TabIndex = 2;
            this.addNurseTabPage.Text = "Add Nurse";
            this.addNurseTabPage.UseVisualStyleBackColor = true;
            // 
            // addNurseUserControl1
            // 
            this.addNurseUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addNurseUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addNurseUserControl1.Name = "addNurseUserControl1";
            this.addNurseUserControl1.Size = new System.Drawing.Size(914, 435);
            this.addNurseUserControl1.TabIndex = 0;
            // 
            // privilegeTabPage
            // 
            this.privilegeTabPage.Controls.Add(this.nursePrivilegesUserControl1);
            this.privilegeTabPage.Location = new System.Drawing.Point(4, 22);
            this.privilegeTabPage.Name = "privilegeTabPage";
            this.privilegeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.privilegeTabPage.Size = new System.Drawing.Size(192, 74);
            this.privilegeTabPage.TabIndex = 1;
            this.privilegeTabPage.Text = "Nurse Privileges";
            this.privilegeTabPage.UseVisualStyleBackColor = true;
            // 
            // nursePrivilegesUserControl1
            // 
            this.nursePrivilegesUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nursePrivilegesUserControl1.Location = new System.Drawing.Point(115, 8);
            this.nursePrivilegesUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nursePrivilegesUserControl1.Name = "nursePrivilegesUserControl1";
            this.nursePrivilegesUserControl1.Size = new System.Drawing.Size(570, 333);
            this.nursePrivilegesUserControl1.TabIndex = 0;
            // 
            // nursePasswordTabPage
            // 
            this.nursePasswordTabPage.Controls.Add(this.viewUpdateNurserUserControl1);
            this.nursePasswordTabPage.Location = new System.Drawing.Point(4, 22);
            this.nursePasswordTabPage.Name = "nursePasswordTabPage";
            this.nursePasswordTabPage.Size = new System.Drawing.Size(192, 74);
            this.nursePasswordTabPage.TabIndex = 3;
            this.nursePasswordTabPage.Text = "Update Nurse Password";
            this.nursePasswordTabPage.UseVisualStyleBackColor = true;
            // 
            // viewUpdateNurserUserControl1
            // 
            this.viewUpdateNurserUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUpdateNurserUserControl1.Location = new System.Drawing.Point(0, 0);
            this.viewUpdateNurserUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewUpdateNurserUserControl1.Name = "viewUpdateNurserUserControl1";
            this.viewUpdateNurserUserControl1.Size = new System.Drawing.Size(756, 352);
            this.viewUpdateNurserUserControl1.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.adminTabControl.ResumeLayout(false);
            this.nurseInformationTabPage.ResumeLayout(false);
            this.addNurseTabPage.ResumeLayout(false);
            this.privilegeTabPage.ResumeLayout(false);
            this.nursePasswordTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage nurseInformationTabPage;
        private System.Windows.Forms.TabPage privilegeTabPage;
        private UserControls.NursePrivilegesUserControl nursePrivilegesUserControl1;
        private System.Windows.Forms.TabPage addNurseTabPage;
        private UserControls.AddNurseUserControl addNurseUserControl1;
        private System.Windows.Forms.TabPage nursePasswordTabPage;
        private UserControls.UpdateNursePasswordUserControl viewUpdateNurserUserControl1;
        private UserControls.ViewUpdateNurseUserControl viewUpdateNurseUserControl1;
    }
}