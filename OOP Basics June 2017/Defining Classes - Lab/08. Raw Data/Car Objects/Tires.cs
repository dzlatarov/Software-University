using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tires
{
    private double tireOnePressure;
    private int tireOneAge;
    private double tireTwoPressure;
    private int tireTwoAge;
    private double tireThreePressure;
    private int tireThreeAge;
    private double tireFourPressure;
    private int tireFourAge;

    public Tires(double TireOnePressure, int TireOneAge,
        double TireTwoPressure, int TireTwoAge,
        double TireThreePressure, int TireThreeAge,
        double TireFourPressure, int TireFourAge)
    {
        this.tireOnePressure = TireOnePressure;
        this.tireTwoPressure = TireTwoPressure;
        this.tireThreePressure = TireThreePressure;
        this.tireFourPressure = TireFourPressure;

        this.tireOneAge = TireOneAge;
        this.tireTwoAge = TireTwoAge;
        this.tireThreeAge = TireThreeAge;
        this.tireFourAge = TireFourAge;
    }

    public double TireOnePressure
    {
        get { return this.tireOnePressure; }
    }
    public double TireTwoPressure
    {
        get { return this.tireTwoPressure; }
    }
    public double TireThreePressure
    {
        get { return this.tireThreePressure; }
    }
    public double TireFourPressure
    {
        get { return this.tireFourPressure; }
    }
}
