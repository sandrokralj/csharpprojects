using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRPatternA
{
    class Car : Vehicle
    {
        private string model;

        public Car(double price, string model)
        {
            this.model = model;
            this.Price = price;
        }
        public override string GetDescription()
        {
            return "Car model: " + model;
        }

        public override double GetPrice()
        {
            return Price;
        }
    }
}
