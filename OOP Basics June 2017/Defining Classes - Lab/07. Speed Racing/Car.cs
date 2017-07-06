using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumptionPerKilometer;
    private decimal distanceTraveled;

    public string Model
    {
        get { return this.model; }
    }

    public decimal FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public decimal FuelConsumptionPerKilometer
    {
        get { return this.fuelConsumptionPerKilometer; }
    }

    public decimal DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public Car(string model, decimal fuelAmount, decimal fuelConsumptionPerKilometer)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        this.distanceTraveled = 0;
    }
}

