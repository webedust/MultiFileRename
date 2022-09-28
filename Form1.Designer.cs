namespace MultiFileRename
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonReplace = new System.Windows.Forms.Button();
            this.LabelDirectory = new System.Windows.Forms.Label();
            this.TB_Dir = new System.Windows.Forms.TextBox();
            this.TB_Find = new System.Windows.Forms.TextBox();
            this.TB_Replace = new System.Windows.Forms.TextBox();
            this.LabelFind = new System.Windows.Forms.Label();
            this.LabelReplace = new System.Windows.Forms.Label();
            this.ButtonFolder = new System.Windows.Forms.Button();
            this.TB_PatternStart = new System.Windows.Forms.TextBox();
            this.TB_PatternEnd = new System.Windows.Forms.TextBox();
            this.DB_FindType = new System.Windows.Forms.ComboBox();
            this.Lb_PatternStart = new System.Windows.Forms.Label();
            this.Lb_PatternEnd = new System.Windows.Forms.Label();
            this.CheckboxSpaceRemove = new System.Windows.Forms.CheckBox();
            this.ButtonOpenLog = new System.Windows.Forms.Button();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.CheckboxRenameDirs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonReplace
            // 
            this.ButtonReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonReplace.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonReplace.Location = new System.Drawing.Point(104, 180);
            this.ButtonReplace.Name = "ButtonReplace";
            this.ButtonReplace.Size = new System.Drawing.Size(125, 35);
            this.ButtonReplace.TabIndex = 0;
            this.ButtonReplace.Text = "Replace";
            this.ButtonReplace.UseVisualStyleBackColor = false;
            this.ButtonReplace.Click += new System.EventHandler(this.ButtonReplace_Click);
            // 
            // LabelDirectory
            // 
            this.LabelDirectory.AutoSize = true;
            this.LabelDirectory.Location = new System.Drawing.Point(12, 9);
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(86, 21);
            this.LabelDirectory.TabIndex = 1;
            this.LabelDirectory.Text = "Directory";
            // 
            // TB_Dir
            // 
            this.TB_Dir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TB_Dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Dir.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_Dir.Location = new System.Drawing.Point(104, 7);
            this.TB_Dir.MaxLength = 2000;
            this.TB_Dir.Name = "TB_Dir";
            this.TB_Dir.Size = new System.Drawing.Size(348, 29);
            this.TB_Dir.TabIndex = 2;
            // 
            // TB_Find
            // 
            this.TB_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TB_Find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Find.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_Find.Location = new System.Drawing.Point(104, 68);
            this.TB_Find.MaxLength = 1000;
            this.TB_Find.Name = "TB_Find";
            this.TB_Find.Size = new System.Drawing.Size(348, 29);
            this.TB_Find.TabIndex = 2;
            // 
            // TB_Replace
            // 
            this.TB_Replace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TB_Replace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Replace.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_Replace.Location = new System.Drawing.Point(104, 127);
            this.TB_Replace.MaxLength = 1000;
            this.TB_Replace.Name = "TB_Replace";
            this.TB_Replace.Size = new System.Drawing.Size(348, 29);
            this.TB_Replace.TabIndex = 2;
            this.TB_Replace.TextChanged += new System.EventHandler(this.TB_Replace_TextChanged);
            // 
            // LabelFind
            // 
            this.LabelFind.AutoSize = true;
            this.LabelFind.Location = new System.Drawing.Point(12, 70);
            this.LabelFind.Name = "LabelFind";
            this.LabelFind.Size = new System.Drawing.Size(47, 21);
            this.LabelFind.TabIndex = 1;
            this.LabelFind.Text = "Find";
            // 
            // LabelReplace
            // 
            this.LabelReplace.AutoSize = true;
            this.LabelReplace.Location = new System.Drawing.Point(12, 129);
            this.LabelReplace.Name = "LabelReplace";
            this.LabelReplace.Size = new System.Drawing.Size(81, 21);
            this.LabelReplace.TabIndex = 1;
            this.LabelReplace.Text = "Replace";
            // 
            // ButtonFolder
            // 
            this.ButtonFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonFolder.Location = new System.Drawing.Point(458, 7);
            this.ButtonFolder.Name = "ButtonFolder";
            this.ButtonFolder.Size = new System.Drawing.Size(125, 35);
            this.ButtonFolder.TabIndex = 0;
            this.ButtonFolder.Text = "Browse";
            this.ButtonFolder.UseVisualStyleBackColor = false;
            this.ButtonFolder.Click += new System.EventHandler(this.ButtonFolder_Click);
            // 
            // TB_PatternStart
            // 
            this.TB_PatternStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TB_PatternStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PatternStart.Enabled = false;
            this.TB_PatternStart.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_PatternStart.Location = new System.Drawing.Point(104, 68);
            this.TB_PatternStart.MaxLength = 5;
            this.TB_PatternStart.Name = "TB_PatternStart";
            this.TB_PatternStart.Size = new System.Drawing.Size(114, 29);
            this.TB_PatternStart.TabIndex = 3;
            this.TB_PatternStart.Text = "[";
            this.TB_PatternStart.Visible = false;
            this.TB_PatternStart.TextChanged += new System.EventHandler(this.TB_PatternStart_TextChanged);
            // 
            // TB_PatternEnd
            // 
            this.TB_PatternEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TB_PatternEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PatternEnd.Enabled = false;
            this.TB_PatternEnd.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_PatternEnd.Location = new System.Drawing.Point(338, 68);
            this.TB_PatternEnd.MaxLength = 5;
            this.TB_PatternEnd.Name = "TB_PatternEnd";
            this.TB_PatternEnd.Size = new System.Drawing.Size(114, 29);
            this.TB_PatternEnd.TabIndex = 4;
            this.TB_PatternEnd.Text = "]";
            this.TB_PatternEnd.Visible = false;
            // 
            // DB_FindType
            // 
            this.DB_FindType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DB_FindType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DB_FindType.ForeColor = System.Drawing.SystemColors.Control;
            this.DB_FindType.FormattingEnabled = true;
            this.DB_FindType.Items.AddRange(new object[] {
            "Text",
            "Pattern",
            "Prepend",
            "Append"});
            this.DB_FindType.Location = new System.Drawing.Point(458, 68);
            this.DB_FindType.MaxDropDownItems = 2;
            this.DB_FindType.Name = "DB_FindType";
            this.DB_FindType.Size = new System.Drawing.Size(125, 29);
            this.DB_FindType.TabIndex = 5;
            this.DB_FindType.Text = "Text";
            this.DB_FindType.SelectedIndexChanged += new System.EventHandler(this.DB_FindType_SelectedIndexChanged);
            // 
            // Lb_PatternStart
            // 
            this.Lb_PatternStart.AutoSize = true;
            this.Lb_PatternStart.Enabled = false;
            this.Lb_PatternStart.Location = new System.Drawing.Point(104, 44);
            this.Lb_PatternStart.Name = "Lb_PatternStart";
            this.Lb_PatternStart.Size = new System.Drawing.Size(114, 21);
            this.Lb_PatternStart.TabIndex = 6;
            this.Lb_PatternStart.Text = "Pattern Start";
            this.Lb_PatternStart.Visible = false;
            // 
            // Lb_PatternEnd
            // 
            this.Lb_PatternEnd.AutoSize = true;
            this.Lb_PatternEnd.Enabled = false;
            this.Lb_PatternEnd.Location = new System.Drawing.Point(343, 44);
            this.Lb_PatternEnd.Name = "Lb_PatternEnd";
            this.Lb_PatternEnd.Size = new System.Drawing.Size(109, 21);
            this.Lb_PatternEnd.TabIndex = 7;
            this.Lb_PatternEnd.Text = "Pattern End";
            this.Lb_PatternEnd.Visible = false;
            // 
            // CheckboxSpaceRemove
            // 
            this.CheckboxSpaceRemove.AutoSize = true;
            this.CheckboxSpaceRemove.Checked = true;
            this.CheckboxSpaceRemove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxSpaceRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckboxSpaceRemove.Location = new System.Drawing.Point(274, 190);
            this.CheckboxSpaceRemove.Name = "CheckboxSpaceRemove";
            this.CheckboxSpaceRemove.Size = new System.Drawing.Size(302, 25);
            this.CheckboxSpaceRemove.TabIndex = 8;
            this.CheckboxSpaceRemove.Text = "Remove orphaned space at start";
            this.CheckboxSpaceRemove.UseVisualStyleBackColor = true;
            this.CheckboxSpaceRemove.Visible = false;
            this.CheckboxSpaceRemove.CheckedChanged += new System.EventHandler(this.CheckboxSpaceRemove_CheckedChanged);
            // 
            // ButtonOpenLog
            // 
            this.ButtonOpenLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonOpenLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOpenLog.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonOpenLog.Location = new System.Drawing.Point(12, 180);
            this.ButtonOpenLog.Name = "ButtonOpenLog";
            this.ButtonOpenLog.Size = new System.Drawing.Size(60, 35);
            this.ButtonOpenLog.TabIndex = 9;
            this.ButtonOpenLog.Text = "Log";
            this.ButtonOpenLog.UseVisualStyleBackColor = false;
            this.ButtonOpenLog.Click += new System.EventHandler(this.ButtonOpenLog_Click);
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelVersion.Location = new System.Drawing.Point(0, 243);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(141, 15);
            this.LabelVersion.TabIndex = 10;
            this.LabelVersion.Text = "Version: YYYY-MM-DD";
            // 
            // CheckboxRenameDirs
            // 
            this.CheckboxRenameDirs.AutoSize = true;
            this.CheckboxRenameDirs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckboxRenameDirs.Location = new System.Drawing.Point(274, 220);
            this.CheckboxRenameDirs.Name = "CheckboxRenameDirs";
            this.CheckboxRenameDirs.Size = new System.Drawing.Size(163, 25);
            this.CheckboxRenameDirs.TabIndex = 11;
            this.CheckboxRenameDirs.Text = "Rename folders";
            this.CheckboxRenameDirs.UseVisualStyleBackColor = true;
            this.CheckboxRenameDirs.CheckedChanged += new System.EventHandler(this.CheckboxRenameDirs_CheckedChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ButtonReplace;
            this.AccessibleDescription = "Removes text from all file names in a directory and replaces it.";
            this.AccessibleName = "Multiple file renamer";
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(590, 257);
            this.Controls.Add(this.CheckboxRenameDirs);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.ButtonOpenLog);
            this.Controls.Add(this.CheckboxSpaceRemove);
            this.Controls.Add(this.Lb_PatternEnd);
            this.Controls.Add(this.Lb_PatternStart);
            this.Controls.Add(this.DB_FindType);
            this.Controls.Add(this.TB_PatternEnd);
            this.Controls.Add(this.TB_PatternStart);
            this.Controls.Add(this.ButtonFolder);
            this.Controls.Add(this.LabelReplace);
            this.Controls.Add(this.LabelFind);
            this.Controls.Add(this.TB_Replace);
            this.Controls.Add(this.TB_Find);
            this.Controls.Add(this.TB_Dir);
            this.Controls.Add(this.LabelDirectory);
            this.Controls.Add(this.ButtonReplace);
            this.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 300);
            this.MinimumSize = new System.Drawing.Size(610, 300);
            this.Name = "MainForm";
            this.Text = "Multi-File Renamer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonReplace;
        private System.Windows.Forms.Label LabelDirectory;
        private System.Windows.Forms.TextBox TB_Dir;
        private System.Windows.Forms.TextBox TB_Find;
        private System.Windows.Forms.TextBox TB_Replace;
        private System.Windows.Forms.Label LabelFind;
        private System.Windows.Forms.Label LabelReplace;
        private System.Windows.Forms.Button ButtonFolder;
        private System.Windows.Forms.TextBox TB_PatternStart;
        private System.Windows.Forms.TextBox TB_PatternEnd;
        private System.Windows.Forms.ComboBox DB_FindType;
        private System.Windows.Forms.Label Lb_PatternStart;
        private System.Windows.Forms.Label Lb_PatternEnd;
        private System.Windows.Forms.CheckBox CheckboxSpaceRemove;
        private System.Windows.Forms.Button ButtonOpenLog;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.CheckBox CheckboxRenameDirs;
    }
}

