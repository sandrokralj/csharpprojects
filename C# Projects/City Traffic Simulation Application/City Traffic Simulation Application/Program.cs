using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace City_Traffic_Simulation_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // creating objects for the serialisation 
            //SerializeData sdata = new SerializeData("dinga.txt");
            //Car  c= new Car(new System.Drawing.Point(2,3),new Waypoint(2,7),5,9);
            //sdata.SerialiseObjects(c);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Traffic_simulaator());
        }
    }
}
