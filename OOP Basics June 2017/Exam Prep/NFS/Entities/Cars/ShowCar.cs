﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.stars = stars;
    }
}

