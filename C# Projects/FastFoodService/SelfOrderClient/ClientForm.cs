using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using System.Runtime.Serialization;
using SelfOrderClient.ServiceReference1;

namespace SelfOrderClient
{
    public partial class ClientForm : Form, IFoodServiceCallback
    {
       
        FoodServiceClient proxy;
        List<Product> products;
        InstanceContext context;
        int orderNumber = 0;
        public ClientForm()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            proxy = new FoodServiceClient(context);

        }

        public void OrderStatus(bool status, string message)
        {
            tbOrderStatus.Text = message;
            if (status)
            {
                tbOrderNo.Text = "";
                tbTotalPrice.Text = "";
                lbProducts.Items.Clear();
                lbPrice.Items.Clear();
            }
        }

        private void btGetOrderNo_Click(object sender, EventArgs e)
        {
            orderNumber = proxy.GetOrderNumber();
            tbOrderNo.Text = orderNumber.ToString();
        }

        private void btGetProducts_Click(object sender, EventArgs e)
        {
            products = proxy.GetProductList().ToList();
            lbProducts.Items.Clear();
            lbPrice.Items.Clear();

            foreach (var p in products)
            {
                lbProducts.Items.Add(p.Name);
                lbPrice.Items.Add(p.Price);
            }
        }

        private void btOrder_Click(object sender, EventArgs e)
        {

            string[] items = new string[lbProducts.SelectedItems.Count];
            int index = 0;
            foreach (var item in lbProducts.SelectedItems)
            {
                items[index++] = item.ToString();
            }
            proxy.CreateOrder(items, orderNumber);
        }

        private void lbProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            double sum = 0;

            foreach (string item in lbProducts.SelectedItems)
            {
                sum += products.Single(x => x.Name == item).Price;
            }
            tbTotalPrice.Text = sum.ToString();
        }
    }
}
