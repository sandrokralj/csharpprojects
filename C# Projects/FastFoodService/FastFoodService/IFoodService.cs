using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FastFoodService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IFoodOrderCallback))]
    public interface IFoodService
    {
        [OperationContract]
        int GetOrderNumber();

        [OperationContract]
        List<Product> GetProductList();

        [OperationContract]
        void CreateOrder(string[] list, int orderNumber);

        // TODO: Add your service operations here
    }

    public interface IFoodOrderCallback
    {
        [OperationContract]
        void OrderStatus(bool status, string message);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "FastFoodService.ContractType".
    [DataContract]
    public class Product
    {
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        [DataMember]
        public double Price
        {
            get;
            set;
        }

        public double Stock { get; internal set; }
    }

    [ServiceContract(CallbackContract = typeof(IFoodAdminCallback))]
    public interface IFoodAdmin
    {
        [OperationContract]
        void Connect();
        [OperationContract]
        void Disconnect();

        [OperationContract(IsOneWay = true)]
        void DeliverOrder(int orderNr);

        [OperationContract]
        List<int> GetOrders();
    }

    public interface IFoodAdminCallback
    {
        [OperationContract(IsOneWay = true)]
        void NewOrder(int orderNr);

        [OperationContract(IsOneWay = true)]
        void OrderDelivered(int orderNr);
    }
}
