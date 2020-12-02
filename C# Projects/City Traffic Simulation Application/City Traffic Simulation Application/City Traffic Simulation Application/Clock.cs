using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City_Traffic_Simulation_Application
{
    class Clock
    {
        //the clock moves entities every frame and switches traffic light patterns from time to time.
        public DateTime StartTime { get; set; }
        public DateTime CurrentTime { get; set; } 
        public static double dt { get; set; } //the time elapsed since last frame

        public bool running;


        public Clock()
        {
            running = false;
            dt = 30;
        }
        public void Start ()
        {
            running = true;
            while (running == true)
            {

            }
        }

        public void Stop ()
        {

        }

        public void Reset ()
        {

        }
    }
}
