using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private int engineSpeed;
    private int enginePower;

    public Engine(int EngineSpeed, int EnginePower)
    {
        this.engineSpeed = EngineSpeed;
        this.enginePower = EnginePower;
    }

    public int EngineSpeed
    {
        get { return this.engineSpeed; }
    }

    public int EnginePower
    {
        get { return this.enginePower; }
    }
}

