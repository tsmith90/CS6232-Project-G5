﻿namespace ClinicSupport.UserControls
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.normalGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.testOrderLabel = new System.Windows.Forms.Label();
            this.dateTakenLabel = new System.Windows.Forms.Label();
            this.dateReturnedLabel = new System.Windows.Forms.Label();
            this.normalLabel = new System.Windows.Forms.Label();
            this.testComboBox = new System.Windows.Forms.ComboBox();
            this.dateTakenTextBox = new System.Windows.Forms.TextBox();
            this.dateReturnedTextBox = new System.Windows.Forms.TextBox();
            this.resultTextArea = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateTestButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.visitDateTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.normalGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderTestTitleLabel
            // 
            this.orderTestTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderTestTitleLabel.AutoSize = true;
            this.orderTestTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTestTitleLabel.Location = new System.Drawing.Point(572, 41);
            this.orderTestTitleLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.orderTestTitleLabel.Name = "orderTestTitleLabel";
            this.orderTestTitleLabel.Size = new System.Drawing.Size(313, 46);
            this.orderTestTitleLabel.TabIndex = 0;
            this.orderTestTitleLabel.Text = "Update Lab Test";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1458, 201);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 129);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 32);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.03429F));
            this.tableLayoutPanel2.Controls.Add(this.visitDateTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.testOrderLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.testComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.normalGroupBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.normalLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.resultTextArea, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.resultLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.dateReturnedLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dateReturnedTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dateTakenTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dateTakenLabel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 201);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1458, 636);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // normalGroupBox
            // 
            this.normalGroupBox.Controls.Add(this.noRadioButton);
            this.normalGroupBox.Controls.Add(this.yesRadioButton);
            this.normalGroupBox.Location = new System.Drawing.Point(366, 539);
            this.normalGroupBox.Name = "normalGroupBox";
            this.normalGroupBox.Size = new System.Drawing.Size(344, 94);
            this.normalGroupBox.TabIndex = 5;
            this.normalGroupBox.TabStop = false;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(171, 27);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(88, 36);
            this.noRadioButton.TabIndex = 10;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(32, 26);
            this.yesRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(101, 36);
            this.yesRadioButton.TabIndex = 9;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // testOrderLabel
            // 
            this.testOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.testOrderLabel.AutoSize = true;
            this.testOrderLabel.Location = new System.Drawing.Point(167, 33);
            this.testOrderLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.testOrderLabel.Name = "testOrderLabel";
            this.testOrderLabel.Size = new System.Drawing.Size(188, 32);
            this.testOrderLabel.TabIndex = 0;
            this.testOrderLabel.Text = "Test to Order:";
            // 
            // dateTakenLabel
            // 
            this.dateTakenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTakenLabel.AutoSize = true;
            this.dateTakenLabel.Location = new System.Drawing.Point(186, 216);
            this.dateTakenLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dateTakenLabel.Name = "dateTakenLabel";
            this.dateTakenLabel.Size = new System.Drawing.Size(169, 32);
            this.dateTakenLabel.TabIndex = 1;
            this.dateTakenLabel.Text = "Date Taken:";
            // 
            // dateReturnedLabel
            // 
            this.dateReturnedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateReturnedLabel.AutoSize = true;
            this.dateReturnedLabel.Location = new System.Drawing.Point(148, 298);
            this.dateReturnedLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dateReturnedLabel.Name = "dateReturnedLabel";
            this.dateReturnedLabel.Size = new System.Drawing.Size(207, 32);
            this.dateReturnedLabel.TabIndex = 2;
            this.dateReturnedLabel.Text = "Date Returned:";
            // 
            // normalLabel
            // 
            this.normalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(241, 570);
            this.normalLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(114, 32);
            this.normalLabel.TabIndex = 4;
            this.normalLabel.Text = "Normal:";
            // 
            // testComboBox
            // 
            this.testComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.testComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testComboBox.FormattingEnabled = true;
            this.testComboBox.Location = new System.Drawing.Point(371, 29);
            this.testComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.testComboBox.Name = "testComboBox";
            this.testComboBox.Size = new System.Drawing.Size(636, 39);
            this.testComboBox.TabIndex = 5;
            // 
            // dateTakenTextBox
            // 
            this.dateTakenTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTakenTextBox.Location = new System.Drawing.Point(371, 213);
            this.dateTakenTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateTakenTextBox.Name = "dateTakenTextBox";
            this.dateTakenTextBox.Size = new System.Drawing.Size(316, 38);
            this.dateTakenTextBox.TabIndex = 6;
            // 
            // dateReturnedTextBox
            // 
            this.dateReturnedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateReturnedTextBox.Location = new System.Drawing.Point(371, 295);
            this.dateReturnedTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateReturnedTextBox.Name = "dateReturnedTextBox";
            this.dateReturnedTextBox.Size = new System.Drawing.Size(316, 38);
            this.dateReturnedTextBox.TabIndex = 7;
            // 
            // resultTextArea
            // 
            this.resultTextArea.Location = new System.Drawing.Point(371, 364);
            this.resultTextArea.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.resultTextArea.Multiline = true;
            this.resultTextArea.Name = "resultTextArea";
            this.resultTextArea.Size = new System.Drawing.Size(636, 144);
            this.resultTextArea.TabIndex = 8;
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(251, 357);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(104, 32);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.19616F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.53909F));
            this.tableLayoutPanel3.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.updateTestButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 837);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1458, 103);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(1113, 24);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 55);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // updateTestButton
            // 
            this.updateTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateTestButton.Location = new System.Drawing.Point(626, 24);
            this.updateTestButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.updateTestButton.Name = "updateTestButton";
            this.updateTestButton.Size = new System.Drawing.Size(200, 55);
            this.updateTestButton.TabIndex = 1;
            this.updateTestButton.Text = "Update";
            this.updateTestButton.UseVisualStyleBackColor = true;
            this.updateTestButton.Click += new System.EventHandler(this.UpdateTestButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(128, 823);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 32);
            this.messageLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Visit Date:";
            // 
            // visitDateTextBox
            // 
            this.visitDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.visitDateTextBox.Location = new System.Drawing.Point(371, 126);
            this.visitDateTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.visitDateTextBox.Name = "visitDateTextBox";
            this.visitDateTextBox.ReadOnly = true;
            this.visitDateTextBox.Size = new System.Drawing.Size(316, 38);
            this.visitDateTextBox.TabIndex = 10;
            // 
            // OrderTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "OrderTestUserControl";
            this.Size = new System.Drawing.Size(1458, 1217);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.normalGroupBox.ResumeLayout(false);
            this.normalGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button updateTestButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox normalGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.TextBox visitDateTextBox;
        private System.Windows.Forms.Label label1;
    }
}
