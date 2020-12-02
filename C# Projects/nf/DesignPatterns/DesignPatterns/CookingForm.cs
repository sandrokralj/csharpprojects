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
    public partial class CookingForm : Form
    {
        Steak currentSteak;

        public CookingForm()
        {
            InitializeComponent();
            currentSteak = new Steak("T-Bone");
            listBox1.Items.Add("Adjust the temperature to prepare the steak...");
        }




       


        private void buttonIncrease_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Increased temperature by: " + textBoxAmount.Text);
            currentSteak.AddTemp(Convert.ToDouble(textBoxAmount.Text));
            listBox1.Items.Add("Current steak temperature is: " + currentSteak.CurrentTemp);
            listBox1.Items.Add("Current steak state is: " + currentSteak.State.GetType().Name);
            if (currentSteak.CurrentTemp >= 300)
            {
                listBox1.Items.Add("You are burning your steak, decrease the temperature.");
            }
            else if (currentSteak.CurrentTemp == 0 || currentSteak.CurrentTemp <= 50)
            {
                listBox1.Items.Add("Your steak isn't getting ready, increase the temperature.");
                buttonDecrease.Enabled = true;
            }
        }

        private void buttonDecrease_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Decreased temperature by: " + textBoxAmount.Text);
            currentSteak.RemoveTemp(Convert.ToDouble(textBoxAmount.Text));
            listBox1.Items.Add("Current steak temperature is: " + currentSteak.CurrentTemp);
            listBox1.Items.Add("Current steak state is: " + currentSteak.State.GetType().Name);
            if (currentSteak.CurrentTemp == 0 || currentSteak.CurrentTemp <= 50)
            {
                listBox1.Items.Add("Your steak isn't getting ready, increase the temperature.");
                buttonDecrease.Enabled = true;
            }
            else if (currentSteak.CurrentTemp < 0)
            {
                buttonDecrease.Enabled = false;
                listBox1.Items.Add("You cannot go below 0 on a grill.");
            }
        }
    }
}
