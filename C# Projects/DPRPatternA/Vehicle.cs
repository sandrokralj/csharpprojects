using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRPatternA
{
     abstract class Vehicle
    {
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public abstract string GetDescription();
        public abstract double GetPrice();

    }
}
