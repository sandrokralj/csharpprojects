using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace City_Traffic_Simulation_Application
{
  public  class Waypoint
    {
        //waypoints are a coordinate on the map. when the final waypoint is reached the entity will be sent to a Road.
        public Waypoint nextWaypoint;

        public double x;
        public double y;


        public Waypoint (double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Waypoint (double x, double y, Waypoint w)
        {
            this.x = x;
            this.y = y;
            this.nextWaypoint = w;
        }

        public Waypoint (Point p, Waypoint w)
        {
            this.x = p.X;
            this.y = p.Y;
            this.nextWaypoint = w;
        }

        public Waypoint(Point p)
        {
            this.x = p.X;
            this.y = p.Y;
        }
    }
}
