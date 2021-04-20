namespace ClinicSupport.UserControls
{
    partial class OrderTestUserControl
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
            this.orderTestTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.testOrderLabel = new System.Windows.Forms.Label();
            this.dateTakenLabel = new System.Windows.Forms.Label();
            this.dateReturnedLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.normalLabel = new System.Windows.Forms.Label();
            this.testComboBox = new System.Windows.Forms.ComboBox();
            this.dateTakenTextBox = new System.Windows.Forms.TextBox();
            this.dateReturnedTextBox = new System.Windows.Forms.TextBox();
            this.resultTextArea = new System.Windows.Forms.TextBox();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.updateTestButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderTestTitleLabel
            // 
            this.orderTestTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderTestTitleLabel.AutoSize = true;
            this.orderTestTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTestTitleLabel.Location = new System.Drawing.Point(141, 12);
            this.orderTestTitleLabel.Name = "orderTestTitleLabel";
            this.orderTestTitleLabel.Size = new System.Drawing.Size(115, 20);
            this.orderTestTitleLabel.TabIndex = 0;
            this.orderTestTitleLabel.Text = "Order Lab Test";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.orderTestTitleLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 45);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.testOrderLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTakenLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateReturnedLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.resultLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.normalLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.testComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTakenTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateReturnedTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.resultTextArea, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.yesRadioButton, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(397, 207);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // testOrderLabel
            // 
            this.testOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.testOrderLabel.AutoSize = true;
            this.testOrderLabel.Location = new System.Drawing.Point(123, 11);
            this.testOrderLabel.Name = "testOrderLabel";
            this.testOrderLabel.Size = new System.Drawing.Size(72, 13);
            this.testOrderLabel.TabIndex = 0;
            this.testOrderLabel.Text = "Test to Order:";
            // 
            // dateTakenLabel
            // 
            this.dateTakenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTakenLabel.AutoSize = true;
            this.dateTakenLabel.Location = new System.Drawing.Point(128, 46);
            this.dateTakenLabel.Name = "dateTakenLabel";
            this.dateTakenLabel.Size = new System.Drawing.Size(67, 13);
            this.dateTakenLabel.TabIndex = 1;
            this.dateTakenLabel.Text = "Date Taken:";
            // 
            // dateReturnedLabel
            // 
            this.dateReturnedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateReturnedLabel.AutoSize = true;
            this.dateReturnedLabel.Location = new System.Drawing.Point(115, 81);
            this.dateReturnedLabel.Name = "dateReturnedLabel";
            this.dateReturnedLabel.Size = new System.Drawing.Size(80, 13);
            this.dateReturnedLabel.TabIndex = 2;
            this.dateReturnedLabel.Text = "Date Returned:";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(155, 105);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result:";
            // 
            // normalLabel
            // 
            this.normalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(152, 181);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(43, 13);
            this.normalLabel.TabIndex = 4;
            this.normalLabel.Text = "Normal:";
            // 
            // testComboBox
            // 
            this.testComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.testComboBox.FormattingEnabled = true;
            this.testComboBox.Location = new System.Drawing.Point(201, 7);
            this.testComboBox.Name = "testComboBox";
            this.testComboBox.Size = new System.Drawing.Size(121, 21);
            this.testComboBox.TabIndex = 5;
            // 
            // dateTakenTextBox
            // 
            this.dateTakenTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTakenTextBox.Location = new System.Drawing.Point(201, 42);
            this.dateTakenTextBox.Name = "dateTakenTextBox";
            this.dateTakenTextBox.Size = new System.Drawing.Size(121, 20);
            this.dateTakenTextBox.TabIndex = 6;
            // 
            // dateReturnedTextBox
            // 
            this.dateReturnedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateReturnedTextBox.Location = new System.Drawing.Point(201, 77);
            this.dateReturnedTextBox.Name = "dateReturnedTextBox";
            this.dateReturnedTextBox.Size = new System.Drawing.Size(121, 20);
            this.dateReturnedTextBox.TabIndex = 7;
            // 
            // resultTextArea
            // 
            this.resultTextArea.Location = new System.Drawing.Point(201, 108);
            this.resultTextArea.Multiline = true;
            this.resultTextArea.Name = "resultTextArea";
            this.resultTextArea.Size = new System.Drawing.Size(121, 55);
            this.resultTextArea.TabIndex = 8;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(201, 179);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.yesRadioButton.TabIndex = 9;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.orderTestButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.updateTestButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 252);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(397, 48);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // orderTestButton
            // 
            this.orderTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderTestButton.Location = new System.Drawing.Point(160, 12);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(75, 23);
            this.orderTestButton.TabIndex = 0;
            this.orderTestButton.Text = "Order";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.OrderTestButton_Click);
            // 
            // updateTestButton
            // 
            this.updateTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateTestButton.Location = new System.Drawing.Point(28, 12);
            this.updateTestButton.Name = "updateTestButton";
            this.updateTestButton.Size = new System.Drawing.Size(75, 23);
            this.updateTestButton.TabIndex = 1;
            this.updateTestButton.Text = "Update";
            this.updateTestButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(293, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(48, 345);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 4;
            // 
            // OrderTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderTestUserControl";
            this.Size = new System.Drawing.Size(397, 407);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderTestTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label testOrderLabel;
        private System.Windows.Forms.Label dateTakenLabel;
        private System.Windows.Forms.Label dateReturnedLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.ComboBox testComboBox;
        private System.Windows.Forms.TextBox dateTakenTextBox;
        private System.Windows.Forms.TextBox dateReturnedTextBox;
        private System.Windows.Forms.TextBox resultTextArea;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.Button updateTestButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label messageLabel;
    }
}
