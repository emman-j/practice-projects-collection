namespace testUI
{
    partial class Login_Form
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
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.GetStartedLabel = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.showPwCheckBox = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernametxt.Location = new System.Drawing.Point(54, 272);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(0);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(251, 22);
            this.usernametxt.TabIndex = 5;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.UsernameLabel.Location = new System.Drawing.Point(50, 250);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 21);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username";
            // 
            // GetStartedLabel
            // 
            this.GetStartedLabel.AutoSize = true;
            this.GetStartedLabel.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetStartedLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.GetStartedLabel.Location = new System.Drawing.Point(47, 201);
            this.GetStartedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GetStartedLabel.Name = "GetStartedLabel";
            this.GetStartedLabel.Size = new System.Drawing.Size(200, 35);
            this.GetStartedLabel.TabIndex = 3;
            this.GetStartedLabel.Text = "Get Started";
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordtxt.Location = new System.Drawing.Point(55, 323);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(251, 22);
            this.passwordtxt.TabIndex = 7;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.passwordLabel.Location = new System.Drawing.Point(50, 301);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 21);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // showPwCheckBox
            // 
            this.showPwCheckBox.AutoSize = true;
            this.showPwCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPwCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPwCheckBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPwCheckBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.showPwCheckBox.Location = new System.Drawing.Point(194, 353);
            this.showPwCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showPwCheckBox.Name = "showPwCheckBox";
            this.showPwCheckBox.Size = new System.Drawing.Size(119, 21);
            this.showPwCheckBox.TabIndex = 8;
            this.showPwCheckBox.Text = "Show Password";
            this.showPwCheckBox.UseVisualStyleBackColor = false;
            this.showPwCheckBox.CheckedChanged += new System.EventHandler(this.showPwCheckBox_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(54, 394);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(251, 43);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.createAccountLabel.Location = new System.Drawing.Point(110, 458);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(137, 20);
            this.createAccountLabel.TabIndex = 10;
            this.createAccountLabel.Text = "Create an Account";
            this.createAccountLabel.Click += new System.EventHandler(this.createAccountLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 65);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lorem Ipsum";
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
            this.exitButton.Location = new System.Drawing.Point(331, 0);
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
            this.titleBarPanel.Controls.Add(this.exitButton);
            this.titleBarPanel.Location = new System.Drawing.Point(-7, -1);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(364, 31);
            this.titleBarPanel.TabIndex = 13;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.showPwCheckBox);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.GetStartedLabel);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(357, 632);
            this.MinimumSize = new System.Drawing.Size(357, 632);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label GetStartedLabel;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.CheckBox showPwCheckBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Button button1;
    }
}