using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanoiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Move(int i, int j)
        { this.listBox1.Items.Add("move from " + i + " to " + j); }

        private void Hanoi(int first, int last, int temp, int nrOfDiscs)
        {
            if (nrOfDiscs == 1)
            {
                Move(first, last);
            }
            else
            {
                Hanoi(first,temp,last, nrOfDiscs - 1);
                Move(first, last);
                Hanoi(temp,last,first, nrOfDiscs - 1);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hanoi(1, 3, 2, Convert.ToInt32(this.textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }
    }
}
