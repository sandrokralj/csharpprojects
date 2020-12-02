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
using RentClient.ServiceReference1;

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
                tbName.Text = selected.ToString();
            }
        }

        private void btnGetAvailable_Click(object sender, EventArgs e)
        {
            foreach (House house in proxy.GetAvailableHouses())
            {
                lbAvailable.Items.Add(house.Address);
            }
        }

        private void btnNrOffers_Click(object sender, EventArgs e)
        {
            string address = tbName.Text;

            int askingPrice = proxy.GetAskingPrice(address);
            if (askingPrice == -1)
            {
                rtbMessages.Text = "The house " + address + " is not found.";
                return;
            }

            rtbMessages.Text = "The asking price of " + address 
                                    + " is " + askingPrice.ToString();
        }

        private void btnMakeOffer_Click(object sender, EventArgs e)
        {
            if (lbAvailable.SelectedIndex == -1)
            {
                MessageBox.Show("Select an address");
                return;
            }

            int offerPrice = 0;
            try
            {
                offerPrice = Convert.ToInt32(tbOffer.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter number.");
                return;
            }

            string address = lbAvailable.SelectedItem.ToString();

            int result = proxy.MakeOffer(address, offerPrice);

            if (result == -1)
            {
                rtbMessages.Text = "House was not found";
                return;
            }

            rtbMessages.Text = "Offer was made";

            if (result == 0)
            {
                lbAvailable.Items.RemoveAt(lbAvailable.SelectedIndex);
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Unsubscribe();
        }

        public void HouseNotAvailable(House house)
        {
            foreach (string address in lbAvailable.Items)
            {
                if (address == house.Address)
                {
                    lbAvailable.Items.Remove(address);
                    return;
                }
            }
        }
    }
}
