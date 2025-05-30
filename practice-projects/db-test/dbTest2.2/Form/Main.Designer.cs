namespace dbTest2
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.customerTab = new System.Windows.Forms.TabPage();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerFoundListbox = new System.Windows.Forms.ListBox();
            this.customerSearchButton = new System.Windows.Forms.Button();
            this.searchCountrytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeFoundListbox = new System.Windows.Forms.ListBox();
            this.employeeSearchButton = new System.Windows.Forms.Button();
            this.searchEmployeetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.customerTab);
            this.tabControl1.Controls.Add(this.employeeTab);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.customerDataGridView);
            this.customerTab.Controls.Add(this.customerFoundListbox);
            this.customerTab.Controls.Add(this.customerSearchButton);
            this.customerTab.Controls.Add(this.searchCountrytxt);
            this.customerTab.Controls.Add(this.label1);
            this.customerTab.Location = new System.Drawing.Point(4, 22);
            this.customerTab.Name = "customerTab";
            this.customerTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerTab.Size = new System.Drawing.Size(510, 425);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "Customer";
            this.customerTab.UseVisualStyleBackColor = true;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(34, 238);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.Size = new System.Drawing.Size(445, 180);
            this.customerDataGridView.TabIndex = 9;
            // 
            // customerFoundListbox
            // 
            this.customerFoundListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerFoundListbox.FormattingEnabled = true;
            this.customerFoundListbox.Location = new System.Drawing.Point(34, 47);
            this.customerFoundListbox.Name = "customerFoundListbox";
            this.customerFoundListbox.Size = new System.Drawing.Size(445, 173);
            this.customerFoundListbox.TabIndex = 8;
            this.customerFoundListbox.SelectedIndexChanged += new System.EventHandler(this.customerFoundListbox_SelectedIndexChanged);
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.Location = new System.Drawing.Point(273, 14);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new System.Drawing.Size(75, 23);
            this.customerSearchButton.TabIndex = 7;
            this.customerSearchButton.Text = "Search";
            this.customerSearchButton.UseVisualStyleBackColor = true;
            this.customerSearchButton.Click += new System.EventHandler(this.customerSearchButton_Click);
            // 
            // searchCountrytxt
            // 
            this.searchCountrytxt.Location = new System.Drawing.Point(167, 17);
            this.searchCountrytxt.Name = "searchCountrytxt";
            this.searchCountrytxt.Size = new System.Drawing.Size(100, 20);
            this.searchCountrytxt.TabIndex = 6;
            this.searchCountrytxt.TextChanged += new System.EventHandler(this.searchCountrytxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find Customer by Country";
            // 
            // employeeTab
            // 
            this.employeeTab.Controls.Add(this.employeeDataGridView);
            this.employeeTab.Controls.Add(this.employeeFoundListbox);
            this.employeeTab.Controls.Add(this.employeeSearchButton);
            this.employeeTab.Controls.Add(this.searchEmployeetxt);
            this.employeeTab.Controls.Add(this.label2);
            this.employeeTab.Location = new System.Drawing.Point(4, 22);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTab.Size = new System.Drawing.Size(510, 425);
            this.employeeTab.TabIndex = 1;
            this.employeeTab.Text = "Employee";
            this.employeeTab.UseVisualStyleBackColor = true;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(34, 238);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.Size = new System.Drawing.Size(445, 180);
            this.employeeDataGridView.TabIndex = 14;
            // 
            // employeeFoundListbox
            // 
            this.employeeFoundListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeFoundListbox.FormattingEnabled = true;
            this.employeeFoundListbox.Location = new System.Drawing.Point(34, 47);
            this.employeeFoundListbox.Name = "employeeFoundListbox";
            this.employeeFoundListbox.Size = new System.Drawing.Size(445, 173);
            this.employeeFoundListbox.TabIndex = 13;
            // 
            // employeeSearchButton
            // 
            this.employeeSearchButton.Location = new System.Drawing.Point(284, 14);
            this.employeeSearchButton.Name = "employeeSearchButton";
            this.employeeSearchButton.Size = new System.Drawing.Size(75, 23);
            this.employeeSearchButton.TabIndex = 12;
            this.employeeSearchButton.Text = "Search";
            this.employeeSearchButton.UseVisualStyleBackColor = true;
            this.employeeSearchButton.Click += new System.EventHandler(this.employeeSearchButton_Click);
            // 
            // searchEmployeetxt
            // 
            this.searchEmployeetxt.Location = new System.Drawing.Point(178, 17);
            this.searchEmployeetxt.Name = "searchEmployeetxt";
            this.searchEmployeetxt.Size = new System.Drawing.Size(100, 20);
            this.searchEmployeetxt.TabIndex = 11;
            this.searchEmployeetxt.TextChanged += new System.EventHandler(this.searchEmployeetxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Find Employee by Last Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(510, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(510, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(510, 425);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.customerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.employeeTab.ResumeLayout(false);
            this.employeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage customerTab;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.ListBox customerFoundListbox;
        private System.Windows.Forms.Button customerSearchButton;
        private System.Windows.Forms.TextBox searchCountrytxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.ListBox employeeFoundListbox;
        private System.Windows.Forms.Button employeeSearchButton;
        private System.Windows.Forms.TextBox searchEmployeetxt;
        private System.Windows.Forms.Label label2;
    }
}

