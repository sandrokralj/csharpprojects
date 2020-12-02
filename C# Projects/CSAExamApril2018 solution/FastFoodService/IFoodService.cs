using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FastFoodService
{
    [ServiceContract(CallbackContract =typeof(IFoodOrderCallback))]
    public interface IFoodOrder
    {
        [OperationContract]
        int GetOderNumber();

        [OperationContract]
        List<Product> GetProductList();

        [OperationContract(IsOneWay = true)]
        void CreateOrder(string[] list, int orderNr);
    }

    public interface IFoodOrderCallback
    {
        [OperationContract]
        void OrderStatus(bool status, string message);
    }

    [DataContract]
    public class Product
    {

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double Price { get; set; }

        public int Stock { get; internal set; }
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

        [OperationContract(IsOneWay =true)]
        void OrderDelivered(int orderNr);
    }
}
