using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace City_Traffic_Simulation_Application
{[Serializable]
    public class Road
    {
        Crossing pointA;
        Crossing pointB;
        Car[] cars;

        public Crossing PointA {
            get { return pointA; }
            set
            {
                if (value == pointB) { throw new Exception("Road endpoint is equal to starting point."); }
                else { pointA = value; }
            }
        } //Connection 1 property

        public Crossing PointB
        {
            get { return pointB; }
            set
            {
                if (value == pointA) { throw new Exception("Road endpoint is equal to starting point."); }
                else { pointB = value; }
            }
        }// Connection 2 property

        public double length { get; set; }
        public double speedlimit { get; set; }


        public void MoveCars()
        {
            foreach (Car c in cars)
            {
                c.MoveRoad();
            }
        }
    }
}
