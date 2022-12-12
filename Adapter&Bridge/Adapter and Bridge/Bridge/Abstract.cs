using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_and_Bridge.Bridge;
public abstract class Race
{
    public void MyRace() { }
}
public abstract class Growth
{
    Race race;
    public Growth(Race race) { }
    public void MyGrowth() { }
}

