using MessagingClient.srv;
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

namespace MessagingClient
{
    public partial class Form1 : Form, srv.IServiceCallback
    {
        InstanceContext context;
        srv.ServiceClient proxy;
        string name;
        public Form1()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            proxy = new srv.ServiceClient(context);
        }

        public void ReceiveMessage(string message)
        {
            lbMessages.Items.Add(message);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string name = tbUserName.Text;
            bool success = proxy.LogIn(name);
            if(name != "")
            {
                if (success)
                {
                    btLogin.Enabled = false;
                    labelLoginStatus.Text = "Success";
                    tbUserName.Enabled = false;
                    this.name = name;
                }
                else
                {
                    labelLoginStatus.Text = "Log in failed";
                }
            }
            else
            {
                MessageBox.Show("Please, type in a valid name.");
            }
           
        }

        private void btGetListOfUsers_Click(object sender, EventArgs e)
        {
            lbUsers.Items.Clear();
            User[] users = proxy.GetUsers();
            foreach(User u in users)
            {
                lbUsers.Items.Add(u);
            }
        }

        private void btSendPrivate_Click(object sender, EventArgs e)
        {
            User u = (User)lbUsers.SelectedItem;
            string message = tbPrivateMessage.Text;
            if(u != null && message != "")
            {
                bool result = proxy.SendPrivateMessage(message, u.Name);
                if (result)
                {
                    lbMessages.Items.Add($"{this.name} private: {message}.");
                }
                else
                {
                    lbMessages.Items.Add("Operation wasn't successful.");
                }
            }
            else
            {
                if(u == null)
                {
                    MessageBox.Show("Please, select a user first.");
                }
                else
                {
                    MessageBox.Show("Please, type in a valid message.");
                }
            }
        
        }

        private void btPostPublic_Click(object sender, EventArgs e)
        {
            string message = tbPublicMessage.Text;
            if(message != "")
            {
                bool result = proxy.SendPublicMessage(message);
                if (result)
                {
                    lbMessages.Items.Add($"{this.name}: {message}.");
                }
                else
                {
                    lbMessages.Items.Add("Operation wasn't successful.");
                }
            }
            else
            {
                MessageBox.Show("Please, type in a valid message.");
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.LogOut();
        }
    }
}
