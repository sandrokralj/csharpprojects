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
        bool MakeOffer(string address, int offerPrice);


        [OperationContract(IsOneWay = true)]
        void Subscribe();

        [OperationContract(IsOneWay = true)]
        void Unubscribe();
        // TODO: Add your service operations here
    }

    //[ServiceContract]
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
        string address;
        int capacity;
        int askingPrice;
        string sellerName;
        List<string> offers;

        public House(string address, int capacity, int askingPrice, string sellerName)
        {
            this.address = address;
            this.capacity = capacity;
            this.askingPrice = askingPrice;
            this.sellerName = sellerName;
            offers = new List<string>();
        }

        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        [DataMember]
        public int AskingPrice
        {
            get { return askingPrice; }
            set { askingPrice = value; }
        }
        
        public string SellerName
        {
            get { return sellerName; }
            set { sellerName = value; }
        }

        public List<string> Offers
        {
            get { return offers; }
            set { offers = value; }
        }
    }

    [ServiceContract]
    public interface IService2
    {
        [OperationContract]

        List<string> GetOffers(string address);
    }
}
