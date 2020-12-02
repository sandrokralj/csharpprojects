using System;
using System.ServiceModel;
using System.Windows.Forms;
using TakeOutAdmin.ServiceReference1;

namespace TakeOutAdmin
{
    public partial class AdminForm : Form
    {
        Service2Client proxy;

        public AdminForm()
        {
            InitializeComponent();

            proxy = new Service2Client();
        }

        private void btGetOrders_Click(object sender, EventArgs e)
        {
            lbOrders.Items.Clear();
            foreach (Order order in proxy.GetOrderNumbers())
            {
                lbOrders.Items.Add(order.orderNumber);
            }
        }

        private void btDeliver_Click(object sender, EventArgs e)
        {
            if (lbOrders.SelectedIndex < 0)
            {
                return;
            }

            int orderNumber = (int)lbOrders.SelectedItem;
            proxy.DeliverOrder(orderNumber);
        }
    }
}
