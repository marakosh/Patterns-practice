using Abstract_Fabric.Counties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Fabric.Counties.Classes
{
    internal class UkraineCountry : ICountry
    {
        public float Health { get; set; } = 100;
        public float Money { get; set; } = 300000;

        public float FirstCavalry()
        {
            return 1000;
        }

        public float SecondCavalry()
        {
            return 400; 
        }
        public float FirstInfantry()
        {
            return 2000;
        }

        public float SecondInfantry()
        {
            return 1500;
        }
    }
}
