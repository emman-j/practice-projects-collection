namespace testing1.UserControls
{
    partial class TitleBar
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
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.MaximizeLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.titleBarPanel.Controls.Add(this.MinimizeLabel);
            this.titleBarPanel.Controls.Add(this.MaximizeLabel);
            this.titleBarPanel.Controls.Add(this.ExitLabel);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBarPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(902, 34);
            this.titleBarPanel.TabIndex = 56;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.Color.White;
            this.MinimizeLabel.Location = new System.Drawing.Point(832, 0);
            this.MinimizeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(25, 34);
            this.MinimizeLabel.TabIndex = 13;
            this.MinimizeLabel.Text = "__";
            this.MinimizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            // 
            // MaximizeLabel
            // 
            this.MaximizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeLabel.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeLabel.ForeColor = System.Drawing.Color.White;
            this.MaximizeLabel.Location = new System.Drawing.Point(857, 0);
            this.MaximizeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeLabel.Name = "MaximizeLabel";
            this.MaximizeLabel.Size = new System.Drawing.Size(25, 34);
            this.MaximizeLabel.TabIndex = 2;
            this.MaximizeLabel.Text = "▢";
            this.MaximizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaximizeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExitLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(882, 0);
            this.ExitLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(20, 34);
            this.ExitLabel.TabIndex = 14;
            this.ExitLabel.Text = "X";
            this.ExitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleBarPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(902, 34);
            this.titleBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label MaximizeLabel;
    }
}
