using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lines
{
    public static void Main(string[] args)
    {
        var reader = new StreamReader(Path.GetFullPath("lines.txt"));
        var writer = new StreamWriter(Path.GetFullPath("newLines.txt"));

        var lineNumber = 1;
        while(!reader.EndOfStream)
        {
            string line = reader.ReadLine();

            line = line.Insert(0, $"{lineNumber}. ");

            writer.WriteLine(line);
          
            lineNumber++;
        }

        writer.Flush();
    }
}

