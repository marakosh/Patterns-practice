using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Fabric.Counties.Classes
{
    internal class GhanaCountry
    {
        public float Health { get; set; } = 100;
        public float Money { get; set; } = 200000;

        public float FirstCavalry()
        {
            return 3000;
        }

        public float SecondCavalry()
        {
            return 1500;
        }
        public float FirstInfantry()
        {
            return 5000;
        }

        public float SecondInfantry()
        {
            return 1900;
        }
    }
}
