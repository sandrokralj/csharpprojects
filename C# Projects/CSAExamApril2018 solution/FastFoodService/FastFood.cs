using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace FastFoodService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode =  ConcurrencyMode.Reentrant)]
    public class FastFood : IFoodOrder, IFoodAdmin
    {

        int lastOrder = 0;
        List<int> listOrders = new List<int>();
        List<IFoodAdminCallback> listAdmins = new List<IFoodAdminCallback>();
        List<Product> listProducts = new List<Product>() {
            new Product(){ Name = "Cola", Price=1.80, Stock=2 },
            new Product(){ Name = "Chips", Price = 1.50, Stock=2 },
            new Product(){ Name = "Burger", Price=2.50, Stock=2 },
            new Product(){ Name = "Salads", Price=2.10, Stock=2 },
            new Product(){ Name = "Ice cream", Price=1.20, Stock=2 },
            new Product(){ Name = "Coffee", Price=1.50, Stock=2 },
            new Product(){ Name = "BigBurger", Price=3.50, Stock=2 }
        };

        public void Connect()
        {
            IFoodAdminCallback clientCallback = OperationContext.Current.GetCallbackChannel<IFoodAdminCallback>();
            if (!listAdmins.Exists(x=>x == clientCallback))
            {
                listAdmins.Add(clientCallback);
            }
        }

        public void CreateOrder(string[] list, int orderNr)
        {
           
            IFoodOrderCallback clientCallback = OperationContext.Current.GetCallbackChannel<IFoodOrderCallback>();
            foreach (var item in list)
            {
                if (listProducts.Single(x=>x.Name==item).Stock<=0)
                {
                    clientCallback.OrderStatus(false, $"Item {item} is out of stock.");
                    return;
                }
            }

            foreach (var item in list)
            {
                listProducts.Single(x => x.Name == item).Stock--;
            }

            clientCallback.OrderStatus(true, $"Order {orderNr} is being prepared.");
            listOrders.Add(orderNr);

            foreach (var admin in listAdmins)
            {
                admin.NewOrder(orderNr);
            }
        }

        public void DeliverOrder(int orderNr)
        {
            listOrders.Remove(orderNr);
            foreach (var admin in listAdmins)
            {
                admin.OrderDelivered(orderNr);
            }
        }

        public void Disconnect()
        {
            IFoodAdminCallback clientCallback = OperationContext.Current.GetCallbackChannel<IFoodAdminCallback>();
            listAdmins.Remove(clientCallback);
        }

        public int GetOderNumber()
        {
            return ++lastOrder;
        }

        public List<int> GetOrders()
        {
            return listOrders;
        }

        public List<Product> GetProductList()
        {
            return listProducts.Where(x => x.Stock>0).ToList();
        }
    }
}
