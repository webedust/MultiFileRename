using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Dustin;

namespace MultiFileRename
{
    public partial class FormLog : Form
    {
        #region Initial
        public FormLog() => InitializeComponent();
        /// <summary> Called when form is loaded </summary>
        void FormLog_Load(object sender, EventArgs e)
        {
            // To-do
        }
        #endregion
        /// <summary> Writes the specified string to the log. </summary>
        /// <param name="text"> String to write to the log. </param>
        public void Write(string text)
        {
            logTextbox.Text += text;
        }
        /// <summary> Writes the specified string to the log and appends a line break at the end. </summary>
        /// <param name="text"> String to write to the log. </param>
        public void WriteLine(string text)
        {
            logTextbox.Text += text + "\n";
        }
    }
}
