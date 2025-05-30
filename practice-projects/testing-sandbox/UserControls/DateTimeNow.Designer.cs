namespace testing1.Forms
{
    partial class DateTimeNow
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
            this.timedate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timedate
            // 
            this.timedate.AutoSize = true;
            this.timedate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timedate.Location = new System.Drawing.Point(0, 0);
            this.timedate.Name = "timedate";
            this.timedate.Size = new System.Drawing.Size(84, 21);
            this.timedate.TabIndex = 0;
            this.timedate.Text = "DateTime";
            this.timedate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateTimeNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.timedate);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DateTimeNow";
            this.Size = new System.Drawing.Size(84, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timedate;
    }
}
