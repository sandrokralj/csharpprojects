using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        static int orderNumber;

        List<int> completeOrders;

        List<Product> products;

        public Service1()
        {
            orderNumber = 0;

            completeOrders = new List<int>();

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

        public int GetOrderNumber()
        {
            //if initially order number is 1, then "return orderNumber++;"
            return ++orderNumber;
        }

        public List<Product> GetProducts()
        {
            return getAvailableProducts();
        }

        public string MakeOrder(int orderNumber, List<string> selectedProducts)
        {
            if (selectedProducts.Count <= 0)
            {
                return "You did not select any products.";
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

            completeOrders.Add(orderNumber);

            return "Your order is complete.";
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
