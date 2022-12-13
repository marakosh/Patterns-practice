using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Fabric.Counties.Classes
{
    internal class ChinaCountry
    {
        public float Health { get; set; } = 40;
        public float Money { get; set; } = 900000;

        public float FirstCavalry()
        {
            return 100000;
        }

        public float SecondCavalry()
        {
            return 5000000;
        }
        public float FirstInfantry()
        {
            return 20000000;
        }

        public float SecondInfantry()
        {
            return 10000000;
        }
    }
}
