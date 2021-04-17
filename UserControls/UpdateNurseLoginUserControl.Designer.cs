
namespace ClinicSupport.UserControls
{
    partial class UpdateNurseLoginUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.findUserTextbox = new System.Windows.Forms.TextBox();
            this.findUserButton = new System.Windows.Forms.Button();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextbox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.updateLoginButton = new System.Windows.Forms.Button();
            this.newUsernameTextbox = new System.Windows.Forms.TextBox();
            this.newUsernameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.findUserTextbox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.findUserButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.newPasswordLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.newPasswordTextbox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.confirmPasswordLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.confirmPasswordTextbox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.updateLoginButton, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.newUsernameTextbox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.newUsernameLabel, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(109, 39);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(154, 29);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // findUserTextbox
            // 
            this.findUserTextbox.Location = new System.Drawing.Point(269, 42);
            this.findUserTextbox.Name = "findUserTextbox";
            this.findUserTextbox.Size = new System.Drawing.Size(219, 26);
            this.findUserTextbox.TabIndex = 1;
            this.findUserTextbox.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // findUserButton
            // 
            this.findUserButton.Location = new System.Drawing.Point(495, 42);
            this.findUserButton.Name = "findUserButton";
            this.findUserButton.Size = new System.Drawing.Size(96, 26);
            this.findUserButton.TabIndex = 2;
            this.findUserButton.Text = "Find User";
            this.findUserButton.UseVisualStyleBackColor = true;
            this.findUserButton.Click += new System.EventHandler(this.FindUserButton_Click);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Location = new System.Drawing.Point(109, 132);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(154, 25);
            this.newPasswordLabel.TabIndex = 5;
            this.newPasswordLabel.Text = "New Password:";
            this.newPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newPasswordTextbox
            // 
            this.newPasswordTextbox.Location = new System.Drawing.Point(269, 135);
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.Size = new System.Drawing.Size(220, 26);
            this.newPasswordTextbox.TabIndex = 6;
            this.newPasswordTextbox.UseSystemPasswordChar = true;
            this.newPasswordTextbox.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Location = new System.Drawing.Point(109, 177);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(154, 25);
            this.confirmPasswordLabel.TabIndex = 7;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            this.confirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(269, 180);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(220, 26);
            this.confirmPasswordTextbox.TabIndex = 8;
            this.confirmPasswordTextbox.UseSystemPasswordChar = true;
            this.confirmPasswordTextbox.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // errorLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.errorLabel, 4);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(23, 239);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(708, 30);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(109, 278);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 51);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // updateLoginButton
            // 
            this.updateLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateLoginButton.Location = new System.Drawing.Point(334, 278);
            this.updateLoginButton.Name = "updateLoginButton";
            this.updateLoginButton.Size = new System.Drawing.Size(155, 51);
            this.updateLoginButton.TabIndex = 11;
            this.updateLoginButton.Text = "Update Login";
            this.updateLoginButton.UseVisualStyleBackColor = true;
            this.updateLoginButton.Click += new System.EventHandler(this.UpdatePasswordButton_Click);
            // 
            // newUsernameTextbox
            // 
            this.newUsernameTextbox.Location = new System.Drawing.Point(269, 96);
            this.newUsernameTextbox.Name = "newUsernameTextbox";
            this.newUsernameTextbox.Size = new System.Drawing.Size(220, 26);
            this.newUsernameTextbox.TabIndex = 13;
            this.newUsernameTextbox.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // newUsernameLabel
            // 
            this.newUsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newUsernameLabel.Location = new System.Drawing.Point(109, 98);
            this.newUsernameLabel.Name = "newUsernameLabel";
            this.newUsernameLabel.Size = new System.Drawing.Size(154, 28);
            this.newUsernameLabel.TabIndex = 12;
            this.newUsernameLabel.Text = "New Username:";
            this.newUsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UpdateNursePasswordUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateNursePasswordUserControl";
            this.Size = new System.Drawing.Size(756, 352);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox findUserTextbox;
        private System.Windows.Forms.Button findUserButton;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextbox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextbox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button updateLoginButton;
        private System.Windows.Forms.TextBox newUsernameTextbox;
        private System.Windows.Forms.Label newUsernameLabel;
    }
}
