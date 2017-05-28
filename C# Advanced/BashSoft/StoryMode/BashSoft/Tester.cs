using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


public static class Tester
{
    public static void CompareContent(string userOutputPath, string expectedOutputPath)
    {
       
    }

    public static string GetMismatchPath(string expectedOutputPath)
    {
        int indexOf = expectedOutputPath.LastIndexOf('\\');
        string directoryPath = expectedOutputPath.Substring(0, indexOf);
        string finalPath = directoryPath + @"\Mismatches.txt";
        return finalPath;
    }

    public static void ComapreContent(string userOutputPath, string expectedOutputPath)
    {
        OutputWriter.WriteMessageOnNewLine("Reading Files...");

        string mismatchPath = GetMismatchPath(expectedOutputPath);

        string[] actualOutputLines = File.ReadAllLines(userOutputPath);
        string[] expectedOutputLines = File.ReadAllLines(expectedOutputPath);

        bool hasMismatch;
        string[] mismatches = GetLinesWithPossibleMismathes(actualOutputLines, expectedOutputLines, out hasMismatch);

        PrintOutput(mismatches, hasMismatch, mismatchPath);
        OutputWriter.WriteMessageOnNewLine("Files read!");
    }

    private static string[] GetLinesWithPossibleMismathes(
    string[] actualOutputString, string[] expectedOutputString, out bool hasMismatch)
    {
        hasMismatch = false;
        string output = string.Empty;

        string[] mismatches = new string[actualOutputString.Length];
        OutputWriter.WriteMessageOnNewLine("Comparing files...");

        for(int index = 0; index < actualOutputString.Length; index++)
        {
            string actualLine = actualOutputString[index];
            string expectedLine = expectedOutputString[index];

            if(!actualLine.Equals(expectedLine))
            {
                output = string.Format("Mismatch at line {0} -- expected: \"{1}\", actual: \"{2}\"", index, expectedLine, actualLine);
                output += Environment.NewLine;
                hasMismatch = true;
            }
            else
            {
                output = actualLine;
                output += Environment.NewLine;
            }

            mismatches[index] = output;
        }

        return mismatches;
    }

    private static void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchesPath)
    {
        if(hasMismatch)
        {
            foreach(var line in mismatches)
            {
                OutputWriter.WriteMessageOnNewLine(line);
            }

            File.WriteAllLines(mismatchesPath, mismatches);

            return;
        }
    }
}

