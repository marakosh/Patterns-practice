using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Fabric.Counties.Classes
{
    internal class HondurasCountry
    {
        public float Health { get; set; } = 999;
        public float Money { get; set; } = 888888888888;

        public float FirstCavalry()
        {
            return 1234567;
        }

        public float SecondCavalry()
        {
            return 50000;
        }
        public float FirstInfantry()
        {
            return 1999999;
        }

        public float SecondInfantry()
        {
            return 1000000;
        }
    }
}
