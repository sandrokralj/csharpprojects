using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebshopApp
{


    public partial class Form1 : Form
    {
        private ServiceReference1.WebshopClient proxy;

        public Form1()
        {
            InitializeComponent();

            proxy = new ServiceReference1.WebshopClient();
        }

        private void buttonGetWebshopName_Click(object sender, EventArgs e)
        {
            richTextBoxId.Text = proxy.GetWebshopName();
        }
    }
}
