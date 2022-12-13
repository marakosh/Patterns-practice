using Abstract_Fabric.Counties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Fabric.Factories;
internal abstract class ChinaCountryFactory
{
    public abstract ICountry CreateCountry();
}

