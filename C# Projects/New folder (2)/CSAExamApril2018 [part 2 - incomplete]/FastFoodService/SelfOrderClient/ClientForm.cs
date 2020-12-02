using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using SelfOrderClient.ServiceReference1;

namespace SelfOrderClient
{
    public partial class ClientForm : Form, IService1Callback
    {
        Service1Client proxy;
        int orderNumber;

        public ClientForm()
        {
            InitializeComponent();

            InstanceContext context = new InstanceContext(this);
            proxy = new Service1Client(context);
        }

        public void OrderStatus(string message)
        {
            tbOrderStatus.Text = message;
        }

        private void btGetOrderNo_Click(object sender, EventArgs e)
        {
            orderNumber = proxy.GetOrderNumber();
            tbOrderNo.Text = orderNumber.ToString();
        }

        private void btGetProducts_Click(object sender, EventArgs e)
        {
            lbProducts.Items.Clear();
            lbPrice.Items.Clear();

            foreach (Product product in proxy.GetProducts())
            {
                lbProducts.Items.Add(product.Name);
                lbPrice.Items.Add(product.Price);
            }
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            List<String> selectedProducts = new List<String>();

            foreach (String product in lbProducts.SelectedItems)
            {
                selectedProducts.Add(product);
            }

            string orderStatus = proxy.MakeOrder(
                orderNumber, 
                selectedProducts.ToArray()
            );

            tbOrderStatus.Text = orderStatus;
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
