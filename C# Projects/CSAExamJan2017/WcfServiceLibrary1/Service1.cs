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
            houses.Add(new House("A 1", 5, 150000, "John"));
            houses.Add(new House("B 2", 3, 175000, "Sara"));
            houses.Add(new House("C 3", 2, 200000, "Jack"));
            houses.Add(new House("D 4", 4, 225000, "Kea"));

            clients = new List<IService1Callback>();
        }

        public int GetAskingPrice(string address)
        {
            foreach (House house in houses)
            {
                if (house.Address == address)
                {
                    return house.AskingPrice;
                }
            }

            // return -1 if a house is not found with the specified address
            return -1;
        }

        public List<House> GetAvailableHouses()
        {
            List<House> availableHouses = new List<House>();

            foreach (House house in houses)
            {
                if (house.Capacity > house.Offers.Count)
                {
                    availableHouses.Add(house);
                }
            }

            return availableHouses;
        }

        public int MakeOffer(string address, int offerPrice)
        {
            foreach (House house in GetAvailableHouses())
            {
                if (house.Address == address)
                {
                    house.Offers.Add(offerPrice.ToString());

                    if (house.Capacity > house.Offers.Count)
                    {
                        // house is still available
                        return 1;
                    }

                    // house is not available any more
                    IService1Callback cuurentClient =
                OperationContext.Current.GetCallbackChannel<IService1Callback>();

                    foreach (IService1Callback client in clients)
                    {
                        if (client != cuurentClient)
                        {
                            client.HouseNotAvailable(house);
                        }
                    }

                    return 0;
                }
            }

            // house was not foudn
            return -1;
        }

        public void Subscribe()
        {
            IService1Callback client = 
                OperationContext.Current.GetCallbackChannel<IService1Callback>();
            clients.Add(client);
        }

        public void Unsubscribe()
        {
            IService1Callback client =
                OperationContext.Current.GetCallbackChannel<IService1Callback>();
            clients.Remove(client);
        }

        // the second service contract
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
    }
}
