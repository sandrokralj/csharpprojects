using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRPatternA
{
    class Tires : VehicleEssentials
    {
        public Tires(Vehicle vehicle) :base(vehicle)
        {

        }
        public override string GetDescription()
        {
            return base.GetDescription()+ " (Tires pumped)";
        }
    }
}
