using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City_Traffic_Simulation_Application
{
    
  public   class Crossing
    {
        // a meeting point of roads. has a map. has traffic lights. has entities. 
        private Road North;
        private Road South;
        private Road East;     //may be changed to an array of connected roads instead
        private Road West;
        public List<Car> cars;
        public int crossingID;
        static int lastCrossing = 0;

        public Crossing()
        {
            crossingID = ++lastCrossing;
            cars = new List<Car>();
        }

        public List<object> MoveCars()
        {
            List<object> carCoordinates= new List<object> { };
            foreach (Car c in cars)
            {
              carCoordinates.Add(c.Move());

            }
            return carCoordinates;
        }
    }
}
