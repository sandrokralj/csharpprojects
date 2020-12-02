using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppAboutBinaryTree
{
    public class ToDoList
    {
        private String name;
        private Node firstNode, lastNode;

        public ToDoList(String name)
        {
            this.name = name;
            this.firstNode = null;
            this.lastNode = null;
        }

        public String GetName() { return this.name; }

        public void AddItem(Item i)
        {//adds item i to the collection

        }

        public void ShowInListbox(ListBox lb)
        {//shows in the listbox lb information of all items in the collection

        }

    }
}

