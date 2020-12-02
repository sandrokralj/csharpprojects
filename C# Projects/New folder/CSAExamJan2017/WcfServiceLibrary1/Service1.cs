using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1, IService2
    {
        List<House> houses;
        List<IService1Callback> clients;

        public Service1()
        {
            houses = new List<House>();
            houses.Add(new House("A 1", 5, 150000, "Bora"));
            houses.Add(new House("B 2", 7, 175000, "Zika"));
            houses.Add(new House("C 3", 3, 200000, "Mile"));
            houses.Add(new House("D 4", 4, 225000, "Zare"));

            clients = new List<IService1Callback>();
        }

        public int GetAskingPrice(string address)
        {
            foreach (House house in houses)
            {
                if(house.Address == address)
                {
                    return house.AskingPrice;
                }
            }

            return -1;
        }

        public List<House> GetAvailableHouses()
        {
            List<House> tempHouses = new List<House>();
            foreach (House house in houses)
            {
                if(house.Capacity > house.Offers.Count)
                {
                    tempHouses.Add(house);
                }
            }
            return tempHouses;
        }

        public List<string> GetOffers(string address)
        {
            foreach (House house in houses)
            {
                if (house.Address == address)
                {
                    return house.Offers;
                }
            }

            return null;
        }

        public bool MakeOffer(string address, int offerPrice)
        {
            foreach (House house in GetAvailableHouses())
            {
                house.Offers.Add(offerPrice.ToString());
                if(house.Capacity <= house.Offers.Count)
                {
                    IService1Callback currentClient = OperationContext.Current.GetCallbackChannel<IService1Callback>();
                    foreach (IService1Callback client in clients)
                    {
                        if(client != currentClient)
                        {
                            client.HouseNotAvailable(house);
                        }
                    }
                }
            }
            return true;
        }

        public void Subscribe()
        {
            IService1Callback client = OperationContext.Current.GetCallbackChannel<IService1Callback>();
            clients.Add(client);
        }

        public void Unubscribe()
        {
            IService1Callback client = OperationContext.Current.GetCallbackChannel<IService1Callback>();
            clients.Remove(client);
        }
    }
}
