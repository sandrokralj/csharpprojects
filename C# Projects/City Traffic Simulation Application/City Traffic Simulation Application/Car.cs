using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace City_Traffic_Simulation_Application
{
    [Serializable]
   public class Car : Entity
    {
        //will be inheriting from Entity
        private Point location; //location on the crossing, upper left corner of the drawing
        private int width; //width (in pixels) of the visual representation of a car, X
        private int height; //height (in pixels) of the visual representation of a car, Y

        public Car(Point p, Waypoint w,int width, int height) : base(p,w)
        {
            this.maxSpeed = 0.1;
            this.Speed = 0;
            this.Accel = 0.0001;
            xoffset = width/2;
            yoffset = height/2;
            CalculateDirection(x, y, nextWayPoint);
        }

        public Car(Point loc, int width, int height)
        {
            this.location = loc;
            this.width = 15;
            this.height = 15;

        }

        public Car(Point p, Waypoint w, int width, int height, int direction) : base(p, w)
        {
            this.maxSpeed = 0.1;
            this.Speed = 0;
            this.Accel = 0.0001;
            xoffset = width / 2;
            yoffset = height / 2;
            CalculateDirection(x, y, nextWayPoint);
            path = direction;
        }

        public Car(Waypoint w, int ticktime): base (w.x,w.y,w)
        {
            this.maxSpeed = 0.1;
            this.Speed = 0;
            this.Accel = 0.0001;
            this.width = 15;
            this.height = 10;
            xoffset = width / 2;
            yoffset = height / 2;
            RandomDirection();
            this.ticktime = ticktime;
        }

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }


        public void Draw(ref Graphics gr)
        {
            gr.FillRectangle(color, (float)this.x-xoffset, (float)this.y-yoffset, this.width, this.height);
        }
    }
}
