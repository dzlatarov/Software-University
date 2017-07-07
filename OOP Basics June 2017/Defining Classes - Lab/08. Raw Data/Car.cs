using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private Model model;
    private Engine engine;
    private Cargo cargo;
    private Tires tires;

    public Model Model
    {
        get { return this.model; }
    }

    public Engine Engine
    {
        get { return this.engine; }
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
    }

    public Tires Tires
    {
        get { return this.tires; }
    }



    public Car(string Model,
        int EngineSpeed, int EnginePower,
        int CargoWeight, string CargoType,
        double TireOnePressure, int TireOneAge,
        double TireTwoPressure, int TireTwoAge,
        double TireThreePressure, int TireThreeAge,
        double TireFourPressure, int TireFourAge)
    {
        this.model = new Model(Model);
        this.engine = new Engine(EngineSpeed, EnginePower);
        this.cargo = new Cargo(CargoWeight, CargoType);
        this.tires = new Tires(TireOnePressure, TireOneAge,
            TireTwoPressure, TireTwoAge,
            TireThreePressure, TireThreeAge,
            TireFourPressure, TireFourAge);
    }
}

