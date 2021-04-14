namespace ClinicSupport.UserControls
{
    partial class SearchPatientUserControl
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
            this.searchPatientLblTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchPatientLabel = new System.Windows.Forms.Label();
            this.radioButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchDOBRadioButton = new System.Windows.Forms.RadioButton();
            this.searchFirstLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchDOBLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchCriteriaTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dobTextField = new System.Windows.Forms.TextBox();
            this.firstLastNameTextBox = new System.Windows.Forms.TextBox();
            this.dobLastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchDOBButton = new System.Windows.Forms.Button();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.searchDOBAndLastNameButton = new System.Windows.Forms.Button();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.clearSearchesButton = new System.Windows.Forms.Button();
            this.searchPatientLblTableLayout.SuspendLayout();
            this.radioButtonTableLayout.SuspendLayout();
            this.searchCriteriaTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPatientLblTableLayout
            // 
            this.searchPatientLblTableLayout.ColumnCount = 1;
            this.searchPatientLblTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchPatientLblTableLayout.Controls.Add(this.searchPatientLabel, 0, 0);
            this.searchPatientLblTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPatientLblTableLayout.Location = new System.Drawing.Point(0, 0);
            this.searchPatientLblTableLayout.Name = "searchPatientLblTableLayout";
            this.searchPatientLblTableLayout.RowCount = 1;
            this.searchPatientLblTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchPatientLblTableLayout.Size = new System.Drawing.Size(833, 30);
            this.searchPatientLblTableLayout.TabIndex = 0;
            // 
            // searchPatientLabel
            // 
            this.searchPatientLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchPatientLabel.AutoSize = true;
            this.searchPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientLabel.Location = new System.Drawing.Point(352, 4);
            this.searchPatientLabel.Name = "searchPatientLabel";
            this.searchPatientLabel.Size = new System.Drawing.Size(128, 22);
            this.searchPatientLabel.TabIndex = 0;
            this.searchPatientLabel.Text = "Search Patient";
            // 
            // radioButtonTableLayout
            // 
            this.radioButtonTableLayout.ColumnCount = 4;
            this.radioButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.34185F));
            this.radioButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.07466F));
            this.radioButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.82711F));
            this.radioButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.14931F));
            this.radioButtonTableLayout.Controls.Add(this.searchByLabel, 0, 0);
            this.radioButtonTableLayout.Controls.Add(this.searchDOBRadioButton, 1, 0);
            this.radioButtonTableLayout.Controls.Add(this.searchFirstLastNameRadioButton, 2, 0);
            this.radioButtonTableLayout.Controls.Add(this.searchDOBLastNameRadioButton, 3, 0);
            this.radioButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonTableLayout.Location = new System.Drawing.Point(0, 30);
            this.radioButtonTableLayout.Name = "radioButtonTableLayout";
            this.radioButtonTableLayout.RowCount = 1;
            this.radioButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.radioButtonTableLayout.Size = new System.Drawing.Size(833, 30);
            this.radioButtonTableLayout.TabIndex = 1;
            // 
            // searchByLabel
            // 
            this.searchByLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(30, 8);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(59, 13);
            this.searchByLabel.TabIndex = 0;
            this.searchByLabel.Text = "Search By:";
            // 
            // searchDOBRadioButton
            // 
            this.searchDOBRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchDOBRadioButton.AutoSize = true;
            this.searchDOBRadioButton.Location = new System.Drawing.Point(169, 6);
            this.searchDOBRadioButton.Name = "searchDOBRadioButton";
            this.searchDOBRadioButton.Size = new System.Drawing.Size(48, 17);
            this.searchDOBRadioButton.TabIndex = 1;
            this.searchDOBRadioButton.TabStop = true;
            this.searchDOBRadioButton.Text = "DOB";
            this.searchDOBRadioButton.UseVisualStyleBackColor = true;
            this.searchDOBRadioButton.CheckedChanged += new System.EventHandler(this.SearchDOBRadioButton_CheckedChanged);
            // 
            // searchFirstLastNameRadioButton
            // 
            this.searchFirstLastNameRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchFirstLastNameRadioButton.AutoSize = true;
            this.searchFirstLastNameRadioButton.Location = new System.Drawing.Point(340, 6);
            this.searchFirstLastNameRadioButton.Name = "searchFirstLastNameRadioButton";
            this.searchFirstLastNameRadioButton.Size = new System.Drawing.Size(119, 17);
            this.searchFirstLastNameRadioButton.TabIndex = 2;
            this.searchFirstLastNameRadioButton.TabStop = true;
            this.searchFirstLastNameRadioButton.Text = "First and Last Name";
            this.searchFirstLastNameRadioButton.UseVisualStyleBackColor = true;
            this.searchFirstLastNameRadioButton.CheckedChanged += new System.EventHandler(this.SearchFirstLastNameRadioButton_CheckedChanged);
            // 
            // searchDOBLastNameRadioButton
            // 
            this.searchDOBLastNameRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchDOBLastNameRadioButton.AutoSize = true;
            this.searchDOBLastNameRadioButton.Location = new System.Drawing.Point(621, 6);
            this.searchDOBLastNameRadioButton.Name = "searchDOBLastNameRadioButton";
            this.searchDOBLastNameRadioButton.Size = new System.Drawing.Size(123, 17);
            this.searchDOBLastNameRadioButton.TabIndex = 3;
            this.searchDOBLastNameRadioButton.TabStop = true;
            this.searchDOBLastNameRadioButton.Text = "Last Name and DOB";
            this.searchDOBLastNameRadioButton.UseVisualStyleBackColor = true;
            this.searchDOBLastNameRadioButton.CheckedChanged += new System.EventHandler(this.SearchDOBLastNameRadioButton_CheckedChanged);
            // 
            // searchCriteriaTableLayout
            // 
            this.searchCriteriaTableLayout.ColumnCount = 6;
            this.searchCriteriaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.searchCriteriaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.searchCriteriaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.searchCriteriaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.searchCriteriaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.searchCriteriaTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.searchCriteriaTableLayout.Controls.Add(this.dobTextField, 0, 0);
            this.searchCriteriaTableLayout.Controls.Add(this.firstLastNameTextBox, 2, 0);
            this.searchCriteriaTableLayout.Controls.Add(this.dobLastNameTextBox, 4, 0);
            this.searchCriteriaTableLayout.Controls.Add(this.searchDOBButton, 1, 0);
            this.searchCriteriaTableLayout.Controls.Add(this.searchNameButton, 3, 0);
            this.searchCriteriaTableLayout.Controls.Add(this.searchDOBAndLastNameButton, 5, 0);
            this.searchCriteriaTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchCriteriaTableLayout.Location = new System.Drawing.Point(0, 60);
            this.searchCriteriaTableLayout.Name = "searchCriteriaTableLayout";
            this.searchCriteriaTableLayout.RowCount = 1;
            this.searchCriteriaTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchCriteriaTableLayout.Size = new System.Drawing.Size(833, 41);
            this.searchCriteriaTableLayout.TabIndex = 2;
            // 
            // dobTextField
            // 
            this.dobTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobTextField.Location = new System.Drawing.Point(7, 10);
            this.dobTextField.Name = "dobTextField";
            this.dobTextField.Size = new System.Drawing.Size(124, 20);
            this.dobTextField.TabIndex = 0;
            // 
            // firstLastNameTextBox
            // 
            this.firstLastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstLastNameTextBox.Location = new System.Drawing.Point(280, 10);
            this.firstLastNameTextBox.Name = "firstLastNameTextBox";
            this.firstLastNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.firstLastNameTextBox.TabIndex = 1;
            // 
            // dobLastNameTextBox
            // 
            this.dobLastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobLastNameTextBox.Location = new System.Drawing.Point(559, 10);
            this.dobLastNameTextBox.Name = "dobLastNameTextBox";
            this.dobLastNameTextBox.Size = new System.Drawing.Size(123, 20);
            this.dobLastNameTextBox.TabIndex = 2;
            // 
            // searchDOBButton
            // 
            this.searchDOBButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchDOBButton.Location = new System.Drawing.Point(161, 9);
            this.searchDOBButton.Name = "searchDOBButton";
            this.searchDOBButton.Size = new System.Drawing.Size(91, 23);
            this.searchDOBButton.TabIndex = 3;
            this.searchDOBButton.Text = "Search by DOB";
            this.searchDOBButton.UseVisualStyleBackColor = true;
            this.searchDOBButton.Click += new System.EventHandler(this.SearchDOBButton_Click);
            // 
            // searchNameButton
            // 
            this.searchNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchNameButton.Location = new System.Drawing.Point(422, 9);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(122, 23);
            this.searchNameButton.TabIndex = 4;
            this.searchNameButton.Text = "Search by Name";
            this.searchNameButton.UseVisualStyleBackColor = true;
            this.searchNameButton.Click += new System.EventHandler(this.SearchNameButton_Click);
            // 
            // searchDOBAndLastNameButton
            // 
            this.searchDOBAndLastNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchDOBAndLastNameButton.Location = new System.Drawing.Point(695, 3);
            this.searchDOBAndLastNameButton.Name = "searchDOBAndLastNameButton";
            this.searchDOBAndLastNameButton.Size = new System.Drawing.Size(133, 35);
            this.searchDOBAndLastNameButton.TabIndex = 5;
            this.searchDOBAndLastNameButton.Text = "Search by Last Name and DOB";
            this.searchDOBAndLastNameButton.UseVisualStyleBackColor = true;
            this.searchDOBAndLastNameButton.Click += new System.EventHandler(this.SearchDOBAndLastNameButton_Click);
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AllowUserToAddRows = false;
            this.patientsDataGridView.AllowUserToDeleteRows = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(7, 136);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.ReadOnly = true;
            this.patientsDataGridView.Size = new System.Drawing.Size(780, 233);
            this.patientsDataGridView.TabIndex = 3;
            this.patientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDataGridView_CellContentClick);
            // 
            // clearSearchesButton
            // 
            this.clearSearchesButton.Location = new System.Drawing.Point(7, 107);
            this.clearSearchesButton.Name = "clearSearchesButton";
            this.clearSearchesButton.Size = new System.Drawing.Size(98, 23);
            this.clearSearchesButton.TabIndex = 4;
            this.clearSearchesButton.Text = "Clear Searches";
            this.clearSearchesButton.UseVisualStyleBackColor = true;
            this.clearSearchesButton.Click += new System.EventHandler(this.ClearSearchesButton_Click);
            // 
            // SearchPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearSearchesButton);
            this.Controls.Add(this.patientsDataGridView);
            this.Controls.Add(this.searchCriteriaTableLayout);
            this.Controls.Add(this.radioButtonTableLayout);
            this.Controls.Add(this.searchPatientLblTableLayout);
            this.Name = "SearchPatientUserControl";
            this.Size = new System.Drawing.Size(833, 415);
            this.searchPatientLblTableLayout.ResumeLayout(false);
            this.searchPatientLblTableLayout.PerformLayout();
            this.radioButtonTableLayout.ResumeLayout(false);
            this.radioButtonTableLayout.PerformLayout();
            this.searchCriteriaTableLayout.ResumeLayout(false);
            this.searchCriteriaTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel searchPatientLblTableLayout;
        private System.Windows.Forms.Label searchPatientLabel;
        private System.Windows.Forms.TableLayoutPanel radioButtonTableLayout;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.RadioButton searchDOBRadioButton;
        private System.Windows.Forms.RadioButton searchFirstLastNameRadioButton;
        private System.Windows.Forms.RadioButton searchDOBLastNameRadioButton;
        private System.Windows.Forms.TableLayoutPanel searchCriteriaTableLayout;
        private System.Windows.Forms.TextBox dobTextField;
        private System.Windows.Forms.TextBox firstLastNameTextBox;
        private System.Windows.Forms.TextBox dobLastNameTextBox;
        private System.Windows.Forms.Button searchDOBButton;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button searchDOBAndLastNameButton;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Button clearSearchesButton;
    }
}
