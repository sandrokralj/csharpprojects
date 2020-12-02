using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorContract;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace client
{
    public partial class Form1 : Form
    {
        CalculatorClientProxy proxy;

        public Form1()
        {
            // instantiate a proxy to contact the service

            WSHttpBinding binding = new WSHttpBinding();

            Uri address = new Uri("http://localhost:8000/calculatorservice");

            EndpointAddress endpointAddress = new EndpointAddress(address);

            proxy = new CalculatorClientProxy(binding, endpointAddress);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);

            double number2 = Convert.ToDouble(textBox2.Text);

            double answer = proxy.GetCalculatorService().Add(number1, number2);

            textBox3.Text = answer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);

            double number2 = Convert.ToDouble(textBox2.Text);

            double answer = proxy.GetCalculatorService().Substract(number1, number2);

            textBox3.Text = answer.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);

            double number2 = Convert.ToDouble(textBox2.Text);

            double answer = proxy.GetCalculatorService().Multiply(number1, number2);

            textBox3.Text = answer.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);

            double number2 = Convert.ToDouble(textBox2.Text);

            double answer = proxy.GetCalculatorService().Divide(number1, number2);

            textBox3.Text = answer.ToString();
        }
    }
}
