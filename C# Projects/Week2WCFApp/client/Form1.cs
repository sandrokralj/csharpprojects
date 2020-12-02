using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        private ServiceRef.CalculatorClient proxy;

        public Form1()
        {
            proxy = new ServiceRef.CalculatorClient();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double answer = proxy.Add(number1, number2);
            textBox3.Text = answer.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double answer = proxy.Substract(number1, number2);
            textBox3.Text = answer.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double answer = proxy.Multiply(number1, number2);
            textBox3.Text = answer.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double answer = proxy.Divide(number1, number2);
            textBox3.Text = answer.ToString();
        }
    }
}
