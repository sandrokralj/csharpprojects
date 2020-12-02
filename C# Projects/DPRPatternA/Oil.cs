using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRPatternA
{
    class Oil : VehicleEssentials
    {
        public Oil(Vehicle vehicle) : base(vehicle)
        {

        }
        public override string GetDescription()
        {
            return base.GetDescription()+ " (Oil status good)";
        }

      

    }
}
