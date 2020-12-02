using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using admin_client.ServiceReference1;

namespace admin_client
{
    public partial class AdminForm : Form
    {
        Service2Client proxy;
        public AdminForm()
        {
            InitializeComponent();

            proxy = new Service2Client();
        }

        private void btnGetOffers_Click(object sender, EventArgs e)
        {
            lbOffers.Items.Clear();
            string address = tbName.Text;

            string[] offers = proxy.GetOffers(address);
            if (offers == null)
            {
                lbOffers.Items.Add("House was not found.");
                return;
            }

            if (offers.Length == 0)
            {
                lbOffers.Items.Add("There are no offers.");
                return;
            }

            foreach (string offer in offers)
            {
                lbOffers.Items.Add(offer);
            }
        }
    }
}
