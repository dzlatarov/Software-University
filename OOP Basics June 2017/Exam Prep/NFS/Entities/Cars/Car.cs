using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Car
{
    private string type;
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;     
    private int suspension;
    private int durability;

    public Car(string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        this.type = type;
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

