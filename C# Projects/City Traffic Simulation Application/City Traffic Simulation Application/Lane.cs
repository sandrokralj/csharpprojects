using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace City_Traffic_Simulation_Application
{
    [Serializable]
    class Lane
    {
        private List<Car> carList;
        //private string direction;
        private int height; //height (in pixels) of the visual representation of a lane, Y
        private int width; //width (in pixels) of the visual representation of a lane, X
        private Point location; //Initial location according to the form ex: upper left corner
        private Rectangle boundaries;//The boundaries of the lane

        public Lane(Point loc, int widthLn, int heigthLn)
        {
            this.carList = new List<Car>();

            this.location = loc;
            this.height = heigthLn;
            this.width = widthLn;
            this.boundaries = new Rectangle(loc, new Size(width, height));
            
        }

        public List<Car> CarList
        {
            get { return carList; }
            set { carList = value; }
        }

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Height
        {
            get { return height; }
        }

        public int Width
        {
            get { return width; }
        }

        public Rectangle Boundaries
        {
            get { return boundaries; }
        }

        public void PlaceCars(Graphics gr)
        {
            foreach (Car car in carList)
            {
                car.Draw(ref gr);
            }
        }
    }
}
