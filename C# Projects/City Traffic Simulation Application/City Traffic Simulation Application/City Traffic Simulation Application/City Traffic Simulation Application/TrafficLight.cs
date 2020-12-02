using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City_Traffic_Simulation_Application
{
  public  class TrafficLight
    {
        //trafficlights manage which cars get to move and which do not. this is determined by what direction the car is coming from and what direction the car is moving to.
        public Road North;
        public enum Patterns {  }//make patterns
        public enum Directions
        {
            X = -1,
            R = 0,
            S = 1,
            L = 2
        }

        public string[] Pattern
        {
            get; set;
        }

    }
}
