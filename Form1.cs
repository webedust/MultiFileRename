using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MultiFileRename
{
    public partial class MainForm : Form
    {
        #region Attributes
        enum RenameOperations
        {
            Text = 0,
            Pattern = 1,
            Prepend = 2,
            Append = 3
        }
        RenameOperations renameOperation;
        /* Remove orphaned spaces from start (index 0) of file name
         * Only used on pattern removal. */
        bool removeOrphanedSpace = true;
        /// <summary> Rename sub-directories rather than files. </summary>
        bool renameFolders;
        // Default font color used in program
        Color fontColor;
        #endregion
        #region References
        FileIO io;
        FormLog formLog;
        #endregion


        #region Initial
        public MainForm() => InitializeComponent();
        /// <summary> Called when form is loaded </summary>
        void MainForm_Load(object sender, EventArgs e)
        {
            io = new();
            ConnectFileIO();

            LabelVersion.Text = $"Version: {Properties.Resources.Version}";

            // Set fontColor to color being used for text
            // Font color of textboxes changes to red on invalid input
            // This color is used to set it back to the starting color
            fontColor = TB_Dir.ForeColor;
        }
        #endregion
        #region Event connections
        void ConnectFileIO()
        {
            io.OnReplaceAllComplete += IO_OnReplaceAllComplete;
            io.OnRenameComplete += Io_OnRenameComplete;
        }
        void ConnectFormLog()
        {
            formLog.FormClosed += FormLog_FormClosed;
        }
        void DisconnectFormLog()
        {
            formLog.FormClosed -= FormLog_FormClosed;
        }
        #endregion
        #region Events
        void Io_OnRenameComplete(object sender, EventArgs e)
        {
            // Output the number of files renamed
            if (formLog != null)
                formLog.WriteLine($"{io.FilesRenamedInOperation} files renamed");
        }
        /// <summary> Called whenever the FileIO.OnReplaceAll event is invoked. </summary>
        void IO_OnReplaceAllComplete(object sender, EventArgs e)
        {
            // Remove orphaned spaces if specified.
            if (removeOrphanedSpace)
            {
                // Log notification if the log is currently running
                if (formLog != null)
                    formLog.WriteLine($"Removing orphaned white space at the start of matching files.");
                io.RemoveFromFileNameAtIndex(' ', "", 0, TB_Dir.Text);
            }
                
        }

        void FormLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectFormLog();
            formLog = null;
        }
        #endregion
        #region UI functions
        /// <summary> "Find Folder" button is pressed </summary>
        void ButtonFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new();
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                TB_Dir.Text = FolderBrowserDialog.SelectedPath;
        }
        void ButtonOpenLog_Click(object sender, EventArgs e)
        {
            if (formLog != null)
                return;

            formLog = new FormLog();
            ConnectFormLog();
            formLog.Show(this);
        }
        void ButtonReplace_Click(object sender, EventArgs e)
        {
            try
            {
                switch (renameOperation)
                {
                    case RenameOperations.Text:
                        if (renameFolders)
                            io.ReplaceAllDirectories(TB_Find.Text, TB_Replace.Text, TB_Dir.Text);
                        else
                            io.ReplaceAllFileNames(TB_Find.Text, TB_Replace.Text, TB_Dir.Text);
                        break;
                    case RenameOperations.Pattern:
                        if (renameFolders)
                            io.RemoveFromDirectoryNamesOnPattern(TB_PatternStart.Text, TB_PatternEnd.Text, TB_Dir.Text);
                        else
                            io.RemoveFromFilesNamesOnPattern(TB_PatternStart.Text, TB_PatternEnd.Text, TB_Dir.Text);
                        break;
                    case RenameOperations.Prepend:
                        if (renameFolders)
                            io.PrependToDirectory(TB_Replace.Text, TB_Dir.Text);
                        else
                            io.PrependToFile(TB_Replace.Text, TB_Dir.Text);
                        break;
                    case RenameOperations.Append:
                        if (renameFolders)
                            io.AppendToDirectory(TB_Replace.Text, TB_Dir.Text);
                        else
                            io.AppendToFile(TB_Replace.Text, TB_Dir.Text);
                        break;
                    default:
                        break;
                }
                // Set color to fontColor in case previous input was invalid
                TB_Dir.ForeColor = fontColor;
            }
            catch (DirectoryNotFoundException)
            {
                TB_Dir.ForeColor = Color.Red;
            }
        }
        void TB_PatternStart_TextChanged(object sender, EventArgs e)
        {
            string endPattern = Autocomplete.FillEndPattern(TB_PatternStart.Text);
            // Only set pattern end if not null
            if (endPattern == null)
                return;

            TB_PatternEnd.Text = endPattern;
        }
        /// <summary> Checks if replacement text contains illegal characters as it's typed </summary>
        void TB_Replace_TextChanged(object sender, EventArgs e)
        {
            if (renameOperation == 0)
                IsReplaceIllegal();
        }
        /// <summary> Find Type Dropdown value is changed </summary>
        void DB_FindType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleReplacePatternComponents((RenameOperations)DB_FindType.SelectedIndex);

            /* Enable replace button
             * In case replacement text contained illegal chars */
            if (renameOperation == RenameOperations.Pattern) 
                ButtonReplace.Enabled = true;
            // If re-enabling text replacement checks again for illegal chars
            else 
                IsReplaceIllegal();
        }
        /// <summary> Toggles UI controls based on the operation taking place. </summary>
        void ToggleReplacePatternComponents(RenameOperations dropdownValue)
        {
            switch (dropdownValue)
            {
                case RenameOperations.Text:
                    SetUIForReplacingText();
                    break;
                case RenameOperations.Pattern:
                    SetUIForPatternRemoval();
                    break;
                case RenameOperations.Prepend:
                    SetUIForPrependingText();
                    break;
                case RenameOperations.Append:
                    SetUIForAppendingText();
                    break;
            }

            renameOperation = dropdownValue;
        }
        void SetUIForReplacingText()
        {
            TogglePatternRemovalControls(false);
            ToggleReplacementControls(true);

            LabelFind.Text = "Find";
            const string replaceText = "Replace";
            LabelReplace.Text = replaceText;
            ButtonReplace.Text = replaceText;
        }
        void ToggleReplacementControls(bool state)
        {
            TB_Find.Visible = state;
            TB_Find.Enabled = state;

            // Replace textbox must be disabled because it is not usable in pattern removal
            TB_Replace.Visible = state;
            TB_Replace.Enabled = state;

            LabelFind.Visible = state;
            LabelFind.Enabled = state;

            LabelReplace.Visible = state;
            LabelReplace.Enabled = state;
        }
        void SetUIForPatternRemoval()
        {
            ToggleReplacementControls(false);
            TogglePatternRemovalControls(true);

            ButtonReplace.Text = "Remove";
        }
        void TogglePatternRemovalControls(bool state)
        {
            LabelFind.Visible = state;
            LabelFind.Enabled = state;

            TB_PatternStart.Visible = state;
            TB_PatternEnd.Visible = state;

            TB_PatternStart.Enabled = state;
            TB_PatternEnd.Enabled = state;

            Lb_PatternStart.Visible = state;
            Lb_PatternStart.Enabled = state;

            Lb_PatternEnd.Visible = state;
            Lb_PatternEnd.Enabled = state;

            CheckboxSpaceRemove.Visible = state;
            CheckboxSpaceRemove.Enabled = state;
        }
        /// <summary> Sets UI controls shared between text adding operations (prepending, appending). </summary>
        void SetUIForAddingText()
        {
            TogglePatternRemovalControls(false);
            ToggleReplacementControls(true);

            LabelFind.Visible = false;
            LabelFind.Enabled = false;

            TB_Find.Visible = false;
            TB_Find.Enabled = false;

            TB_Replace.Visible = true;
            TB_Replace.Visible = true;

            ButtonReplace.Text = "Add Text";
        }
        void SetUIForPrependingText()
        {
            SetUIForAddingText();
            LabelReplace.Text = "Prepend";
        }
        void SetUIForAppendingText()
        {
            SetUIForAddingText();
            LabelReplace.Text = "Append";
        }
        void CheckboxSpaceRemove_CheckedChanged(object sender, EventArgs e)
            => removeOrphanedSpace = CheckboxSpaceRemove.Checked;
        void CheckboxRenameDirs_CheckedChanged(object sender, EventArgs e)
            => renameFolders = CheckboxRenameDirs.Checked;
        #endregion
        /// <summary> Checks if replacement text contains illegal characters </summary>
        void IsReplaceIllegal()
        {
            if (FileIO.ContainsIllegalChars(TB_Replace.Text))
            {
                TB_Replace.ForeColor = Color.Red;
                ButtonReplace.Enabled = false;
            }
            else
            {
                TB_Replace.ForeColor = fontColor;
                ButtonReplace.Enabled = true;
            }
        }
    }
}