using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace City_Traffic_Simulation_Application
{
    public class City
    {
        //a collection of crossings connected by roads
        public string Cityname;
        public List<Crossing> allCrossings; //doesn't need direct access to cars, all cars are either on crossings or roads
        public List<Road> allRoads;

        public City()
        {
            allCrossings = new List<Crossing>();
            allRoads = new List<Road>();
        }

        public List<object> Frame(int crossingId) //this function will update everything
        {
            List<object> currentCrossingFrame = new List<object>();
            //virtual positions of entities
            foreach (Crossing c in allCrossings)
            {
                List<object> res =  c.MoveCars();
                if (c.crossingID == crossingId)
                {
                    currentCrossingFrame = res;
                }
            }

            foreach(Road r in allRoads)
            {
                r.MoveCars();
            }
            //virtual states of traffic lights todo

            // 
            return currentCrossingFrame;
        }
    }
}
