using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRPatternA
{
    class Fuel : VehicleEssentials
    {

        public Fuel(Vehicle vehicle): base(vehicle)
        {

        }
        public override string GetDescription()
        {
            return base.GetDescription()+" (Fuel tank full)";
        }
    }
}
