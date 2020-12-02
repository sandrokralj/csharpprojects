using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace FastFoodService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class FastFood : IFoodService, IFoodAdmin
    {
        int lastOrder = 0;
        List<int> listOrders = new List<int>();
        List<IFoodAdminCallback> listAdmins = new List<IFoodAdminCallback>();
        List<Product> listProduct = new List<Product>()
        {
            new Product() { Name = "Cola", Price = 1.80, Stock = 2 },
            new Product() { Name = "Chips", Price = 1.50, Stock = 2 },
            new Product() { Name = "Burger", Price = 2.50, Stock = 2 },
            new Product() { Name = "Salad", Price = 2.10, Stock = 2 },
            new Product() { Name = "Ice cream", Price = 1.20, Stock = 2 },
            new Product() { Name = "Coffee", Price = 1.50, Stock = 2 },
            new Product() { Name = "BigBurger", Price = 3.50, Stock = 2 }

        };

        public void Connect()
        {
            IFoodAdminCallback clientCallback = OperationContext.Current.GetCallbackChannel<IFoodAdminCallback>();
            if (!listAdmins.Exists(x => x == clientCallback))
            {
                listAdmins.Add(clientCallback);
            }
        }

        public void CreateOrder(string[] list, int orderNumber)
        {
            IFoodOrderCallback clientCallback = OperationContext.Current.GetCallbackChannel<IFoodOrderCallback>();
            foreach (var item in list)
            {
                if (listProduct.Single(x => x.Name == item).Stock <= 0)
                {
                    clientCallback.OrderStatus(false, $"Item {item} is out of stock.");
                    return;
                }
            }

            foreach (var item in list)
            {
                listProduct.Single(x => x.Name == item).Stock--;
            }

            clientCallback.OrderStatus(true, $"Order {orderNumber} is being prepared.");
            listOrders.Add(orderNumber);

            foreach (var admin in listAdmins)
            {
                admin.NewOrder(orderNumber);
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

        public int GetOrderNumber()
        {
            return ++lastOrder;
        }

        public List<int> GetOrders()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductList()
        {
            return listProduct.Where(x => x.Stock > 0).ToList();
        }
    }
}
