using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPR_Decorator
{
    class Whip : Decorator
    {
        public Whip(IBevearage b) : base(b)
        {
            
        }


        public override double GetPrice()
        {
            return beverageWrap.GetPrice() + 0.25;
        }

        public override string Description()
        {
            return "Whip";
        }
        
    }

    class Sugar:Decorator
    {
       
        public Sugar(IBevearage b) : base(b)
        {
           
        }
        public override double GetPrice()
        {
            return beverageWrap.GetPrice() + 0.05;
        }

        public override string Description()
        {
            return "Sugar";
        }
        
    }

    class Soy:Decorator
    {
        
        public Soy(IBevearage b) : base(b)
        {
          
        }
        public override double GetPrice()
        {
            return beverageWrap.GetPrice() + 0.75;
        }
        public override string Description()
        {
            return "Soy";
        }
       
    }

    class Milk:Decorator
    {
        public Milk(IBevearage b) : base(b)
        {
            
        }
        public override double GetPrice()
        {
            return beverageWrap.GetPrice() + 0.65;
        }

        public override string Description()
        {
            return "Milk";
        }
        
    }
}
