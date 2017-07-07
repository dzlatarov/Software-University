using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Model
{
    private string modelName;

    public Model(string ModelName)
    {
        this.modelName = ModelName;
    }
    public string ModelName
    {
        get { return this.modelName; }
    }
}

