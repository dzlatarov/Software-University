using System;
using System.IO;
using System.Collections.Generic;
using System.Text;


public class SliceAndMerge
{
    public static void Main(string[] args)
    {
        string input;
        do
        {
            Console.WriteLine("Slice or Merge?");
            input = Console.ReadLine();
        } while (input != "Slice" && input != "Merge");
        

        if(input == "Slice")
        {
            Slice();
        }
        else if (input == "Merge")
        {
            Merge();
        }
            
    }

    public static void Slice()
    {
        Console.WriteLine("File location:");
        string sourceFile = Console.ReadLine();
        Console.WriteLine("Destination Folder:");
        string destinationDirectory = Console.ReadLine();
        Console.WriteLine("Parts:");
        int parts = int.Parse(Console.ReadLine());

        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            for (int i = 0; i < parts; i++)
            {
                using (var destination = new FileStream(destinationDirectory, FileMode.Create))
                {
                    double fileLength = source.Length;
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }

    public static void Merge()
    {
        Console.WriteLine("Number of files:");
        var numberOfFiles = int.Parse(Console.ReadLine());
        var files = new List<string>();

        for(int i = 1; i <= numberOfFiles; i++)
        {
            Console.WriteLine($"File {i} directory: ");
            files.Add(Console.ReadLine());
        }

        Console.WriteLine("Output directory:");
        string destinationDirectory = Console.ReadLine();

        var create = new FileStream(destinationDirectory, FileMode.Create);
        try
        {
            for (int i = 0; i < files.Count; i++)
            {
                var opener = new FileStream(files[i], FileMode.Open);
                byte[] bytes = Encoding.ASCII.GetBytes(files[i]);
                create.Write(bytes, 0, bytes.Length);
            }

        }
        finally
        {
            create.Close();
        }
    }
}

