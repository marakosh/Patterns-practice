using Abstract_Fabric.Counties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Fabric.Counties.Classes
{
    internal class NigerCountry : ICountry
    {
        public float Health { get; set; } = 999;
        public float Money { get; set; } = 9999999999999;

        public float FirstCavalry()
        {
            return 100000;
        }

        public float SecondCavalry()
        {
            return 50000;
        }
        public float FirstInfantry()
        {
            return 1000000;
        }

        public float SecondInfantry()
        {
            return 500000;
        }
    }
}
