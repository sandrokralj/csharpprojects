using DesignPatterns.Facade_Pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class RestaurantForm : Form
    {
        Waiter waiter;

        public RestaurantForm()
        {
            InitializeComponent();
            waiter = new Waiter();
            textBox1.Text = "Hello, what would you like to order?";

            listBox1.Items.AddRange(new object[] { "steak" });
            listBox2.Items.AddRange(new object[] { "carpaccio", "salad", "tuna" });
            listBox3.Items.AddRange(new object[] { "bier", "water", "wine", "soda" });
          
        }

      

        

        private void listBox2_MouseClick_1(object sender, MouseEventArgs e)
        {
            listBox4.Items.Add(listBox2.SelectedItem.ToString());
            listBox2.Enabled = false;
        }

        private void listBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            listBox4.Items.Add(listBox1.SelectedItem.ToString());
            listBox1.Enabled = false;
        }

        private void listBox3_MouseClick_1(object sender, MouseEventArgs e)
        {
            listBox4.Items.Add(listBox3.SelectedItem.ToString());
            listBox3.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            waiter.PlaceOrder(listBox2.SelectedItem.ToString(), listBox1.SelectedItem.ToString(), listBox3.SelectedItem.ToString());
            string order = waiter.GetOrder();
            listBox4.Items.Add(order);
            listBox4.Items.Add("Your order is being prepared!");

            button2.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
