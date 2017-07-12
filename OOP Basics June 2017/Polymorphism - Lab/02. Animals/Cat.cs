using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat : Animal
{
    public Cat(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public override string ExplainMyself()
    {
        return $"{base.ExplainMyself()}\nMEOW";
    }
}

