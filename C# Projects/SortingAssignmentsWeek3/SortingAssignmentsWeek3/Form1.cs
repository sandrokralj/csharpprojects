using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAssignmentsWeek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int sumSquares(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (i * i);
            }
            return sum;
        }

        public int sumDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;

            //int result = Convert.ToInt32(textBox1.Text).ToString().Sum(c => c - '0');
            //return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            textBox2.Text = Convert.ToString(sumSquares(n));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            textBox2.Text = Convert.ToString(sumDigits(n));
        }
    }
}
