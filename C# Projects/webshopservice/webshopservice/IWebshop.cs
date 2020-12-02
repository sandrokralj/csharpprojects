using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWebShopContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "MyWebShopContract")]
    public interface IWebshop
    {
        [OperationContract]
        string GetWebshopName();

        [OperationContract]
        List<Item> GetProductList();

        [OperationContract]
        string GetProductInfo(string ProductId);

        [OperationContract]
        bool BuyProduct(string ProductId);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "webshopservice.ContractType".
    [DataContract]
    public class Item
    {
        [DataMember]
        public string ProductId
        {
            get; set;
        }

        public string ProductInfo
        {
            get; set;
        }

        [DataMember]
        public double Price
        {
            get; set;
        }

        [DataMember]
        public int Stock
        {
            get; set;
        }

        public bool OnSale
        {
            get; set;
        }
    }
}
