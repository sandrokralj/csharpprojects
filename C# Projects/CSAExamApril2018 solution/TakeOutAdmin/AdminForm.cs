using System;
using System.ServiceModel;
using System.Windows.Forms;
using TakeOutAdmin.SrvAdmin;

namespace TakeOutAdmin
{
    public partial class AdminForm : Form, IFoodAdminCallback
    {
        FoodAdminClient proxy;
        InstanceContext context;
        
        public AdminForm()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            proxy = new FoodAdminClient(context);
            proxy.Connect();
            btGetOrders_Click(null,null);
        }

        private void btGetOrders_Click(object sender, EventArgs e)
        {
            lbOrders.Items.Clear();
            foreach (var order in proxy.GetOrders())
            {
                lbOrders.Items.Add(order);
            }
        }

        public void NewOrder(int orderNr)
        {
            lbOrders.Items.Add(orderNr);
        }

        public void OrderDelivered(int orderNr)
        {
            tbOrderReady.Text = orderNr.ToString();
            lbOrders.Items.Remove(orderNr);
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Disconnect();
        }

        private void btDeliver_Click(object sender, EventArgs e)
        {
            proxy.DeliverOrder(int.Parse(lbOrders.SelectedItem.ToString()));
        }
    }
}
