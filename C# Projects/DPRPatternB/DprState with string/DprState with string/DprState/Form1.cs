using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DprState
{
    public partial class Form1 : Form
    {
        Printer printer;

        public Form1()
        {
            InitializeComponent();
            printer = new Printer(new Waiting());
        }
       
        private void Print_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (printerlb.SelectedItem != null)
            {
                printerlb.ClearSelected();
                printer.printing = true;
                Print.Enabled = false;
                while (printer.printing)
                {
                    listBox1.Items.Add(printer.State.Handle(printer));
                    this.Update();
                }
                Print.Enabled = true;
                printerlb.Items.Clear();
            }
            else
            {
                MessageBox.Show("please select a document to print");
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string document = textBox2.Text;
            if (document != null)
            {
                printerlb.Items.Add(document);
                textBox2.Clear();
            }
        }
    }
}
