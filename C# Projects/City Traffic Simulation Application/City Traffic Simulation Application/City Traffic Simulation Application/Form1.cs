using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Traffic_Simulation_Application
{
    public partial class Form1 : Form
    {
        Clock clock = new Clock();
        City city = new City();
        List<PictureBox> Boxes;
        public Form1()
        {
            
            InitializeComponent();
            TestPointsCar();
        }



        private void TestPointsCar()
        {
            Waypoint w2 = new Waypoint(waypoint2.Location);
            Waypoint w1 = new Waypoint(waypoint1.Location, w2); // this makes some test waypoints
            


            Crossing crossing = new Crossing();
            crossing.crossingID = 1;
            Car car = new Car(pictureBox1.Location, w1);
            crossing.cars.Add(car);
            city.allCrossings.Add(crossing);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            List<object> carData = city.Frame(1); //puts out a list of points for how to move picture boxes
            /*
            foreach(PictureBox i in Boxes)
            {
                // change the location of the boxes       // code is supposed to run for all pictureboxes
                Point x = i.Location;
                
                foreach (object o in carData)
                {
                    int[] array = (int[])o;
                    
                    if ("Car"+array[2].ToString()  == i.Name)
                    {
                        i.Location = new Point(array[0], array[1]);
                    }
                }
                //x.Offset(1, 0); todo consider whether to use offset instead?
            }
            */
            foreach (object o in carData) //temporary testing code for a single picturebox
            {
                int[] array = (int[])o;

                
                    pictureBox1.Location = new Point(array[0], array[1]);
                
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
