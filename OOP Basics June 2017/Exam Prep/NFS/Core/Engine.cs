using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private CarManager manager;

    public Engine()
    {
        this.manager = new CarManager();
    }


    public void Run()
    {
        while (true)
        {
            var command = Console.ReadLine();
            if (command == "Cops Are Here")
            {
                break;
            }

            var cmdArgs = command.Split(' ');
            ExecuteCommand(cmdArgs);
        }
    }

    private void ExecuteCommand(string[] cmdArgs)
    {
        switch (cmdArgs[0])
        {
            case "register":

                int id = int.Parse(cmdArgs[1]);
                string type = cmdArgs[2];
                string brand = cmdArgs[3];
                string mode = cmdArgs[4];
                int yearOfProduction = int.Parse(cmdArgs[5]);
                int horsepower = int.Parse(cmdArgs[6]);
                int acceleration = int.Parse(cmdArgs[7]);
                int suspension = int.Parse(cmdArgs[8]);
                int durability = int.Parse(cmdArgs[9]);
                manager.Register(id, type, brand, mode, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;

            case "check":
                manager.Check();
                break;

            case "open":
                manager.Open();
                break;

            case "participate":
                manager.Participate();
                break;

            case "start":
                manager.Start();
                break;

            case "park":
                manager.Park();
                break;

            case "unpark":
                manager.Unpark();
                break;

            case "tune":
                manager.Tune();
                break;
        }
    }
}

