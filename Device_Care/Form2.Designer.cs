namespace Device_Care
{
    partial class Form2
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
            this.progressRing1 = new Device_Care.CustomControls.ProgressRing();
            this.SuspendLayout();
            // 
            // progressRing1
            // 
            this.progressRing1.EllipseWidth = 8F;
            this.progressRing1.Interval = 1;
            this.progressRing1.IsIndeterminate = true;
            this.progressRing1.Location = new System.Drawing.Point(196, 79);
            this.progressRing1.MaxValue = 100F;
            this.progressRing1.Name = "progressRing1";
            this.progressRing1.Size = new System.Drawing.Size(177, 136);
            this.progressRing1.TabIndex = 0;
            this.progressRing1.Text = "progressRing1";
            this.progressRing1.Value = 0F;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 304);
            this.Controls.Add(this.progressRing1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ProgressRing progressRing1;
    }
}