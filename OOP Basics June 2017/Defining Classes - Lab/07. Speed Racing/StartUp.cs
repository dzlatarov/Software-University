using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        var numberOfCars = int.Parse(Console.ReadLine());

        var cars = new Cars();
        for (int i = 0; i < numberOfCars; i++)
        {
            var tokens = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var carModel = tokens[0];
            var fuelAmount = decimal.Parse(tokens[1]);
            var fuelConsumptionFor1km = decimal.Parse(tokens[2]);

            var car = new Car(carModel, fuelAmount, fuelConsumptionFor1km);
            cars.AddCar(car);
        }

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            var tokens = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var driveCarModel = tokens[1];
            var amountOfKMdriven = decimal.Parse(tokens[2]);

            cars.MoveCar(driveCarModel, amountOfKMdriven);
        }

        foreach (Car car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
        }

    }
}

