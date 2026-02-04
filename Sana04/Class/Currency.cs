using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04.Class;

public class Currency
{
    protected string Name;
    protected float ExRate;

    public Currency() { }

    public Currency(string name, float exRate)
    {
        SetName(name);
        SetExRate(exRate);
    }
    public Currency(float exRate)
    {
        SetName("USD");
        SetExRate(exRate);
    }

    public Currency(Currency other)
    {
        Name = other.Name;
        ExRate = other.ExRate;
    }


    public string GetCurName() => Name;
    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("Name isn't specified");
        Name = name;
    }
    public float GetExRate() => ExRate;
    public void SetExRate(float exRate)
    {
        if (exRate <= 0)
            throw new Exception("Wrong ExRate.");
        ExRate = exRate;
    }
}
