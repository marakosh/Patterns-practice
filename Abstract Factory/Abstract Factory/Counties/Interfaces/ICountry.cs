using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Fabric.Counties.Interfaces;
internal interface ICountry : IInfantry, ICavalry
{
    public float Health { get; set; }
    public float Money { get; set; }
}