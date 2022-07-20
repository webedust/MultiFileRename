using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Dustin;

namespace MultiFileRename
{
    public partial class MainForm : Form
    {
        #region Attributes
        // Variables
        /* 0: Replace file names using pattern. 
         * 1: Replace file names using text.
         * 2: Renumber file names
        */
        int replaceType;
        /* Remove orphaned spaces from start (index 0) of file name
         * Only used on pattern removal. */
        bool removeOrphanedSpace = true;
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
                io.RemoveAtIndex(' ', "", 0, TB_Dir.Text);
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
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
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
            Console.WriteLine($"replaceType = {replaceType}");
            try
            {
                switch (replaceType)
                {
                    case 0:
                        io.ReplaceAllFileNames(TB_Find.Text, TB_Replace.Text, TB_Dir.Text);
                        break;
                    case 1:
                        io.RemoveFromFilesNamesOnPattern(TB_PatternStart.Text, TB_PatternEnd.Text, TB_Dir.Text);
                        break;
                    case 2:
                        io.RenumberFiles(TB_Find.Text, TB_Dir.Text);
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
            if (replaceType == 0)
                IsReplaceIllegal();
        }
        /// <summary> Find Type Dropdown value is changed </summary>
        void DB_FindType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DB_FindType.SelectedIndex)
            {
                case 0: // Find & Replace
                    ToggleReplacePatternComponents(0);
                    break;
                case 1: // Pattern find
                    ToggleReplacePatternComponents(1);
                    break;
                case 2: // Renumber
                    // Uses "Find & Replace" components
                    ToggleReplacePatternComponents(2);
                    break;
                default: // Default to "Find & Replace"
                    ToggleReplacePatternComponents(0);
                    break;
            }
            /* Enable replace button
             * In case replacement text contained illegal chars */
            if (replaceType == 1) 
                ButtonReplace.Enabled = true;
            // If re-enabling text replacement checks again for illegal chars
            else 
                IsReplaceIllegal();
        }
        /// <summary>
        /// Toggles text boxes, labels, etc. associated with replacing a pattern vs. text
        /// between True or False based on the state parameter
        /// </summary>
        /// <param name="renameType">0: Find & Replace, 1: Pattern, 2: Renumber</param>
        void ToggleReplacePatternComponents(int renameType)
        {
            // Variables
            bool state;


            // Find & Replace / Pattern
            if (renameType < 2)
                state = Utils.IntToBool(renameType);
            // Assumes Renumber if higher than 2, therefore false
            else 
                state = false;

            replaceType = renameType;

            TB_PatternStart.Visible = state;
            TB_PatternEnd.Visible = state;

            TB_PatternStart.Enabled = state;
            TB_PatternEnd.Enabled = state;

            Lb_PatternStart.Visible = state;
            Lb_PatternEnd.Visible = state;

            Lb_PatternStart.Enabled = state;
            Lb_PatternEnd.Enabled = state;

            // Standard text replace components
            LabelFind.Text = "Find";

            TB_Find.Visible = !state;
            TB_Find.Enabled = !state;

            // Replace textbox must be disabled because it is not usable in pattern removal
            TB_Replace.Visible = !state;
            TB_Replace.Enabled = !state;

            LabelReplace.Visible = !state;
            LabelReplace.Enabled = !state;

            CheckboxSpaceRemove.Visible = state;
            CheckboxSpaceRemove.Enabled = state;

            // Change text on Replace button between Replace/Remove based on context
            if (state) ButtonReplace.Text = "Remove";
            else ButtonReplace.Text = "Replace";

            // Renumber re-uses components as Find & Replace but not all
            // Therefore it runs after
            if (renameType == 2)
            {
                LabelFind.Text = "Start at";

                TB_Replace.Visible = false;
                TB_Replace.Enabled = false;

                LabelReplace.Visible = false;
                LabelReplace.Enabled = false;

                ButtonReplace.Text = "Renumber";
            }
        }
        void CheckboxSpaceRemove_CheckedChanged(object sender, EventArgs e)
            => removeOrphanedSpace = CheckboxSpaceRemove.Checked;
        void CheckboxRenameDirs_CheckedChanged(object sender, EventArgs e)
        {
            // To-do
            //io.
        }
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