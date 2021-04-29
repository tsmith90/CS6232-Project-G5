
namespace ClinicSupport.UserControls
{
    partial class DeletePatientUserControl
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
            this.closeButton = new System.Windows.Forms.Button();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.stateTextbox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(733, 819);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(173, 57);
            this.closeButton.TabIndex = 27;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(114, 588);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(356, 53);
            this.dateTextBox.TabIndex = 26;
            // 
            // stateTextbox
            // 
            this.stateTextbox.Location = new System.Drawing.Point(513, 453);
            this.stateTextbox.Name = "stateTextbox";
            this.stateTextbox.Size = new System.Drawing.Size(281, 53);
            this.stateTextbox.TabIndex = 25;
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(105, 671);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(1022, 104);
            this.errorLabel.TabIndex = 24;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(855, 588);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(272, 53);
            this.phoneTextBox.TabIndex = 22;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(843, 453);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(226, 53);
            this.zipTextBox.TabIndex = 17;
            this.zipTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(114, 326);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(356, 53);
            this.addressTextBox.TabIndex = 11;
            this.addressTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(513, 588);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(313, 53);
            this.ssnTextBox.TabIndex = 21;
            this.ssnTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(113, 453);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(357, 53);
            this.cityTextBox.TabIndex = 12;
            this.cityTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(504, 201);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(313, 53);
            this.lastNameTextBox.TabIndex = 10;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(114, 201);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(297, 53);
            this.firstNameTextBox.TabIndex = 9;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 54);
            this.label1.TabIndex = 28;
            this.label1.Text = "Delete Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 46);
            this.label2.TabIndex = 29;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 46);
            this.label3.TabIndex = 30;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 46);
            this.label4.TabIndex = 31;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 46);
            this.label5.TabIndex = 32;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 46);
            this.label6.TabIndex = 33;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(835, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 46);
            this.label7.TabIndex = 34;
            this.label7.Text = "Zip Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 46);
            this.label8.TabIndex = 35;
            this.label8.Text = "Date of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(505, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 46);
            this.label9.TabIndex = 36;
            this.label9.Text = "SSN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(848, 528);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 46);
            this.label10.TabIndex = 37;
            this.label10.Text = "Phone";
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.AutoSize = true;
            this.deletePatientButton.Location = new System.Drawing.Point(338, 819);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(280, 56);
            this.deletePatientButton.TabIndex = 38;
            this.deletePatientButton.Text = "Delete Patient";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            this.deletePatientButton.Click += new System.EventHandler(this.DeletePatientButton_Click);
            // 
            // DeletePatientUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.stateTextbox);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeletePatientUserControl";
            this.Size = new System.Drawing.Size(1303, 925);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox stateTextbox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button deletePatientButton;
    }
}
