namespace testing1.Forms
{
    partial class A_syncTest
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
            this.titleBar1 = new testing1.UserControls.TitleBar();
            this.SuspendLayout();
            // 
            // titleBar1
            // 
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.titleBar1.ExitLabelBackColor = System.Drawing.Color.Transparent;
            this.titleBar1.ExitLabelTextColor = System.Drawing.Color.White;
            this.titleBar1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titleBar1.Location = new System.Drawing.Point(0, 416);
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
            // A_syncTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleBar1);
            this.Name = "A_syncTest";
            this.Text = "Test1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.A_syncTest_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.TitleBar titleBar1;
    }
}