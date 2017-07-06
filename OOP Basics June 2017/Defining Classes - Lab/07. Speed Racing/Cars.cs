using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Cars : IEnumerable<Car>
{
    private List<Car> cars;

    public Cars()
    {
        this.cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void MoveCar(string model, decimal distanceTraveled)
    {
        var carWithMatchingModel = cars.Find(car => car.Model == model);

        var fuelConverter = carWithMatchingModel.FuelConsumptionPerKilometer * distanceTraveled;

        if (carWithMatchingModel.FuelAmount - fuelConverter >= 0)
        {
            carWithMatchingModel.FuelAmount -= fuelConverter;
            carWithMatchingModel.DistanceTraveled += distanceTraveled;
            cars.Where(car => car.Model == model).Select(car => carWithMatchingModel);
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public IEnumerator<Car> GetEnumerator()
    {
        return ((IEnumerable<Car>)cars).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<Car>)cars).GetEnumerator();
    }
}

