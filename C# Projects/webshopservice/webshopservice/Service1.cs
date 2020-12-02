using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWebShopContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IWebshop
    {
        public bool BuyProduct(string ProductId)
        {
            throw new NotImplementedException();
        }

        public string GetProductInfo(string ProductId)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetProductList()
        {
            throw new NotImplementedException();
        }

        public string GetWebshopName()
        {
            return "Hello";
        }
    }
}
