namespace MultiFileRename
{
    partial class FormLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            this.logTextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // logTextbox
            // 
            this.logTextbox.BackColor = System.Drawing.Color.Black;
            this.logTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextbox.DetectUrls = false;
            this.logTextbox.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logTextbox.ForeColor = System.Drawing.Color.White;
            this.logTextbox.Location = new System.Drawing.Point(1, 1);
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ReadOnly = true;
            this.logTextbox.Size = new System.Drawing.Size(694, 246);
            this.logTextbox.TabIndex = 0;
            this.logTextbox.Text = "";
            // 
            // FormLog
            // 
            this.AccessibleDescription = "Logs actions performed by the program.";
            this.AccessibleName = "Multi-File Renamer log";
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(697, 249);
            this.Controls.Add(this.logTextbox);
            this.Font = new System.Drawing.Font("Liberation Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(717, 292);
            this.Name = "FormLog";
            this.Text = "Multi-File Renamer";
            this.Load += new System.EventHandler(this.FormLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox logTextbox;
    }
}

