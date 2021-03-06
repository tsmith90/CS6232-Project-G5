﻿using ClinicSupport.Controller;
using ClinicSupport.Model;
using System.Windows.Forms;

namespace ClinicSupport.View
{
    /// <summary>
    /// Class Form to show Admin UserControls and options
    /// </summary>
    public partial class AdminDashboard : Form
    {
        private Administrator administrator;
        private readonly AdministratorController administratorController;

        /// <summary>
        /// 0-parameter constructor for the AdminDashboard class
        /// </summary>
        public AdminDashboard()
        {
            InitializeComponent();
            administrator = new Administrator();
            administratorController = new AdministratorController();
        }

        /// <summary>
        /// Method to set the userLabel upon login
        /// </summary>
        /// <param name = "user">the name of the user</param> 
        public void SetUser(string user)
        {
            usernameLabel.Text = "Username: " + user;
            administrator = administratorController.GetAdminByUsername(user);
            nameLabel.Text = "Welcome " + administrator.FirstName + " " + administrator.LastName + "!";
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (adminTabControl.SelectedTab == adminTabControl.TabPages["nurseInformationTabPage"])
            {
                this.viewUpdateNurseUserControl1.ClearControls();
                this.viewUpdateNurseUserControl1.SetControls();
            }
            else if (adminTabControl.SelectedTab == adminTabControl.TabPages["addNurseTabPage"])
            {
                this.addNurseUserControl1.ClearControls();
            }
            else if (adminTabControl.SelectedTab == adminTabControl.TabPages["privilegeTabPage"])
            {
                this.nursePrivilegesUserControl1.CloseControls();
                this.nursePrivilegesUserControl1.ClearControls();
            }
            else if (adminTabControl.SelectedTab == adminTabControl.TabPages["nurseLoginTabPage"])
            {
                this.viewUpdateNurserUserControl1.ClearControls();
                this.viewUpdateNurserUserControl1.SetControls();
            }
        }
    }
}
