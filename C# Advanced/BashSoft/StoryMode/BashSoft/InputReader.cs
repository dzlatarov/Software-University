using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class InputReader
{
    private const string endCommand = "quit";

    public static void StartReadingCommands()
    {
        while (true)
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
            string input = Console.ReadLine();
            input = input.Trim();

            if (input == "quit")
            {
                break;
            }

            CommandInterpreter.InterpredCommand(input);
        }
    }
}

