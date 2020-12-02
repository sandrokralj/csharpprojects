using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRPatternA
{
    class Truck : Vehicle
    {
        private int pullForce;

        public Truck(int pullForce, double price)
        {
            this.Price = price;
            this.pullForce = pullForce;
        }
         public override string GetDescription()
        {
            return "Truck with pull force: " + pullForce + " kg";
        }

        public override double GetPrice()
        {
            return Price;
        }
    }
}
