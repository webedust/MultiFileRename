## Table of Contents
[Description](#description)  
[Installation](#installation)  
[Usage](#usage)  
[Credits](#credits)  
[License](#license)  

## Description
Multi-File Renamer (MultiFileRename) is a C# Windows Forms application to quickly rename all files in a directory.

## Installation
Multi-File Renamer can be installed by downloading the Release files located in Release/net6.0-windows.
From there, run MultiFileRename.exe to install and use the program.

## Usage
Multi-File Renamer can be used to replace and remove text in both files and sub-directories in a given directory.
A few examples of the most common use cases are provided below.

### Remove on Pattern
Multi-File Renamer can remove text from file and directory names based on a set start and end pattern when "Pattern" is selected from the dropdown.
For example, if you have files with the names "[Some text goes here] etc.txt", "[More text but different] another.txt",
you can remove all the text between the brackets by entering "[" as the start of the removal pattern, and "]" as the end of the pattern.

### Replace Text
Multi-File Renamer can perform a standard Find and Replace or Find and Remove of text based on a given phrase or character.
This is the default behavior when using the program.
To do this, enter the text you want to have replaced, and enter the text you want to take its place in the "Replace" field.
Alternatively, the "Replace" field can be left blank in order to remove certain characters or phrases from file names.

## Credits
Created by Dustin Weber in C# Windows Forms

## License
Multi-File Renamer is licensed under the [MIT License.](LICENSE.md)
