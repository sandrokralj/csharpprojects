using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorContract;

namespace client
{
    public partial class Form1 : Form
    {
        CalculatorClient proxy;
        public Form1()
        {
            InitializeComponent();
            // instantiate a proxy to contact the service

            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorservice");
            EndpointAddress endpointAddress = new EndpointAddress(address);
            proxy = new CalculatorClient(binding, endpointAddress);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);

            double number2 = Convert.ToDouble(textBox2.Text);

            double answer = proxy.GetCalculatorService().Add(number1, number2);

            textBox3.Text = answer.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);

            double number2 = Convert.ToDouble(textBox2.Text);

            double answer = proxy.GetCalculatorService().Substract(number1, number2);

            textBox3.Text = answer.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);

            double number2 = Convert.ToDouble(textBox2.Text);

            double answer = proxy.GetCalculatorService().Multiply(number1, number2);

            textBox3.Text = answer.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);

            double number2 = Convert.ToDouble(textBox2.Text);

            double answer = proxy.GetCalculatorService().Divide(number1, number2);

            textBox3.Text = answer.ToString();
        }
    }
}
