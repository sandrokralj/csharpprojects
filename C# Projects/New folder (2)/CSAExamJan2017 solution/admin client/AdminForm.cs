using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_client
{
    public partial class AdminForm : Form
    {
        srv.AdminClient proxy = new srv.AdminClient();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnGetOffers_Click(object sender, EventArgs e)
        {
            lbOffers.Items.Clear();
            lbOffers.Items.Add($"Offers for {tbName.Text} are:");
            lbOffers.Items.Add($"--------");
            foreach (var item in proxy.GetOffers(tbName.Text))
            {
                lbOffers.Items.Add(item.ToString());
            }
        }
    }
}
