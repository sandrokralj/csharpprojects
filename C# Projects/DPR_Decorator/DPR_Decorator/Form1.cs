using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPR_Decorator
{
    public partial class Form1 : Form
    {
        IBevearage coffe;
       
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (radioButton2.Checked)
                {
                    coffe = new Expresso();
                }
                else if (radioButton1.Checked)
                {
                    coffe = new Cappuccino();
                }
            listBox2.Items.Clear();
            listBox2.Items.Add(coffe.Description());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked || radioButton1.Checked)
            {
                if (checkBox1.Checked)
                {
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    coffe = new Milk(coffe);
                    
                }
                else if (checkBox2.Checked)
                {
                    checkBox1.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    coffe = new Soy(coffe);
                    
                }
                else if (checkBox3.Checked)
                {
                    checkBox2.Checked = false;
                    checkBox1.Checked = false;
                    checkBox4.Checked = false;
                    coffe = new Whip(coffe);
                    
                }
                else
                {
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox1.Checked = false;
                    coffe = new Sugar(coffe);
                    
                }
            }

            
            textBoxResult.Text = coffe.GetPrice().ToString();
            //listBox2.Items.Clear();
            listBox2.Items.Add(coffe.Description());

        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            //listBox2.Items.Clear();
            listBox2.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           
        }
    }
}
