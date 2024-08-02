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
            ButtonReplace = new System.Windows.Forms.Button();
            LabelDirectory = new System.Windows.Forms.Label();
            TB_Dir = new System.Windows.Forms.TextBox();
            TB_Find = new System.Windows.Forms.TextBox();
            TB_Replace = new System.Windows.Forms.TextBox();
            LabelFind = new System.Windows.Forms.Label();
            LabelReplace = new System.Windows.Forms.Label();
            ButtonFolder = new System.Windows.Forms.Button();
            TB_PatternStart = new System.Windows.Forms.TextBox();
            TB_PatternEnd = new System.Windows.Forms.TextBox();
            DB_FindType = new System.Windows.Forms.ComboBox();
            Lb_PatternStart = new System.Windows.Forms.Label();
            Lb_PatternEnd = new System.Windows.Forms.Label();
            CheckboxSpaceRemove = new System.Windows.Forms.CheckBox();
            ButtonOpenLog = new System.Windows.Forms.Button();
            LabelVersion = new System.Windows.Forms.Label();
            CheckboxRenameDirs = new System.Windows.Forms.CheckBox();
            ButtonSwap = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ButtonReplace
            // 
            ButtonReplace.BackColor = System.Drawing.Color.FromArgb(72, 72, 72);
            ButtonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ButtonReplace.ForeColor = System.Drawing.SystemColors.Control;
            ButtonReplace.Location = new System.Drawing.Point(104, 182);
            ButtonReplace.Name = "ButtonReplace";
            ButtonReplace.Size = new System.Drawing.Size(125, 35);
            ButtonReplace.TabIndex = 8;
            ButtonReplace.Text = "Replace";
            ButtonReplace.UseVisualStyleBackColor = false;
            ButtonReplace.Click += ButtonReplace_Click;
            // 
            // LabelDirectory
            // 
            LabelDirectory.AutoSize = true;
            LabelDirectory.Location = new System.Drawing.Point(12, 9);
            LabelDirectory.Name = "LabelDirectory";
            LabelDirectory.Size = new System.Drawing.Size(86, 21);
            LabelDirectory.TabIndex = 1;
            LabelDirectory.Text = "Directory";
            // 
            // TB_Dir
            // 
            TB_Dir.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
            TB_Dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TB_Dir.ForeColor = System.Drawing.SystemColors.Control;
            TB_Dir.Location = new System.Drawing.Point(104, 7);
            TB_Dir.MaxLength = 2000;
            TB_Dir.Name = "TB_Dir";
            TB_Dir.Size = new System.Drawing.Size(348, 29);
            TB_Dir.TabIndex = 1;
            // 
            // TB_Find
            // 
            TB_Find.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
            TB_Find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TB_Find.ForeColor = System.Drawing.SystemColors.Control;
            TB_Find.Location = new System.Drawing.Point(104, 68);
            TB_Find.MaxLength = 1000;
            TB_Find.Name = "TB_Find";
            TB_Find.Size = new System.Drawing.Size(348, 29);
            TB_Find.TabIndex = 2;
            // 
            // TB_Replace
            // 
            TB_Replace.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
            TB_Replace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TB_Replace.ForeColor = System.Drawing.SystemColors.Control;
            TB_Replace.Location = new System.Drawing.Point(104, 142);
            TB_Replace.MaxLength = 1000;
            TB_Replace.Name = "TB_Replace";
            TB_Replace.Size = new System.Drawing.Size(348, 29);
            TB_Replace.TabIndex = 3;
            TB_Replace.TextChanged += TB_Replace_TextChanged;
            // 
            // LabelFind
            // 
            LabelFind.AutoSize = true;
            LabelFind.Location = new System.Drawing.Point(12, 70);
            LabelFind.Name = "LabelFind";
            LabelFind.Size = new System.Drawing.Size(47, 21);
            LabelFind.TabIndex = 1;
            LabelFind.Text = "Find";
            // 
            // LabelReplace
            // 
            LabelReplace.AutoSize = true;
            LabelReplace.Location = new System.Drawing.Point(12, 144);
            LabelReplace.Name = "LabelReplace";
            LabelReplace.Size = new System.Drawing.Size(81, 21);
            LabelReplace.TabIndex = 1;
            LabelReplace.Text = "Replace";
            // 
            // ButtonFolder
            // 
            ButtonFolder.BackColor = System.Drawing.Color.FromArgb(72, 72, 72);
            ButtonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ButtonFolder.ForeColor = System.Drawing.SystemColors.Control;
            ButtonFolder.Location = new System.Drawing.Point(458, 7);
            ButtonFolder.Name = "ButtonFolder";
            ButtonFolder.Size = new System.Drawing.Size(125, 35);
            ButtonFolder.TabIndex = 5;
            ButtonFolder.Text = "Browse";
            ButtonFolder.UseVisualStyleBackColor = false;
            ButtonFolder.Click += ButtonFolder_Click;
            // 
            // TB_PatternStart
            // 
            TB_PatternStart.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
            TB_PatternStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TB_PatternStart.Enabled = false;
            TB_PatternStart.ForeColor = System.Drawing.SystemColors.Control;
            TB_PatternStart.Location = new System.Drawing.Point(104, 68);
            TB_PatternStart.MaxLength = 5;
            TB_PatternStart.Name = "TB_PatternStart";
            TB_PatternStart.Size = new System.Drawing.Size(114, 29);
            TB_PatternStart.TabIndex = 3;
            TB_PatternStart.Text = "[";
            TB_PatternStart.Visible = false;
            TB_PatternStart.TextChanged += TB_PatternStart_TextChanged;
            // 
            // TB_PatternEnd
            // 
            TB_PatternEnd.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
            TB_PatternEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TB_PatternEnd.Enabled = false;
            TB_PatternEnd.ForeColor = System.Drawing.SystemColors.Control;
            TB_PatternEnd.Location = new System.Drawing.Point(338, 68);
            TB_PatternEnd.MaxLength = 5;
            TB_PatternEnd.Name = "TB_PatternEnd";
            TB_PatternEnd.Size = new System.Drawing.Size(114, 29);
            TB_PatternEnd.TabIndex = 4;
            TB_PatternEnd.Text = "]";
            TB_PatternEnd.Visible = false;
            // 
            // DB_FindType
            // 
            DB_FindType.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
            DB_FindType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DB_FindType.ForeColor = System.Drawing.SystemColors.Control;
            DB_FindType.FormattingEnabled = true;
            DB_FindType.ImeMode = System.Windows.Forms.ImeMode.Off;
            DB_FindType.Items.AddRange(new object[] { "Text", "Pattern", "Prepend", "Append" });
            DB_FindType.Location = new System.Drawing.Point(458, 68);
            DB_FindType.MaxDropDownItems = 2;
            DB_FindType.Name = "DB_FindType";
            DB_FindType.Size = new System.Drawing.Size(125, 29);
            DB_FindType.TabIndex = 6;
            DB_FindType.Text = "Text";
            DB_FindType.SelectedIndexChanged += DB_FindType_SelectedIndexChanged;
            // 
            // Lb_PatternStart
            // 
            Lb_PatternStart.AutoSize = true;
            Lb_PatternStart.Enabled = false;
            Lb_PatternStart.Location = new System.Drawing.Point(104, 44);
            Lb_PatternStart.Name = "Lb_PatternStart";
            Lb_PatternStart.Size = new System.Drawing.Size(114, 21);
            Lb_PatternStart.TabIndex = 6;
            Lb_PatternStart.Text = "Pattern Start";
            Lb_PatternStart.Visible = false;
            // 
            // Lb_PatternEnd
            // 
            Lb_PatternEnd.AutoSize = true;
            Lb_PatternEnd.Enabled = false;
            Lb_PatternEnd.Location = new System.Drawing.Point(343, 44);
            Lb_PatternEnd.Name = "Lb_PatternEnd";
            Lb_PatternEnd.Size = new System.Drawing.Size(109, 21);
            Lb_PatternEnd.TabIndex = 7;
            Lb_PatternEnd.Text = "Pattern End";
            Lb_PatternEnd.Visible = false;
            // 
            // CheckboxSpaceRemove
            // 
            CheckboxSpaceRemove.AutoSize = true;
            CheckboxSpaceRemove.Checked = true;
            CheckboxSpaceRemove.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckboxSpaceRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            CheckboxSpaceRemove.Location = new System.Drawing.Point(274, 190);
            CheckboxSpaceRemove.Name = "CheckboxSpaceRemove";
            CheckboxSpaceRemove.Size = new System.Drawing.Size(302, 25);
            CheckboxSpaceRemove.TabIndex = 9;
            CheckboxSpaceRemove.Text = "Remove orphaned space at start";
            CheckboxSpaceRemove.UseVisualStyleBackColor = true;
            CheckboxSpaceRemove.Visible = false;
            CheckboxSpaceRemove.CheckedChanged += CheckboxSpaceRemove_CheckedChanged;
            // 
            // ButtonOpenLog
            // 
            ButtonOpenLog.BackColor = System.Drawing.Color.FromArgb(72, 72, 72);
            ButtonOpenLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ButtonOpenLog.ForeColor = System.Drawing.SystemColors.Control;
            ButtonOpenLog.Location = new System.Drawing.Point(12, 182);
            ButtonOpenLog.Name = "ButtonOpenLog";
            ButtonOpenLog.Size = new System.Drawing.Size(60, 35);
            ButtonOpenLog.TabIndex = 7;
            ButtonOpenLog.Text = "Log";
            ButtonOpenLog.UseVisualStyleBackColor = false;
            ButtonOpenLog.Click += ButtonOpenLog_Click;
            // 
            // LabelVersion
            // 
            LabelVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            LabelVersion.AutoSize = true;
            LabelVersion.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelVersion.Location = new System.Drawing.Point(0, 243);
            LabelVersion.Name = "LabelVersion";
            LabelVersion.Size = new System.Drawing.Size(141, 15);
            LabelVersion.TabIndex = 10;
            LabelVersion.Text = "Version: YYYY-MM-DD";
            // 
            // CheckboxRenameDirs
            // 
            CheckboxRenameDirs.AutoSize = true;
            CheckboxRenameDirs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            CheckboxRenameDirs.Location = new System.Drawing.Point(274, 220);
            CheckboxRenameDirs.Name = "CheckboxRenameDirs";
            CheckboxRenameDirs.Size = new System.Drawing.Size(163, 25);
            CheckboxRenameDirs.TabIndex = 10;
            CheckboxRenameDirs.Text = "Rename folders";
            CheckboxRenameDirs.UseVisualStyleBackColor = true;
            CheckboxRenameDirs.CheckedChanged += CheckboxRenameDirs_CheckedChanged;
            // 
            // ButtonSwap
            // 
            ButtonSwap.BackColor = System.Drawing.Color.FromArgb(72, 72, 72);
            ButtonSwap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ButtonSwap.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ButtonSwap.ForeColor = System.Drawing.SystemColors.Control;
            ButtonSwap.Location = new System.Drawing.Point(17, 102);
            ButtonSwap.Name = "ButtonSwap";
            ButtonSwap.Size = new System.Drawing.Size(36, 36);
            ButtonSwap.TabIndex = 11;
            ButtonSwap.Text = "↑↓";
            ButtonSwap.UseVisualStyleBackColor = false;
            ButtonSwap.Click += ButtonSwap_Click;
            // 
            // MainForm
            // 
            AcceptButton = ButtonReplace;
            AccessibleDescription = "Removes text from all file names in a directory and replaces it.";
            AccessibleName = "Multiple file renamer";
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(31, 31, 31);
            ClientSize = new System.Drawing.Size(590, 257);
            Controls.Add(ButtonSwap);
            Controls.Add(CheckboxRenameDirs);
            Controls.Add(LabelVersion);
            Controls.Add(ButtonOpenLog);
            Controls.Add(CheckboxSpaceRemove);
            Controls.Add(Lb_PatternEnd);
            Controls.Add(Lb_PatternStart);
            Controls.Add(DB_FindType);
            Controls.Add(TB_PatternEnd);
            Controls.Add(TB_PatternStart);
            Controls.Add(ButtonFolder);
            Controls.Add(LabelReplace);
            Controls.Add(LabelFind);
            Controls.Add(TB_Replace);
            Controls.Add(TB_Find);
            Controls.Add(TB_Dir);
            Controls.Add(LabelDirectory);
            Controls.Add(ButtonReplace);
            Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.Control;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(610, 300);
            MinimumSize = new System.Drawing.Size(610, 300);
            Name = "MainForm";
            Text = "Multi-File Renamer";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button ButtonSwap;
    }
}

