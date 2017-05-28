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
            catch(UnauthorizedAccessException)
            {
                OutputWriter.DisplayException(ExceptionMessages.UnauthorizedAccessExceptionMessage);
            }
        }
    }
}

