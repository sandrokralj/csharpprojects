using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using SelfOrderClient.ServiceReference1;

namespace SelfOrderClient
{
    public partial class ClientForm : Form
    {
        Service1Client proxy;
        int orderNumber;
        List<Product> products;

        public ClientForm()
        {
            InitializeComponent();
            proxy = new Service1Client();
            products = new List<Product>();
        }

        private void btGetOrderNo_Click(object sender, EventArgs e)
        {
            orderNumber = proxy.GetOrderNumber();
            tbOrderNo.Text = orderNumber.ToString();
        }

        private void btGetProducts_Click(object sender, EventArgs e)
        {
            foreach (Product product  in proxy.GetProducts())
            {
                lbProducts.Items.Add(product.Name);
                lbPrice.Items.Add(product.Price);
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
            //List<String> selectedProduct = new List<String>();
            //foreach (String product in lbProducts.SelectedItems)
            //{
            //    selectedProduct.Add(product);

            //}

            string orderStatus = proxy.MakeOrder(orderNumber, items);

            tbOrderStatus.Text = orderStatus;
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
    }
}
