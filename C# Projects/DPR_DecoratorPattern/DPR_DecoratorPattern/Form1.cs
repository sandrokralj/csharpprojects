using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPR_DecoratorPattern
{
    public partial class Form1 : Form
    {
        ICoffee coffee;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCoffee_Click(object sender, EventArgs e)
        {
            if(radioButtonEspresso.Checked == true)
            {
                coffee = new Espresso();
            }
            else if (radioButtonFiltered.Checked == true)
            {
                coffee = new Filtered();
            }

            labelDescription.Text = coffee.GetDescription();
            labelPrice.Text = "Price: " + coffee.GetPrice().ToString();
            buttonCondiment.Enabled = true;
            checkBoxWater.Enabled = true;
            checkBoxSugar.Enabled = true;
            checkBoxSoy.Enabled = true;
            checkBoxMilk.Enabled = true;
        }

        private void buttonCondiment_Click(object sender, EventArgs e)
        {
            if(radioButtonEspresso.Checked || radioButtonFiltered.Checked)
            {
                if (checkBoxMilk.Checked)
                {
                    coffee = new MilkDecorator(coffee);
                    checkBoxMilk.Enabled = false;
                }

                if (checkBoxSoy.Checked)
                {
                    coffee = new SoyDecorator(coffee);
                    checkBoxSoy.Enabled = false;
                }

                if (checkBoxSugar.Checked)
                {
                    coffee = new SugarDecorator(coffee);
                    checkBoxSugar.Enabled = false;
                }

                if (checkBoxWater.Checked)
                {
                    coffee = new WaterDecorator(coffee);
                    checkBoxWater.Enabled = false;
                }

                else
                {
                    labelDescription.Text = coffee.GetDescription() + "\nPrice: " + coffee.GetPrice().ToString();
                }
            }
            checkBoxMilk.Checked = false;
            checkBoxSoy.Checked = false;
            checkBoxSugar.Checked = false;
            checkBoxWater.Checked = false;
            checkBoxWater.Enabled = false;
            checkBoxSugar.Enabled = false;
            checkBoxSoy.Enabled = false;
            checkBoxMilk.Enabled = false;
            buttonCondiment.Enabled = false;
            labelDescription.Text = coffee.GetDescription() + "\nPrice: " + coffee.GetPrice().ToString();
            //labelPrice.Text 
        }
    }
}
