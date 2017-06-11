using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

public static class CommandInterpreter
{
    public static void InterpredCommand(string input)
    {
        string[] data = input.Split(' ').ToArray();
        string command = data[0];

        try
        {
            switch (command)
            {
                case "open":
                    TryOpenFile(input, data);
                    break;

                case "mkdir":
                    TryCreateDirectory(input, data);
                    break;

                case "ls":
                    TryTraverseFolders(input, data);
                    break;

                case "cmp":
                    TryCompareFiles(input, data);
                    break;

                case "cdRel":
                    TryChangePathRelatively(input, data);
                    break;

                case "cdAbs":
                    TryChangePathAbsolute(input, data);
                    break;

                case "readDb":
                    TryReadDatabaseFromFile(input, data);
                    break;
            }
        }
        catch (Exception)
        {
            OutputWriter.DisplayException(ExceptionMessages.InvalidInput);
        }
    }
    
    public static void TryOpenFile(string input, string[] data)
    {
        string fileName = data[1];
        Process.Start(SessionData.currentPath + "\\" + fileName);
    }

    public static void TryCreateDirectory(string input, string[] data)
    {
        string folderName = data[1];
        IOManager.CreateDirectoryIncurrentFolder(folderName);
    }

    public static void TryTraverseFolders(string input, string[] data)
    {
        if (data.Length == 1)
        {
            IOManager.TraverseDirectory(0);
        }
        else if (data.Length == 2)
        {
            int depth;

            bool hasParsed = int.TryParse(data[1], out depth);
            if (hasParsed)
            {
                IOManager.TraverseDirectory(depth);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.UnabelToParseNumber);
            }
        }
    }

    public static void TryCompareFiles(string input, string[] data)
    {
        if (data.Length == 3)
        {
            string firstPath = data[1];
            string secondPath = data[2];

            Tester.ComapreContent(firstPath, secondPath);
        }
    }

    public static void TryChangePathRelatively(string input, string[] data)
    {
        string relPath = data[1];
        IOManager.ChangeCurrentDirectoryRelative(relPath);
    }

    public static void TryChangePathAbsolute(string input, string[] data)
    {
        string absolutePath = data[1];
        IOManager.ChangeCurrentDirectoryAbsolute(absolutePath);
    }



    public static void InitializeData(string fileName)
    {
        //too lazy to fill
    }

    private static void TryReadDatabaseFromFile(string fileName)
    {
        string path = SessionData.currentPath + "\\" + fileName;

        if (File.Exists(path))
        {
            string[] allInputLines = File.ReadAllLines(path);

            for (int line = 0; line < allInputLines.Length; line++)
            {
                if (!string.IsNullOrEmpty(allInputLines[line])) 
                {
                    string[] data = allInputLines[line].Split(' ');

                        
                }
            }
        }

        // too lazy to fill
        else
        {
            OutputWriter.WriteMessage(ExceptionMessages.InvalidPath);
        }
    }
}

