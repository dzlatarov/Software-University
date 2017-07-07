using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();

        var numbersOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbersOfCars; i++)
        {
            var input = Console.ReadLine();
            var carTokens = input
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var carModel = carTokens[0];
            var engineSpeed = int.Parse(carTokens[1]);
            var enginePower = int.Parse(carTokens[2]);
            var cargoWeight = int.Parse(carTokens[3]);
            var cargoType = carTokens[4];
            var tireOnePressure = double.Parse(carTokens[5]);
            var tireOneAge = int.Parse(carTokens[6]);
            var tireTwoPressure = double.Parse(carTokens[7]);
            var tireTwoAge = int.Parse(carTokens[8]);
            var tireThreePressure = double.Parse(carTokens[9]);
            var tireThreeAge = int.Parse(carTokens[10]);
            var tireFourPressure = double.Parse(carTokens[11]);
            var tireFourAge = int.Parse(carTokens[12]);

            var car = new Car(carModel,
                engineSpeed, enginePower,
                cargoWeight, cargoType,
                tireOnePressure, tireOneAge,
                tireTwoPressure, tireTwoAge,
                tireThreePressure, tireThreeAge,
                tireFourPressure, tireFourAge);

            cars.Add(car);
        }

        var cargoTypeToSearch = Console.ReadLine();  
        
        PrintResult(cars, cargoTypeToSearch);
    }

    public static void PrintResult(List<Car> cars, string input)
    {
        if (input == "fragile")
        {
            foreach (Car car in cars.Where(x => x.Cargo.CargoType == "fragile")
                .Where(x => x.Tires.TireOnePressure < 1 || x.Tires.TireTwoPressure < 1 ||
                            x.Tires.TireThreePressure < 1 || x.Tires.TireFourPressure < 1))
            {
                Console.WriteLine($"{car.Model.ModelName}");
            }
        }
        else if (input == "flamable")
        {
            foreach (Car car in cars.Where(x => x.Cargo.CargoType == "flamable").Where(x => x.Engine.EnginePower > 250))
            {
                Console.WriteLine($"{car.Model.ModelName}");
            }
        }
    }
}
