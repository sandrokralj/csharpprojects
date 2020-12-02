using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_DecoratorPattern
{
    public interface ICoffee
    {
        string GetDescription();
        double GetPrice();
    }

    public class Filtered : ICoffee
    {
        public string GetDescription()
        {
            return "Your filtered coffee made with care";
        }

        public double GetPrice()
        {
            return 1.99;
        }
    }

    public class Espresso : ICoffee
    {
        public string GetDescription()
        {
            return "An espresso made with care";
        }

        public double GetPrice()
        {
            return 1.49;
        }
    }

    public abstract class Condiments : ICoffee
    {
        ICoffee coffee;
        protected string name = "undefined condiment";
        protected double price = 0.0;

        public Condiments(ICoffee coffee1)
        {
            coffee = coffee1;
        }

        public string GetDescription()
        {
            return coffee.GetDescription() + " \n with added " + name;
        }

        public double GetPrice()
        {
            return coffee.GetPrice() + price;
        }
    }

    public class MilkDecorator : Condiments
    {
        public MilkDecorator(ICoffee coffee)
            :base(coffee)
        {
            name = " milk";
            price = 0.19;
        }
    }

    public class SoyDecorator : Condiments
    {
        public SoyDecorator(ICoffee coffee)
            : base(coffee)
        {
            name = " soy";
            price = 0.39;
        }
    }

    public class WaterDecorator : Condiments
    {
        public WaterDecorator(ICoffee coffee)
            : base(coffee)
        {
            name = " water";
            price = 0.09;
        }
    }

    public class SugarDecorator : Condiments
    {
        public SugarDecorator(ICoffee coffee)
            : base(coffee)
        {
            name = " sugar";
            price = 0.29;
        }
    }

}
