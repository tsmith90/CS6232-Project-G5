namespace ClinicSupport.UserControls
{
    partial class AddLabTestUserControl
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.testOrderLabel = new System.Windows.Forms.Label();
            this.testComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.testListView = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.apptComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderTestTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(128, 906);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 32);
            this.messageLabel.TabIndex = 8;
            // 
            // orderTestButton
            // 
            this.orderTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderTestButton.Location = new System.Drawing.Point(449, 29);
            this.orderTestButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(200, 55);
            this.orderTestButton.TabIndex = 0;
            this.orderTestButton.Text = "Order";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.OrderTestButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(815, 29);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 55);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.orderTestButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 679);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1099, 114);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // testOrderLabel
            // 
            this.testOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.testOrderLabel.AutoSize = true;
            this.testOrderLabel.Location = new System.Drawing.Point(126, 136);
            this.testOrderLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.testOrderLabel.Name = "testOrderLabel";
            this.testOrderLabel.Size = new System.Drawing.Size(188, 32);
            this.testOrderLabel.TabIndex = 0;
            this.testOrderLabel.Text = "Test to Order:";
            // 
            // testComboBox
            // 
            this.testComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.testComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testComboBox.FormattingEnabled = true;
            this.testComboBox.Location = new System.Drawing.Point(330, 132);
            this.testComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.testComboBox.Name = "testComboBox";
            this.testComboBox.Size = new System.Drawing.Size(442, 39);
            this.testComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.24847F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.75153F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel2.Controls.Add(this.testListView, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.addButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.testComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.testOrderLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.apptComboBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1099, 529);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // testListView
            // 
            this.testListView.HideSelection = false;
            this.testListView.Location = new System.Drawing.Point(325, 208);
            this.testListView.Name = "testListView";
            this.testListView.Size = new System.Drawing.Size(452, 318);
            this.testListView.TabIndex = 6;
            this.testListView.UseCompatibleStateImageBehavior = false;
            this.testListView.View = System.Windows.Forms.View.List;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addButton.Location = new System.Drawing.Point(783, 124);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(177, 55);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select an Visit Date:";
            // 
            // apptComboBox
            // 
            this.apptComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.apptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apptComboBox.FormattingEnabled = true;
            this.apptComboBox.Location = new System.Drawing.Point(330, 29);
            this.apptComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.apptComboBox.Name = "apptComboBox";
            this.apptComboBox.Size = new System.Drawing.Size(442, 39);
            this.apptComboBox.TabIndex = 11;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 78);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 32);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.orderTestTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1099, 150);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // orderTestTitleLabel
            // 
            this.orderTestTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderTestTitleLabel.AutoSize = true;
            this.orderTestTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTestTitleLabel.Location = new System.Drawing.Point(406, 16);
            this.orderTestTitleLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.orderTestTitleLabel.Name = "orderTestTitleLabel";
            this.orderTestTitleLabel.Size = new System.Drawing.Size(286, 46);
            this.orderTestTitleLabel.TabIndex = 0;
            this.orderTestTitleLabel.Text = "Order Lab Test";
            // 
            // AddLabTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddLabTestUserControl";
            this.Size = new System.Drawing.Size(1099, 1021);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label testOrderLabel;
        private System.Windows.Forms.ComboBox testComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label orderTestTitleLabel;
        private System.Windows.Forms.ListView testListView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox apptComboBox;
    }
}
