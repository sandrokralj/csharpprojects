using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace service
{
    [ServiceContract(CallbackContract = typeof(IServiceCallback))]
    public interface IService
    {
        [OperationContract]
        int GetAskingPrice(string address);

        [OperationContract]
        List<House> GetAvailableHouses();

        [OperationContract]
        OfferStatus MakeAnOffer(string address, int offer);

        [OperationContract(IsOneWay = true)]
        void Connect();

        [OperationContract(IsOneWay = true)]
        void Disconnect();
    }

    public interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void HouseIsNotAvailable(string address);
    }

    [ServiceContract]
    public interface IAdmin
    {
        [OperationContract]
        List<int> GetOffers(string address);
    }

    [DataContract]
    public class House
    { 
        [DataMember]
        public string Address { get; set; }
        public int Capacity { get; set; }
        [DataMember]
        public int Price { get; set; }
        public string SellerName { get; set; }
        public List<int> Offers { get; set; }
    }

    public enum OfferStatus
    {
        Succeeded,
        SucceededAndUnavailable,
        Unavailable
    }

}
