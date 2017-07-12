using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog : Animal
{
    public Dog(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public override string ExplainMyself()
    {
        return $"{base.ExplainMyself()}\nDJAAF";
    }
}

