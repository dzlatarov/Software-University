using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsePower;
    private int acceleration;     
    private int suspension;
    private int durability;

    public string Brand
    {
        get { return this.brand; }
    }

    public string Model
    {
        get { return this.model; }
    }

    public int YearOfProduction
    {
        get { return this.yearOfProduction; }
    }

    public int Horsepower
    {
        get { return this.horsePower; }
    }

    public int Acceleration
    {
        get { return this.acceleration; }
    }

    public int Suspension
    {
        get { return this.suspension; }
    }

    public int Durability
    {
        get { return this.durability; }
    }
}

