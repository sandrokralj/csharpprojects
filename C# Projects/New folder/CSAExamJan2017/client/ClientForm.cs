using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentClient.ServiceReference1;
using System.ServiceModel;

namespace RentClient
{
    public partial class ClientForm : Form, IService1Callback
    {

        Service1Client proxy;

        public ClientForm()
        {
            InitializeComponent();
            InstanceContext context = new InstanceContext(this);

            proxy = new Service1Client(context);
            proxy.Subscribe();
        }

        private void lbAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected = lbAvailable.SelectedItem;
            if (selected != null)
            {
                btnMakeOffer.Text = "sign in to " + selected;
            }

        }

        private void btnNrOffers_Click(object sender, EventArgs e)
        {
            string address = tbName.Text;
            int askingPrice = proxy.GetAskingPrice(address);
            if(askingPrice == -1)
            {
                rtbMessages.AppendText("\n House was not found.");
                return;
            }
            rtbMessages.AppendText("\n Asking price for house " + address + " is "+ askingPrice.ToString());
        }

        private void btnGetAvailable_Click(object sender, EventArgs e)
        {
            UpdateListOfAvailableHouses();
        }

        private void UpdateListOfAvailableHouses()
        {
            lbAvailable.Items.Clear();
            foreach (House house in proxy.GetAvailableHouses())
            {
                lbAvailable.Items.Add(house.Address);
            }
        }

        private void btnMakeOffer_Click(object sender, EventArgs e)
        {
            if(lbAvailable.SelectedIndex == -1)
            {
                return;
            }
            string address = lbAvailable.SelectedItem.ToString();
            int offerPrice = Convert.ToInt32(tbOffer.Text);
            bool result = proxy.MakeOffer(address, offerPrice);
            if (!result)
            {
                rtbMessages.Text = "House was not found.";
                return;
            }
            rtbMessages.Text = "The offer was made for " + address;
            UpdateListOfAvailableHouses();
        }

        public void HouseNotAvailable(House house)
        {
            foreach (string address in lbAvailable.Items)
            {
                if(address == house.Address)
                {
                    int index = lbAvailable.Items.IndexOf(address);
                    lbAvailable.Items.RemoveAt(index);
                    return;
                }
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Unubscribe();
        }
    }
}
