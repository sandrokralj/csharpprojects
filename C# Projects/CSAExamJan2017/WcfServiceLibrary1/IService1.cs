using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IService1Callback))]
    public interface IService1
    {
        [OperationContract]
        int GetAskingPrice(string address);

        [OperationContract]
        List<House> GetAvailableHouses();

        [OperationContract]
        int MakeOffer(string address, int offerPrice);

        [OperationContract(IsOneWay = true)]
        void Subscribe();

        [OperationContract(IsOneWay = true)]
        void Unsubscribe();
    }

    public interface IService1Callback
    {
        [OperationContract(IsOneWay = true)]
        void HouseNotAvailable(House house);
    }
        // Use a data contract as illustrated in the sample below to add composite types to service operations.
        // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary1.ContractType".
        [DataContract]
    public class House
    {
        [DataMember]
        public string Address { get; set; }

        public int Capacity { get; set; }

        [DataMember]
        public int AskingPrice { get; set; }

        public string SellerName { get; set; }

        public List<string> Offers { get; set; }

        public House(string address, int capacity, 
                        int askingPrice, string sellerName)
        {
            Address = address;
            Capacity = capacity;
            AskingPrice = askingPrice;
            SellerName = sellerName;
            Offers = new List<string>();
        }
    }

    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        List<string> GetOffers(string address);
    }
}
