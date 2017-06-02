using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OddLines
{
    public static void Main(string[] args)
    {
        try
        {
            // input
            StreamReader reader = new StreamReader(Path.GetFullPath("lines.txt"), Encoding.GetEncoding("windows-1251"));

            string s;
            int lineNumber = 0;

            // algorithm: line number increases twice, the reader reads twice, console prints once
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (lineNumber % 2 == 0)
                {
                    Console.WriteLine(line);
                }

                lineNumber++;
            }
        }

        // in case no file is found
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
    }
}
