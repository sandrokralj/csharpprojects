using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_Decorator
{
    public interface IBevearage
    {
        string Description();
        double GetPrice();
      
    }

    public class Expresso: IBevearage
    {
        private double price = 0.5;
        public double GetPrice()
        {
            return this.price;
        }

        public string Description()
        {
            return "This is a Expresso";
        }
    }

    public class Cappuccino : IBevearage
    {
        private double price = 1;

        public double GetPrice()
        {
            return this.price;
        }

        public string Description()
        {
            return "This is an Cappuccino ";
        }

    }

    
    public abstract class Decorator :IBevearage
    {
        protected IBevearage beverageWrap;
       
        protected Decorator(IBevearage beverage)
        {
            this.beverageWrap = beverage;
        }

        public abstract double GetPrice();

        public abstract string Description();
    }
}
