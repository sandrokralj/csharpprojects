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
        ServiceReference1.WebshopClient proxy;

        public Form1()
        {
            InitializeComponent();
            proxy = new ServiceReference1.WebshopClient();
        }

        private void buttonWebshopName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
