
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.newApptButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.appointmentDataGridView.Location = new System.Drawing.Point(0, 308);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 102;
            this.appointmentDataGridView.RowTemplate.Height = 40;
            this.appointmentDataGridView.Size = new System.Drawing.Size(1344, 578);
            this.appointmentDataGridView.TabIndex = 0;
            this.appointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDataGridView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient\'s Appointment";
            // 
            // newApptButton
            // 
            this.newApptButton.AutoSize = true;
            this.newApptButton.Location = new System.Drawing.Point(1012, 116);
            this.newApptButton.Name = "newApptButton";
            this.newApptButton.Size = new System.Drawing.Size(268, 68);
            this.newApptButton.TabIndex = 9;
            this.newApptButton.Text = "New Appointment";
            this.newApptButton.UseVisualStyleBackColor = true;
            this.newApptButton.Click += new System.EventHandler(this.NewApptButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(45, 152);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 32);
            this.messageLabel.TabIndex = 11;
            // 
            // ViewAppointmentsByPatientIDUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.newApptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appointmentDataGridView);
            this.Name = "ViewAppointmentsByPatientIDUserControl";
            this.Size = new System.Drawing.Size(1344, 886);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newApptButton;
        private System.Windows.Forms.Label messageLabel;
    }
}
