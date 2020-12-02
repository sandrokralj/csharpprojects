using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace City_Traffic_Simulation_Application
{
    [Serializable]
  public  class Waypoint
    {
        //waypoints are a coordinate on the map. when the final waypoint is reached the entity will be sent to a Road.
        public Waypoint nextWaypoint;
        public Waypoint waypointStraight;
        public Waypoint waypointLeft;
        public Waypoint waypointRight;
        public string End;
        public int waitingcars =0;
        private bool redlight = false;
        public delegate void GreenLightHandler(Waypoint sender, EventArgs e);
        public event GreenLightHandler turngreen;

        public double x;
        public double y;


        public bool RedLight
        {
            get { return redlight; }
            set
            {
                redlight = value;
                if (value == false)
                {
                    if (turngreen!= null)
                    {
                        OnTurnGreen(new EventArgs());
                    }
                }
            }
        }
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
            waypointStraight = w;
            waypointLeft = w;
            waypointRight = w;
        }
        public Waypoint (Point p, Waypoint w)
        {
            this.x = p.X;
            this.y = p.Y;
            this.nextWaypoint = w;
            waypointStraight = w;
            waypointLeft = w;
            waypointRight = w;
        }
        public Waypoint(Point p)
        {
            this.x = p.X;
            this.y = p.Y;
        }

        protected virtual void OnTurnGreen(EventArgs e)
        {
            waitingcars = 0;
            turngreen(this,e);
            
        }
        public void Draw(ref Graphics gr)
        {

            Color c = Color.LimeGreen;
            if (RedLight == true)
                c = Color.Red;
            Brush b = new SolidBrush(c);
            gr.FillEllipse(b, (float)x-5, (float)y-5, 10,10);
        }
    }
}
