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
using MessagingClient.ServiceReference1;


namespace MessagingClient
{
    public partial class Form1 : Form, IService1Callback
    {
        Service1Client proxy;

        public Form1()
        {
            InitializeComponent();
            InstanceContext context = new InstanceContext(this);
            proxy = new Service1Client(context);

        }

        public void PrivateMessage(bool isBlocked)
        {
            foreach (string message in lbMessages.Items)
            {
                if (isBlocked == false)
                {
                    lbMessages.Items.Add(message);
                    return;
                }
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string newUser = tbUserName.Text;
            bool blockedUser = false;
            string getStudentUsername = proxy.GetStudentUsername(blockedUser);
            if(newUser == getStudentUsername)
            {
                labelLoginStatus.Text = "Username already exists";
                return;
            }
            labelLoginStatus.Text = "The login of " + newUser + " was successful.";  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Logout();
        }
    }
}
