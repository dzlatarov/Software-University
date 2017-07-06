using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CopyBinaryFile
{
    public static void Main(string[] args)
    {
        var reader = new StreamReader(Path.GetFullPath("botasmap.gif"));
        var writer = new StreamWriter(Path.GetFullPath("gibberish.txt"));

        while(!reader.EndOfStream)
        {
            string line = reader.ReadLine();

            writer.WriteLine(line);
        }

        writer.Flush();
    }
}

