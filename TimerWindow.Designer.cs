namespace Productivity
{
    partial class TimerWindow
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
            this.timerLabel = new System.Windows.Forms.Label();
            this.timeSince = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(16, 10);
            this.timerLabel.MaximumSize = new System.Drawing.Size(90, 40);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(63, 17);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "0:00:00";
            // 
            // timeSince
            // 
            this.timeSince.AutoSize = true;
            this.timeSince.Location = new System.Drawing.Point(7, 34);
            this.timeSince.MaximumSize = new System.Drawing.Size(80, 0);
            this.timeSince.MinimumSize = new System.Drawing.Size(80, 0);
            this.timeSince.Name = "timeSince";
            this.timeSince.Size = new System.Drawing.Size(80, 13);
            this.timeSince.TabIndex = 1;
            this.timeSince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeSince.Click += new System.EventHandler(this.time_since_Click);
            // 
            // TimerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(94, 56);
            this.ControlBox = false;
            this.Controls.Add(this.timeSince);
            this.Controls.Add(this.timerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TimerWindow";
            this.ShowInTaskbar = false;
            this.Text = "Productive Time";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TimerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label timerLabel;
        public System.Windows.Forms.Label timeSince;

    }
}