using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade_Pattern
{
    class Waiter
    {
        private ColdPrep _coldPrep = new ColdPrep();
        private Bar _bar = new Bar();
        private HotPrep _hotPrep = new HotPrep();
        
        Order order;

        public Order PlaceOrder(string coldDishId,string hotDishId, string drinkId)
        {
            
             order = new Order();

            order.Appetizer = _coldPrep.PrepDish(coldDishId);
            order.Entree = _hotPrep.PrepDish(hotDishId);
            order.Drink = _bar.PrepDish(drinkId);

            return order;
        }

        public string GetOrder()
        {

           return "Cold dish: " +  order.Appetizer.DishName + ", Hot dish: " + order.Entree.DishName + ", Drink: " + order.Drink.DishName; 
        }
    }
}
