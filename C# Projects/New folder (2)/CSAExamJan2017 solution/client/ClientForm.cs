using RentClient.srv;
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

namespace RentClient
{
    public partial class ClientForm : Form, IServiceCallback
    {
        srv.ServiceClient proxy;
        InstanceContext context;
        public ClientForm()
        {
            InitializeComponent();
            rtbMessages.Text = "";
            context = new InstanceContext(this);
            proxy = new srv.ServiceClient(context);
            proxy.Connect();
        }

        private void lbAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            House selected = (House)lbAvailable.SelectedItem;
            if (selected != null)
            {
                btnMakeOffer.Text = "sign in to " + selected.Address;
            }
        }

        private void btnGetAvailable_Click(object sender, EventArgs e)
        {
            lbAvailable.Items.Clear();

            // "House" objects are added in the list box. To display a House, set "Display member" attribute in 
            // the properties of list box lbAvailable to a property from a House, which should represent an object.
            lbAvailable.Items.AddRange(proxy.GetAvailableHouses());
        }

        private void btnMakeOffer_Click(object sender, EventArgs e)
        {
            switch (proxy.MakeAnOffer(((House)lbAvailable.SelectedItem).Address, int.Parse(tbOffer.Text)))
            {
                case OfferStatus.Succeeded:
                    rtbMessages.Text += $"- Offer of €{tbOffer.Text} was successfully for the house at {((House)lbAvailable.SelectedItem).Address}\n\n";
                    break;
                case OfferStatus.SucceededAndUnavailable:
                    rtbMessages.Text += $"- Offer of €{tbOffer.Text} was successfully for the house at {((House)lbAvailable.SelectedItem).Address}\n\n";
                    lbAvailable.Items.Remove(lbAvailable.SelectedItem);
                    break;
                case OfferStatus.Unavailable:
                    rtbMessages.Text += $"Offer failed. The house at {((House)lbAvailable.SelectedItem).Address} is not available any more.\n";
                    lbAvailable.Items.Remove(lbAvailable.SelectedItem);
                    break;
            }
        }

        public void HouseIsNotAvailable(string address)
        {
            for (int i = 0; i < lbAvailable.Items.Count; i++)
            {
                if (((House)lbAvailable.Items[i]).Address == address)
                {
                    lbAvailable.Items.Remove(lbAvailable.Items[i]);
                }
            }
        }

        private void btnNrOffers_Click(object sender, EventArgs e)
        {
            int askingPrice = proxy.GetAskingPrice(tbName.Text);
            if (askingPrice >= 0)
            {
                rtbMessages.Text += $"Asking price for {tbName.Text} is {askingPrice}.\n";
            }
            else
            {
                rtbMessages.Text += $"House at {tbName.Text} is not found.\n";
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Disconnect();
        }
    }
}
