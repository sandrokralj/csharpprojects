using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade_Pattern
{
    class ColdPrep : Kitchen
    {
        public FoodItem PrepDish(string dishName)
        {
            return new FoodItem()
            {
                DishName = dishName
            };
        }
    }
}
