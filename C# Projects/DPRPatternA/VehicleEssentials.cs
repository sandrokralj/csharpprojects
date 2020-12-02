using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRPatternA
{
    class VehicleEssentials : Vehicle
    {
        protected Vehicle vehicle;
        

        public VehicleEssentials(Vehicle vehicle)
        {
            this.vehicle = vehicle;
           
        }

        public override string GetDescription()
        {
            return vehicle.GetDescription();
        }

        public override double GetPrice()
        {
            return vehicle.GetPrice();
        }
    }
}
