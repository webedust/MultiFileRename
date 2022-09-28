using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MultiFileRename
{
    // Created by Dustin Weber
    /// <summary> File I/O functions </summary>
    public class FileIO
    {
        #region Attributes
        int filesRenamedInOperation;
        /// <summary> Number of files renamed in the last renaming operation. </summary>
        public int FilesRenamedInOperation
        {
            get { return filesRenamedInOperation; }
            private set { filesRenamedInOperation = value; }
        }
        #endregion
        #region Events
        /// <summary> Called when any of the renaming functions completes. </summary>
        public event EventHandler OnRenameComplete;
        /// <summary> Called when the <c>ReplaceAllFileNames</c> function completes. </summary>
        public event EventHandler OnReplaceAllComplete;
        #endregion


        /// <summary> Checks specified string for illegal characters for use in a file name </summary>
        /// <param name="s">String to check for illegal characters</param>
        /// <returns>True if string contains illegal characters</returns>
        public static bool ContainsIllegalChars(string s)
        {
            char[] illegalChars =
                { '\\', '/', ':', '*', '?', '"', '<', '>', '|' };
            // Check if file name starts with $
            if (s.StartsWith('$')) 
                return true;

            // Checks against array of illegal characters
            for (int i = 0; i < illegalChars.Length; i++)
                if (s.Contains(illegalChars[i])) 
                    return true;

            return false;
        }
        /* To-do: Significant redundant code reused between the Directories and Files functions.
         * Refactor it. */
        #region Directories
        /// <summary> Prepends text to a directory name. </summary>
        /// <param name="prepend"> Text to prepend. </param>
        /// <param name="dir"> Directory to get files from </param>
        public void PrependToDirectory(string prepend, string dir)
        {
            if (ContainsIllegalChars(prepend))
                throw new ArgumentException("New directory name contains illegal characters");

            DirectoryInfo d = new(dir);
            List<DirectoryInfo> dirs = d.GetDirectories("*").ToList();
            filesRenamedInOperation = 0;
            foreach (DirectoryInfo subdir in dirs)
            {
                string rename = prepend + subdir.Name;
                Rename(subdir, rename);
                filesRenamedInOperation++;
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
        }
        /// <summary> Appends text to a directory name. </summary>
        /// <param name="append"> Text to append. </param>
        /// <param name="dir"> Directory to get files from </param>
        public void AppendToDirectory(string append, string dir)
        {
            if (ContainsIllegalChars(append))
                throw new ArgumentException("New directory name contains illegal characters");

            DirectoryInfo d = new(dir);
            List<DirectoryInfo> dirs = d.GetDirectories("*").ToList();
            filesRenamedInOperation = 0;
            foreach (DirectoryInfo subdir in dirs)
            {
                string rename = subdir.Name + append;
                Rename(subdir, rename);
                filesRenamedInOperation++;
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
        }
        /// <summary> Replaces all sub-directory names in specified directory containing "find" </summary>
        /// <param name="find"> Text to be replaced in each file name </param>
        /// <param name="replace"> Text to replace "find" with </param>
        /// <param name="dir"> Directory to get files from </param>
        public void ReplaceAllDirectories(string find, string replace, string dir)
        {
            if (ContainsIllegalChars(replace))
                throw new ArgumentException("New file name contains illegal characters");

            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException();

            DirectoryInfo d = new(dir);
            List<DirectoryInfo> dirs = d.GetDirectories("*").ToList();
            filesRenamedInOperation = 0;
            foreach (DirectoryInfo subdir in dirs)
            {
                string rename = subdir.Name.Replace(find, replace);
                // Ensure the file is having its name changed
                if (subdir.Name != rename)
                {
                    Rename(subdir, rename);
                    filesRenamedInOperation++;
                }
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Replaces a pattern from sub-directory names,
        /// removing text between the start and end points.
        /// </summary>
        /// <param name="start">String to begin removal at (includes the start point)</param>
        /// <param name="end">String to end removal at (includes the end point)</param>
        /// <param name="dir">Directory to get files from</param>
        public void RemoveFromDirectoryNamesOnPattern(string start, string end, string dir)
        {
            if (ContainsIllegalChars(start) || ContainsIllegalChars(end))
                throw new ArgumentException("New file name contains illegal characters");

            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException();

            DirectoryInfo d = new(dir);
            List<DirectoryInfo> dirs = d.GetDirectories("*").ToList();
            filesRenamedInOperation = 0;
            foreach (DirectoryInfo subdir in dirs)
            {
                int startI = subdir.Name.IndexOf(start);
                int endI = subdir.Name.IndexOf(end);
                // Do not use endI for the substring as it ends at LENGTH
                int endAt = endI - startI;
                // Ensure pattern was found in the file
                if (startI >= 0 && endAt > 0)
                {
                    // Get string to remove as substring
                    string remove = subdir.Name.Substring(startI, endAt + 1);
                    // Replace "replace" from file
                    string newName = subdir.Name.Replace(remove, "");
                    Rename(subdir, newName);
                    filesRenamedInOperation++;
                }
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
            OnReplaceAllComplete?.Invoke(this, EventArgs.Empty);
        }

        /// <summary> Replaces sub-directory names in specified directory containing "find" at index "i" </summary>
        /// <param name="find"> Character to be replaced in each file name </param>
        /// <param name="replace"> Text to replace "find" with </param>
        /// <param name="i"> Index the character must be at to be replaced. </param>
        /// <param name="dir"> Directory to get files from </param>
        public void RemoveFromDirectoryAtIndex(char find, string replace, int i, string dir)
        {
            if (ContainsIllegalChars(replace))
                throw new ArgumentException("New file name contains illegal characters");

            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException();

            DirectoryInfo d = new(dir);
            List<DirectoryInfo> dirs = d.GetDirectories("*").ToList();
            filesRenamedInOperation = 0;
            foreach (DirectoryInfo subdir in dirs)
            {
                // Current file has matching character at index
                if (subdir.Name.IndexOf(find) == i)
                {
                    string rename = subdir.Name.Substring(i + 1);
                    Rename(subdir, rename);
                    filesRenamedInOperation++;
                }
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
        }
        #endregion
        #region Files
        /// <summary> Prepends text to a file name. </summary>
        /// <param name="prepend"> Text to prepend. </param>
        /// <param name="dir"> Directory to get files from </param>
        public void PrependToFile(string prepend, string dir)
        {
            if (ContainsIllegalChars(prepend))
                throw new ArgumentException("New file name contains illegal characters");

            DirectoryInfo d = new(dir);
            List<FileInfo> files = d.GetFiles("*").ToList();
            filesRenamedInOperation = 0;
            foreach (FileInfo file in files)
            {
                string rename = prepend + file.Name;
                Rename(file, rename);
                filesRenamedInOperation++;
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
        }
        // To-do: This should append BEFORE the file type extension
        /// <summary> Appends text to a file name. </summary>
        /// <param name="append"> Text to append. </param>
        /// <param name="dir"> Directory to get files from </param>
        public void AppendToFile(string append, string dir)
        {
            if (ContainsIllegalChars(append))
                throw new ArgumentException("New file name contains illegal characters");

            DirectoryInfo d = new(dir);
            List<FileInfo> files = d.GetFiles("*").ToList();
            filesRenamedInOperation = 0;
            foreach (FileInfo file in files)
            {
                string rename = file.Name + append;
                Rename(file, rename);
                filesRenamedInOperation++;
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
        }
        /// <summary> Replaces all file names in specified directory containing "find" </summary>
        /// <param name="find"> Text to be replaced in each file name </param>
        /// <param name="replace"> Text to replace "find" with </param>
        /// <param name="dir"> Directory to get files from </param>
        public void ReplaceAllFileNames(string find, string replace, string dir)
        {
            if (ContainsIllegalChars(replace))
                throw new ArgumentException("New file name contains illegal characters");

            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException();

            DirectoryInfo d = new(dir);
            List<FileInfo> files = d.GetFiles("*").ToList();
            filesRenamedInOperation = 0;
            foreach (FileInfo file in files)
            {
                string rename = file.Name.Replace(find, replace);
                // Ensure the file is having its name changed
                if (file.Name != rename)
                {
                    Rename(file, rename);
                    filesRenamedInOperation++;
                }
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Replaces a pattern from file names,
        /// removing text between the start and end points.
        /// </summary>
        /// <param name="start">String to begin removal at (includes the start point)</param>
        /// <param name="end">String to end removal at (includes the end point)</param>
        /// <param name="dir">Directory to get files from</param>
        public void RemoveFromFilesNamesOnPattern(string start, string end, string dir)
        {
            if (ContainsIllegalChars(start) || ContainsIllegalChars(end))
                throw new ArgumentException("New file name contains illegal characters");

            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException();

            DirectoryInfo d = new(dir);
            List<FileInfo> files = d.GetFiles("*").ToList();
            filesRenamedInOperation = 0;
            foreach (FileInfo file in files)
            {
                int startI = file.Name.IndexOf(start);
                int endI = file.Name.IndexOf(end);
                // Do not use endI for the substring as it ends at LENGTH
                int endAt = endI - startI;
                // Ensure pattern was found in the file
                if (startI >= 0 && endAt > 0)
                {
                    // Get string to remove as substring
                    string remove = file.Name.Substring(startI, endAt + 1);
                    // Replace "replace" from file
                    string newName = file.Name.Replace(remove, "");
                    Rename(file, newName);
                    filesRenamedInOperation++;
                }
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
            OnReplaceAllComplete?.Invoke(this, EventArgs.Empty);
        }

        /// <summary> Replaces file names in specified directory containing "find" at index "i" </summary>
        /// <param name="find"> Character to be replaced in each file name </param>
        /// <param name="replace"> Text to replace "find" with </param>
        /// <param name="i"> Index the character must be at to be replaced. </param>
        /// <param name="dir"> Directory to get files from </param>
        public void RemoveFromFileNameAtIndex(char find, string replace, int i, string dir)
        {
            if (ContainsIllegalChars(replace))
                throw new ArgumentException("New file name contains illegal characters");

            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException();

            DirectoryInfo d = new(dir);
            List<FileInfo> files = d.GetFiles("*").ToList();
            filesRenamedInOperation = 0;
            foreach (FileInfo file in files)
            {
                // Current file has matching character at index
                if (file.Name.IndexOf(find) == i)
                {
                    string rename = file.Name.Substring(i + 1);
                    Rename(file, rename);
                    filesRenamedInOperation++;
                }
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
        }

        // To-do: This function currently doesn't do anything.
        /// <summary>
        /// Renumbers files from starting string
        /// until no more files in numerical order are found.
        /// </summary>
        /// <param name="start">
        /// Starting numerical pattern.
        /// Does not need to only contain numbers. However, it <b>must</b> end in a number
        /// </param>
        /// <param name="dir">Directory to get files from</param>
        public void RenumberFiles(string start, string dir)
        {
            if (ContainsIllegalChars(start))
                throw new ArgumentException("New file name contains illegal characters");

            if (!Directory.Exists(dir))
                throw new DirectoryNotFoundException();

            DirectoryInfo d = new(dir);
            List<FileInfo> files = d.GetFiles("*").ToList();
            filesRenamedInOperation = 0;
            foreach (FileInfo file in files)
            {
                int startI = file.Name.IndexOf(start);
                // Ensure pattern was found in the file
                if (startI >= 0)
                {
                    // Get string to remove as substring
                    string remove = file.Name.Substring(startI);
                    // Replace "replace" from file
                    string newName = file.Name.Replace(remove, "");
                    Rename(file, newName);
                    filesRenamedInOperation++;
                }
            }
            OnRenameComplete?.Invoke(this, EventArgs.Empty);
        }
        #endregion
        /// <summary> Renames the specified file with newName </summary>
        /// <param name="file"> File to be renamed </param>
        /// <param name="rename"> Name the file should be renamed to. </param>
        public void Rename(FileInfo file, string rename)
            => file.MoveTo(Path.Combine(file.Directory.FullName, rename));
        /// <summary> Renames the specified directory with newName </summary>
        /// <param name="dir"> Directory to be renamed </param>
        /// <param name="rename"> Name the directory should be renamed to. </param>
        public void Rename(DirectoryInfo dir, string rename)
            => dir.MoveTo(Path.Combine(dir.Parent.FullName, rename));
    }
}