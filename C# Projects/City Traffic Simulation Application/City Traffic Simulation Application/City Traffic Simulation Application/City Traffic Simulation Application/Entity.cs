using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace City_Traffic_Simulation_Application
{
    public class Entity
    {
        private Waypoint nextWayPoint { get; set; }

        public static int lastEntityId { get; set; } = 0;

        public int id { get; set; }
        public double maxSpeed { get; set; }
        public double Speed { get; set; }
        public double Accel { get; set; }
        public double Decel { get; set; }
        public Road road { get; set; } //Road object the car is on. these may be moved to the car specific class if we don't let pedestrians have roads
        public double roadProgress { get; set; } //determines how far a car is along a road

        private double distanceTillWaypoint;

        double x;
        double y;
        double ratioX;
        double ratioY;

        public Entity()
        {
            this.id = ++lastEntityId;
        }
        public Entity( double x, double y, Waypoint w)
        {
            this.id = ++lastEntityId;
            this.nextWayPoint = w;
            this.x = x;
            this.y = y;
            CalculateDirection(x, y, w);
        }
        public Entity(Road r)
        {
            this.id = ++lastEntityId;
            this.road = r;
        }


        public Entity (Point p, Waypoint w)
        {
            this.id = ++lastEntityId;
            this.nextWayPoint = w;
            this.x = p.X;
            this.y = p.Y;
            CalculateDirection(x, y, w);
        }


        public int[] Move() //method for onscreen entities
        {
            if (nextWayPoint == null)
            {
                return new int[3] { (int)x, (int)y, id };  // do nothing if there is nowhere to go
            }

            ChangeSpeed();

            /* . A
             * |\
             * | \  <-frameSpeedH
             * |__\
             * | x \ 
             * |    \
             * |     \  <-straight line through waypoint B
             * |______\. B
             *    x' 
             *   x/framespeedH == x'/AB == ratioX -> similar triangles
             */
            double frameSpeedH = Clock.dt * Speed; //Hypotenuse of similar triangle
            x += ratioX * frameSpeedH;
            y += ratioY * frameSpeedH;
            distanceTillWaypoint -= frameSpeedH;

            if (distanceTillWaypoint <= 0)
            {
                CalculateDirection(x, y, nextWayPoint.nextWaypoint);
            }


            int xRound = Convert.ToInt32(x);
            int yRound = Convert.ToInt32(y);
            int[] result = new int[3]{xRound, yRound, id};
            return result ; //returns the updated Point value for the entity
        }

        private void CalculateDirection(double x, double y, Waypoint w) //method that 
        {
            if(w==null)
            {
                //todo make an event(?) to put the car on a road
                //or, add a reference to a road object in the waypoint class and put the car on that road
            }

            double deltaX = w.x - x;
            double deltaY = w.y - y;

            double deltaH = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            distanceTillWaypoint = deltaH;

            ratioX = deltaX / deltaH;
            ratioY = deltaY / deltaH;

            //double[] result = new double[2] {ratioX, ratioY };
            //return result; 
        }

        
        public void MoveRoad()
        {
            //todo implement. Increases roadProgress according to road.maxspeed and road.lenght . 
            //When over 100%, put a reference to the car in the Crossing object it enters, give it a location and route to follow
            //remove reference to the car from the road

        }

        private void ChangeSpeed()
        {
            if (Speed <= maxSpeed)
            {
                Speed += Accel * Clock.dt;
            }
            else if (Speed - maxSpeed > Speed * 0.1f)
            {
                Speed -= Decel * Clock.dt;
            }
        }
    }
}
