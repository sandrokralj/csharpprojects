using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRPatternA
{
    class Bike : Vehicle
    {
        private int speed;
        public Bike(int speed, double price)
        {
            this.speed = speed;
            this.Price = price;


        }

        public override string GetDescription()
        {
            return "Bike with max speed: " + speed;
        }

        public override double GetPrice()
        {
            return Price;
        }
    }
    }
