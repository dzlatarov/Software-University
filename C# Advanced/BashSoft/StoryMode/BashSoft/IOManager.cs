using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public static class IOManager
{
    public static void TraverseDirectory(string path)
    {
        OutputWriter.WriteEmptyLine();
        int initialIdentation = path.Split('\\').Length;
        Queue<string> subFolders = new Queue<string>();
        subFolders.Enqueue(path);

        while (subFolders.Count != 0)
        {
            string currentPath = subFolders.Dequeue();
            int identation = currentPath.Split('\\').Length - initialIdentation;

            Console.WriteLine(currentPath);
            try
            {
                foreach (var file in Directory.GetFiles(currentPath))
                {
                    int indexOfLastSlash = file.LastIndexOf("\\");
                    string fileName = file.Substring(indexOfLastSlash);
                    OutputWriter.WriteMessage(new string('-', indexOfLastSlash) + fileName);
                }

                foreach (string directoryPath in Directory.GetDirectories(currentPath))
                {
                    subFolders.Enqueue(directoryPath);
                }
            }
            catch (UnauthorizedAccessException)
            {
                OutputWriter.DisplayException(ExceptionMessages.UnauthorizedAccessExceptionMessage);
            }
        }
    }

    public static void CreateDirectoryIncurrentFolder(string name)
    {
        string path = SessionData.currentPath + "\\" + name;

        try
        {
            Directory.CreateDirectory(path);
        }
        catch (ArgumentException)
        {
            OutputWriter.DisplayException(ExceptionMessages.ForbiddenSymbolIsContained);
        }
    }

    public static void TraverseDirectory(int depth)
    {
        int initalIdentation = SessionData.currentPath.Split('\\').Length;
        Queue<string> subFolders = new Queue<string>();

        subFolders.Enqueue(SessionData.currentPath);
        OutputWriter.WriteMessage(subFolders.Dequeue());

        foreach (var file in Directory.GetFiles(SessionData.currentPath))
        {
            int indexOfLastSlash = file.LastIndexOf("\\");
            string fileName = file.Substring(indexOfLastSlash);
            OutputWriter.WriteMessageOnNewLine(new string('-', indexOfLastSlash) + fileName);


            if (depth - initalIdentation < 0)
            {
                break;
            }
        }

        foreach (var folder in Directory.GetDirectories(SessionData.currentPath))
            OutputWriter.WriteMessageOnNewLine($"-{folder}");
    }

    public static void ChangeCurrentDirectoryRelative(string relativePath)
    {
        if (relativePath == "..")
        {
            try
            {
                string currentPath = SessionData.currentPath;
                int indexOfLastSlash = currentPath.LastIndexOf("\\");
                string newPath = currentPath.Substring(0, indexOfLastSlash);
                SessionData.currentPath = newPath;
            }
            catch(ArgumentOutOfRangeException)
            {
                OutputWriter.DisplayException(ExceptionMessages.UnableToGoHigherInPartitionHierarchy);
            }
        }

        else
        {
            string currentPath = SessionData.currentPath;
            currentPath += "\\" + relativePath;
            ChangeCurrentDirectoryRelative(currentPath);
        }
    }

    public static void ChangeCurrentDirectoryAbsolute(string absolutePath)
    {
        if (!Directory.Exists(absolutePath))
        {
            OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            return;
        }

        SessionData.currentPath = absolutePath;
    }
}

