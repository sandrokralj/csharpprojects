using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRPatternA
{
    public partial class Form1 : Form
    {
        List<Vehicle> vehicles;
        Vehicle vehicle;
        public Form1()
        {
            InitializeComponent();
            vehicles = new List<Vehicle>() { new Car(125000,"Tesla"),
                                            new Truck(3000,350000),
                                            new Bike(320,12000)};

        }

        private void button1_Click(object sender, EventArgs e)
        {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                foreach (Vehicle v in vehicles)
                {
                listBox1.Items.Add(v.GetDescription());
                listBox2.Items.Add(v.GetPrice());


                }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           foreach(Vehicle v in vehicles)
            {
                vehicle = new Oil(v);
                listBox1.Items.Add(vehicle.GetDescription());

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Vehicle v in vehicles)
            {
                vehicle = new Tires(v);
                listBox1.Items.Add(vehicle.GetDescription());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Vehicle v in vehicles)
            {
                vehicle = new Fuel(v);
                listBox1.Items.Add(vehicle.GetDescription());

            }
        }
    }
}
