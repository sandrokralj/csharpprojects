using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppAboutBinaryTree
{
    public partial class Form1 : Form
    {

        private ToDoList myList;
            public Form1()
        {
            InitializeComponent();
            this.myList = new ToDoList("jobs for the weekend");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.myList.ShowInListbox(this.listBox1);
            this.listBox1.Items.Add("*****************");
            //a trick . . .x
            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item i = new Item(this.textBox1.Text,
                        Convert.ToInt32(this.textBox2.Text),
                        Convert.ToInt32(this.textBox3.Text));
            this.myList.AddItem( i );
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

      }
    }
}
