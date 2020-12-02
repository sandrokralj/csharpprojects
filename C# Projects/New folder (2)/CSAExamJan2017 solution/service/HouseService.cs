using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class HouseService : IService, IAdmin
    {
        List<IServiceCallback> clients = new List<IServiceCallback>();
        List<House> houses = new List<House>() {
            new House() { Address="address 1", Price= 100000, Capacity=3, Offers=new List<int>(), SellerName="Bob" },
            new House() { Address="address 2", Price= 300000, Capacity=5, Offers=new List<int>(), SellerName="Tom" },
            new House() { Address="address 3", Price= 200000, Capacity=6, Offers=new List<int>(), SellerName="Sully" }
        };

        public void Connect()
        {
            clients.Add(OperationContext.Current.GetCallbackChannel<IServiceCallback>());
        }

        public void Disconnect()
        {
            clients.Remove(OperationContext.Current.GetCallbackChannel<IServiceCallback>());
        }

        public int GetAskingPrice(string address)
        {
            foreach (House house in houses)
            {
                if (house.Address == address)
                {
                    return house.Price;
                }
            }
            return 0;

            // Alternatively, a lambda expression can be used:
            House h = houses.FirstOrDefault(x => x.Address == address);

            // ternary operator
            return h == null ? -1 : h.Price;
        }

        public List<House> GetAvailableHouses()
        {
            List<House> housesToReturn = new List<House>();
            foreach (House h in houses)
            {
                if (h.Capacity>h.Offers.Count)
                {
                    housesToReturn.Add(h);
                }
            }
            return housesToReturn;

            // the same with lambda expression:            
            //return houses.Where(x => x.Capacity > 100).ToList<House>();
        }

        public List<int> GetOffers(string address)
        {
            foreach (var h in houses)
            {
                if (h.Address==address)
                {
                    return h.Offers;
                }
            }
            return new List<int>(); // Returning empty list instead of null, on a client side does not require to check if result is not null.

            // Lambda:
            // return houses.Find(x => x.Address == address).Offers;
        }

        // We have 3 cases:
        // (OfferStatus.Succeeded) Offer is made and house is still available for future offers;
        // (OfferStatus.SucceededAndUnavailable) Offer is made, but a house become unavailable for future offers;
        // (OfferStatus.Unavailable) Offer cannot be made.
        public OfferStatus MakeAnOffer(string address, int offer)
        {
            IServiceCallback client = OperationContext.Current.GetCallbackChannel<IServiceCallback>();

            // Exercise 3: Make an offer.
            foreach (House h in GetAvailableHouses())
            {
                if (h.Address == address)
                {
                    h.Offers.Add(offer);
                    if (h.Capacity > h.Offers.Count)
                    {
                        return OfferStatus.Succeeded;
                    }
                    else
                    {
                        return OfferStatus.SucceededAndUnavailable;
                    }
                } 
            }

            // Exercise 4: ... Service should automatically notify all other(!) connected Clients about this event:
            foreach (IServiceCallback c in clients)
            {
                if (c!= client)
                {
                    c.HouseIsNotAvailable(address);
                }
            }
            return OfferStatus.Unavailable;
        }
    }
}
