using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1, IService2
    {
        static int orderNumber;

        List<Order> completeOrders;

        List<Product> products;

        public Service1()
        {
            orderNumber = 0;

            completeOrders = new List<Order>();

            products = new List<Product>
            {
                new Product("Cola", 1.8, 10),
                new Product("Chips", 1.5, 7),
                new Product("Burgr", 2.5, 11),
                new Product("Salad", 2.1, 3),
                new Product("Coffee", 1.5, 99),
                new Product("Tea", 1.1, 0),
                new Product("Milk", 0.7, 1)
            };
        }

        public bool DeliverOrder(int orderNumber)
        {
            foreach (Order order in completeOrders)
            {
                if (orderNumber == order.orderNumber)
                {
                    order.client.OrderStatus("Your order " + order.orderNumber + " is ready.");
                    completeOrders.Remove(order);
                    return true;
                }
            }

            return false;
        }

        public int GetOrderNumber()
        {
            //if initially order number is 1, then "return orderNumber++;"
            return ++orderNumber;
        }

        public List<Order> GetOrderNumbers()
        {
            return completeOrders;
        }

        public List<Product> GetProducts()
        {
            return getAvailableProducts();
        }

        public string MakeOrder(int orderNumber, List<string> selectedProducts)
        {
            if (selectedProducts.Count <= 0)
            {
                return "You did not select any product.";
            }

            foreach (Product product in products)
            {
                foreach (String selectedProduct in selectedProducts)
                {
                    if (product.Name == selectedProduct && 
                        product.Stock <= 0)
                    {
                        return selectedProduct + " is out of stock";
                    }
                }
            }

            foreach (Product product in products)
            {
                foreach (String selectedProduct in selectedProducts)
                {
                    if (product.Name == selectedProduct)
                    {
                        product.Stock--;
                    }
                }
            }

            IService1Callback client =
                OperationContext.Current.GetCallbackChannel<IService1Callback>();
            Order order = new Order(orderNumber, client);
            completeOrders.Add(order);

            return "Your order " + orderNumber + " is prepared.";
        }

        private List<Product> getAvailableProducts()
        {
            List<Product> availableProducts = new List<Product>();

            foreach (Product product in products)
            {
                if (product.Stock > 0)
                {
                    availableProducts.Add(product);
                }
            }

            return availableProducts;
        }
    }
}
