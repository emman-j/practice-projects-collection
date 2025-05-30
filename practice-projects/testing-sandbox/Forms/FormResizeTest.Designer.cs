namespace testing1.Forms
{
    partial class FormResizeTest
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
            this.button2 = new System.Windows.Forms.Button();
            this.titleBar1 = new testing1.UserControls.TitleBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // titleBar1
            // 
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.ExitLabelBackColor = System.Drawing.Color.Transparent;
            this.titleBar1.ExitLabelTextColor = System.Drawing.Color.White;
            this.titleBar1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(4);
            this.titleBar1.MaximizeButtonVisible = true;
            this.titleBar1.MaximizeLabelBackColor = System.Drawing.Color.Transparent;
            this.titleBar1.MaximizeLabelTextColor = System.Drawing.Color.White;
            this.titleBar1.MinimizeLabelBackColor = System.Drawing.Color.Transparent;
            this.titleBar1.MinimizeLabelTextColor = System.Drawing.Color.White;
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.PanelBackColor = System.Drawing.Color.DodgerBlue;
            this.titleBar1.Size = new System.Drawing.Size(800, 34);
            this.titleBar1.TabIndex = 0;
            // 
            // FormResizeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(450, 150);
            this.Name = "FormResizeTest";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormResizeTest_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.TitleBar titleBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}