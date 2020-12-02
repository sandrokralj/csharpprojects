using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWebshopContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "MyWebshopContract")]
    public interface IWebshop
    {
        [OperationContract]
        string GetWebshopName();

        [OperationContract]
        List<Item> GetProductList();

        [OperationContract]
        string GetProductInfo(String ProductId);

        [OperationContract]
        bool BuyProduct(string ProductId);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "webshopservice.ContractType".
    [DataContract]
    public class Item
    {
        public String ProductId { get; set; }

        public String ProductInfo { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        public bool OnSale { get; set; }
    }
}
