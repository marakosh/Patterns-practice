using Adapter_and_Bridge.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_and_Bridge.Bridge;
public class BruceWayne : Growth
{
    Race race;
    Tall tall;
    public BruceWayne(Race race) : base(race) { }

    public void IAm()
    {
        race.MyRace();

    }
    public void MyGrowth() { }
}

public class Negro : Race
{
    public void MyRace()
    {
        Console.WriteLine("My race is negro");
    }
}
public class Mulatto : Race
{
    public void MyRace()
    {
        Console.WriteLine("My race is mulatto");
    }
}
public class Mongoloid : Race
{
    public void MyRace()
    {
        Console.WriteLine("My race is mongoloid");
    }
}
public class Caucasian : Race
{
    public void MyRace()
    {
        Console.WriteLine("My race is caucasian");
    }
}


public class Tall : Growth
{
    public Tall(Race race) : base(race) { }
    public void MyGrowth()
    {
        Console.WriteLine("My height is over 175");
    }
}
public class Short : Growth
{
    public Short(Race race) : base(race) { }
    public void MyGrowth()
    {
        Console.WriteLine("My height is less than 160");
    }
}
