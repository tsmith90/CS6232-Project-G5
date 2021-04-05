
namespace ClinicSupport.UserControls
{
    partial class ViewAppointmentsByPatientIDUserControl
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
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.searchApptButton = new System.Windows.Forms.Button();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.newApptButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(34, 339);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 102;
            this.appointmentDataGridView.RowTemplate.Height = 40;
            this.appointmentDataGridView.Size = new System.Drawing.Size(1246, 514);
            this.appointmentDataGridView.TabIndex = 0;
            this.appointmentDataGridView.Visible = false;
            this.appointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGridView_CellContentClick);
            // 
            // searchApptButton
            // 
            this.searchApptButton.AutoSize = true;
            this.searchApptButton.Location = new System.Drawing.Point(480, 213);
            this.searchApptButton.Name = "searchApptButton";
            this.searchApptButton.Size = new System.Drawing.Size(140, 49);
            this.searchApptButton.TabIndex = 1;
            this.searchApptButton.Text = "Search";
            this.searchApptButton.UseVisualStyleBackColor = true;
            this.searchApptButton.Click += new System.EventHandler(this.SearchApptButton_Click);
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Location = new System.Drawing.Point(76, 135);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(307, 38);
            this.fnameTextBox.TabIndex = 2;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Location = new System.Drawing.Point(76, 224);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(307, 38);
            this.lnameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Birth:";
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(480, 134);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.ShowCheckBox = true;
            this.dobDateTimePicker.Size = new System.Drawing.Size(257, 38);
            this.dobDateTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(636, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search for Patient\'s Appointment";
            // 
            // newApptButton
            // 
            this.newApptButton.AutoSize = true;
            this.newApptButton.Enabled = false;
            this.newApptButton.Location = new System.Drawing.Point(1031, 265);
            this.newApptButton.Name = "newApptButton";
            this.newApptButton.Size = new System.Drawing.Size(249, 42);
            this.newApptButton.TabIndex = 9;
            this.newApptButton.Text = "New Appointment";
            this.newApptButton.UseVisualStyleBackColor = true;
            this.newApptButton.Click += new System.EventHandler(this.NewApptButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(663, 213);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(135, 49);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(76, 279);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 32);
            this.messageLabel.TabIndex = 11;
            // 
            // ViewAppointmentsByPatientIDUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.newApptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.searchApptButton);
            this.Controls.Add(this.appointmentDataGridView);
            this.Name = "ViewAppointmentsByPatientIDUserControl";
            this.Size = new System.Drawing.Size(1317, 897);
            this.Load += new System.EventHandler(this.ViewAppointmentsByPatientIDUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Button searchApptButton;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newApptButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label messageLabel;
    }
}
