namespace testUI.Forms
{
    partial class CreateAccount_Form
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
            this.label3 = new System.Windows.Forms.Label();
            this.backToLoginLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.showPwCheckBox = new System.Windows.Forms.CheckBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.GetStartedLabel = new System.Windows.Forms.Label();
            this.idNumbertxt = new System.Windows.Forms.TextBox();
            this.IdNumberLabel = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.comPasswordtxt = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 65);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lorem Ipsum";
            // 
            // backToLoginLabel
            // 
            this.backToLoginLabel.AutoSize = true;
            this.backToLoginLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLoginLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.backToLoginLabel.Location = new System.Drawing.Point(125, 573);
            this.backToLoginLabel.Name = "backToLoginLabel";
            this.backToLoginLabel.Size = new System.Drawing.Size(104, 20);
            this.backToLoginLabel.TabIndex = 19;
            this.backToLoginLabel.Text = "Back to Login";
            this.backToLoginLabel.Click += new System.EventHandler(this.backToLoginLabel_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.SteelBlue;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(50, 528);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(251, 43);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // showPwCheckBox
            // 
            this.showPwCheckBox.AutoSize = true;
            this.showPwCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPwCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPwCheckBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPwCheckBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.showPwCheckBox.Location = new System.Drawing.Point(189, 491);
            this.showPwCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showPwCheckBox.Name = "showPwCheckBox";
            this.showPwCheckBox.Size = new System.Drawing.Size(119, 21);
            this.showPwCheckBox.TabIndex = 17;
            this.showPwCheckBox.Text = "Show Password";
            this.showPwCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailtxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailtxt.Location = new System.Drawing.Point(50, 302);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailtxt.Multiline = true;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(251, 28);
            this.emailtxt.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.emailLabel.Location = new System.Drawing.Point(46, 280);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 21);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email";
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernametxt.Location = new System.Drawing.Point(51, 152);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(0);
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(251, 28);
            this.usernametxt.TabIndex = 14;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.UsernameLabel.Location = new System.Drawing.Point(47, 130);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 21);
            this.UsernameLabel.TabIndex = 13;
            this.UsernameLabel.Text = "Username";
            // 
            // GetStartedLabel
            // 
            this.GetStartedLabel.AutoSize = true;
            this.GetStartedLabel.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetStartedLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.GetStartedLabel.Location = new System.Drawing.Point(44, 94);
            this.GetStartedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GetStartedLabel.Name = "GetStartedLabel";
            this.GetStartedLabel.Size = new System.Drawing.Size(200, 35);
            this.GetStartedLabel.TabIndex = 12;
            this.GetStartedLabel.Text = "Get Started";
            // 
            // idNumbertxt
            // 
            this.idNumbertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.idNumbertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idNumbertxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumbertxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idNumbertxt.Location = new System.Drawing.Point(50, 356);
            this.idNumbertxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idNumbertxt.Multiline = true;
            this.idNumbertxt.Name = "idNumbertxt";
            this.idNumbertxt.Size = new System.Drawing.Size(251, 28);
            this.idNumbertxt.TabIndex = 22;
            // 
            // IdNumberLabel
            // 
            this.IdNumberLabel.AutoSize = true;
            this.IdNumberLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.IdNumberLabel.Location = new System.Drawing.Point(46, 334);
            this.IdNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdNumberLabel.Name = "IdNumberLabel";
            this.IdNumberLabel.Size = new System.Drawing.Size(94, 21);
            this.IdNumberLabel.TabIndex = 21;
            this.IdNumberLabel.Text = "ID Number";
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordtxt.Location = new System.Drawing.Point(50, 408);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(251, 28);
            this.passwordtxt.TabIndex = 24;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.passwordLabel.Location = new System.Drawing.Point(46, 386);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 21);
            this.passwordLabel.TabIndex = 23;
            this.passwordLabel.Text = "Password";
            // 
            // comPasswordtxt
            // 
            this.comPasswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comPasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comPasswordtxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPasswordtxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comPasswordtxt.Location = new System.Drawing.Point(50, 461);
            this.comPasswordtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comPasswordtxt.Multiline = true;
            this.comPasswordtxt.Name = "comPasswordtxt";
            this.comPasswordtxt.Size = new System.Drawing.Size(251, 28);
            this.comPasswordtxt.TabIndex = 26;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(46, 437);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(147, 21);
            this.confirmPasswordLabel.TabIndex = 25;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.Controls.Add(this.exitButton);
            this.titleBarPanel.Location = new System.Drawing.Point(-2, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(359, 31);
            this.titleBarPanel.TabIndex = 27;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
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
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.exitButton.Location = new System.Drawing.Point(326, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 31);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lastnametxt
            // 
            this.lastnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.lastnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnametxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastnametxt.Location = new System.Drawing.Point(51, 256);
            this.lastnametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lastnametxt.Multiline = true;
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(251, 28);
            this.lastnametxt.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(47, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Last Name";
            // 
            // firstnametxt
            // 
            this.firstnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.firstnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnametxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.firstnametxt.Location = new System.Drawing.Point(51, 202);
            this.firstnametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstnametxt.Multiline = true;
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(251, 28);
            this.firstnametxt.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(47, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "First Name";
            // 
            // CreateAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 632);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.comPasswordtxt);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.idNumbertxt);
            this.Controls.Add(this.IdNumberLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backToLoginLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.showPwCheckBox);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.GetStartedLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(357, 632);
            this.MinimumSize = new System.Drawing.Size(357, 632);
            this.Name = "CreateAccount_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label backToLoginLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.CheckBox showPwCheckBox;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label GetStartedLabel;
        private System.Windows.Forms.TextBox idNumbertxt;
        private System.Windows.Forms.Label IdNumberLabel;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox comPasswordtxt;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.Label label2;
    }
}