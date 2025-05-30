namespace testUI.Forms
{
    partial class Account_Manager
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
            this.exitButton = new System.Windows.Forms.Button();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.UserAcc_dataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idNumbertxt = new System.Windows.Forms.TextBox();
            this.IdNumberLabel = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.titleBarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAcc_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.AutoSize = true;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Silver;
            this.exitButton.Location = new System.Drawing.Point(885, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 31);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.titleBarPanel.Controls.Add(this.label1);
            this.titleBarPanel.Controls.Add(this.panel2);
            this.titleBarPanel.Controls.Add(this.exitButton);
            this.titleBarPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(917, 71);
            this.titleBarPanel.TabIndex = 28;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Account Manager";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 71);
            this.panel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 496);
            this.panel1.TabIndex = 29;
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeButton.FlatAppearance.BorderSize = 2;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(3, 31);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(163, 37);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // UserAcc_dataGridView
            // 
            this.UserAcc_dataGridView.AllowUserToAddRows = false;
            this.UserAcc_dataGridView.AllowUserToDeleteRows = false;
            this.UserAcc_dataGridView.AllowUserToResizeColumns = false;
            this.UserAcc_dataGridView.AllowUserToResizeRows = false;
            this.UserAcc_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UserAcc_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserAcc_dataGridView.Location = new System.Drawing.Point(199, 133);
            this.UserAcc_dataGridView.MultiSelect = false;
            this.UserAcc_dataGridView.Name = "UserAcc_dataGridView";
            this.UserAcc_dataGridView.ReadOnly = true;
            this.UserAcc_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UserAcc_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserAcc_dataGridView.ShowEditingIcon = false;
            this.UserAcc_dataGridView.Size = new System.Drawing.Size(457, 182);
            this.UserAcc_dataGridView.TabIndex = 31;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteButton.Location = new System.Drawing.Point(662, 276);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 39);
            this.deleteButton.TabIndex = 32;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(632, 483);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 40);
            this.addButton.TabIndex = 33;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lastnametxt
            // 
            this.lastnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.lastnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnametxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastnametxt.Location = new System.Drawing.Point(484, 433);
            this.lastnametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lastnametxt.Multiline = true;
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(251, 28);
            this.lastnametxt.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(480, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Last Name";
            // 
            // firstnametxt
            // 
            this.firstnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.firstnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnametxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.firstnametxt.Location = new System.Drawing.Point(199, 432);
            this.firstnametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstnametxt.Multiline = true;
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(251, 28);
            this.firstnametxt.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(195, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "First Name";
            // 
            // idNumbertxt
            // 
            this.idNumbertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.idNumbertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idNumbertxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumbertxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idNumbertxt.Location = new System.Drawing.Point(484, 383);
            this.idNumbertxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idNumbertxt.Multiline = true;
            this.idNumbertxt.Name = "idNumbertxt";
            this.idNumbertxt.Size = new System.Drawing.Size(251, 28);
            this.idNumbertxt.TabIndex = 42;
            // 
            // IdNumberLabel
            // 
            this.IdNumberLabel.AutoSize = true;
            this.IdNumberLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.IdNumberLabel.Location = new System.Drawing.Point(480, 361);
            this.IdNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdNumberLabel.Name = "IdNumberLabel";
            this.IdNumberLabel.Size = new System.Drawing.Size(94, 21);
            this.IdNumberLabel.TabIndex = 41;
            this.IdNumberLabel.Text = "ID Number";
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailtxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailtxt.Location = new System.Drawing.Point(199, 483);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailtxt.Multiline = true;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(251, 28);
            this.emailtxt.TabIndex = 37;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.emailLabel.Location = new System.Drawing.Point(195, 410);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 21);
            this.emailLabel.TabIndex = 36;
            this.emailLabel.Text = "Email";
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernametxt.Location = new System.Drawing.Point(199, 382);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(0);
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(251, 28);
            this.usernametxt.TabIndex = 35;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.UsernameLabel.Location = new System.Drawing.Point(195, 360);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 21);
            this.UsernameLabel.TabIndex = 34;
            this.UsernameLabel.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(195, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "User Accounts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(195, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "Email";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(662, 230);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 40);
            this.updateButton.TabIndex = 52;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(480, 461);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Role";
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleComboBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "User",
            "Moderator",
            "Admin"});
            this.roleComboBox.Location = new System.Drawing.Point(482, 483);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 29);
            this.roleComboBox.TabIndex = 54;
            // 
            // Account_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 567);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idNumbertxt);
            this.Controls.Add(this.IdNumberLabel);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.UserAcc_dataGridView);
            this.Controls.Add(this.titleBarPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(917, 567);
            this.MinimumSize = new System.Drawing.Size(917, 567);
            this.Name = "Account_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account_Manager";
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserAcc_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView UserAcc_dataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idNumbertxt;
        private System.Windows.Forms.Label IdNumberLabel;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox roleComboBox;
    }
}