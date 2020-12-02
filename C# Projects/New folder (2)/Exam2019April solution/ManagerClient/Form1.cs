using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerClient
{
    public partial class Form1 : Form
    {
        srv.AdminClient proxy;
        public Form1()
        {
            InitializeComponent();
            proxy = new srv.AdminClient();
        }

        private void btGetUsers_Click(object sender, EventArgs e)
        {
            lbUsers.Items.Clear();
            srv.User[] users = proxy.GetAllUsers();
            foreach(srv.User u in users)
            {
                lbUsers.Items.Add(u);
            }
        }

        private void btBlockUser_Click(object sender, EventArgs e)
        {
            srv.User u = (srv.User)lbUsers.SelectedItem;
            if(u != null)
            {
                proxy.BlockUser(u.Name);
            }
            else
            {
                MessageBox.Show("Please, select a user first.");
            }
        }
    }
}
