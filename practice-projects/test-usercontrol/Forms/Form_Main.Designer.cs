namespace testUC
{
    partial class Form_Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.titlebar21 = new testUC.User_Controls.AppWindow.Titlebar2();
            this.titleBar1 = new testUC.TitleBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titlebar21
            // 
            this.titlebar21.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar21.Location = new System.Drawing.Point(0, 35);
            this.titlebar21.Name = "titlebar21";
            this.titlebar21.Size = new System.Drawing.Size(800, 40);
            this.titlebar21.TabIndex = 2;
            // 
            // titleBar1
            // 
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(800, 35);
            this.titleBar1.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlebar21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar1;
        private System.Windows.Forms.Button button1;
        private User_Controls.AppWindow.Titlebar2 titlebar21;
    }
}

