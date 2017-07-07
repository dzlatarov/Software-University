using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cargo
{
    private int cargoWeight;
    private string cargoType;

    public Cargo(int CargoWeight, string CargoType)
    {
        this.cargoWeight = CargoWeight;
        this.cargoType = CargoType;
    }
    public int CargoWeight
    {
        get { return this.cargoWeight; }
    }

    public string CargoType
    {
        get { return this.cargoType; }
    }
}
