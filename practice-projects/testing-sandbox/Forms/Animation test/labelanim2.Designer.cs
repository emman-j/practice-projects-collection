namespace testing1.Forms.Animation_test
{
    partial class labelanim2
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
            this.components = new System.ComponentModel.Container();
            this.animationtimer = new System.Windows.Forms.Timer(this.components);
            this.connectionanimlbl = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.connectionanimlbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // animationtimer
            // 
            this.animationtimer.Interval = 2000;
            this.animationtimer.Tick += new System.EventHandler(this.animationtimer_Tick);
            // 
            // connectionanimlbl
            // 
            this.connectionanimlbl.AutoSize = true;
            this.connectionanimlbl.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionanimlbl.Location = new System.Drawing.Point(267, 214);
            this.connectionanimlbl.Name = "connectionanimlbl";
            this.connectionanimlbl.Size = new System.Drawing.Size(220, 50);
            this.connectionanimlbl.TabIndex = 0;
            this.connectionanimlbl.Text = "Connecting";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(388, 277);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(286, 277);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // connectionanimlbl2
            // 
            this.connectionanimlbl2.AutoSize = true;
            this.connectionanimlbl2.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionanimlbl2.Location = new System.Drawing.Point(267, 112);
            this.connectionanimlbl2.Name = "connectionanimlbl2";
            this.connectionanimlbl2.Size = new System.Drawing.Size(220, 50);
            this.connectionanimlbl2.TabIndex = 3;
            this.connectionanimlbl2.Text = "Connecting";
            // 
            // labelanim2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 433);
            this.Controls.Add(this.connectionanimlbl2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.connectionanimlbl);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "labelanim2";
            this.Text = "label animation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.labelanim2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animationtimer;
        private System.Windows.Forms.Label connectionanimlbl;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label connectionanimlbl2;
    }
}