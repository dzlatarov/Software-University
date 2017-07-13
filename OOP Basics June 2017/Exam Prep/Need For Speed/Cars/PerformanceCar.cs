using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PerformanceCar : Car
{
    private int horsepower;
    private int suspension;
    private List<string> addOns;

    public int Horsepower
    {
        get { return this.horsepower; }
        set { this.horsepower = (int)(base.Horsepower * 1.5); }
    }

    public int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = (int)(base.Suspension * 1.25); }
    }
}

