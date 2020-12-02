using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Runtime.Serialization.Formatters.Binary;

namespace City_Traffic_Simulation_Application
{
    
    public class City
    {
        //a collection of crossings connected by roads
        public List<Crossing> allCrossings; //doesn't need direct access to cars, all cars are either on crossings or roads
        public string CityName { get; set; }


        public City(string cityname)
        {
            allCrossings = new List<Crossing>();
            this.CityName = cityname;

        }

        public List<object> Frame(int crossingId) //this function will update everything
        {
            List<object> currentCrossingFrame = new List<object>();
            //virtual positions of entities
            foreach (Crossing c in allCrossings)
            {
                List<object> res = new List<object>(); //c.MoveCars();
                if (c.crossingID == crossingId)
                {
                    currentCrossingFrame = res;
                }
            }

            //virtual states of traffic lights todo

            // 
            return currentCrossingFrame;
        }
    }
}
