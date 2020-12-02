﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        private Item theItem; //the item it refers to
        private Node next;    // the next node it refers to; null if there does not exist a next node

        public Node(Item aItem)
        {
            this.theItem = aItem;
            this.next = null;
        }
        
        public Item getItem() { return this.theItem; }

        public Node getNext() { return this.next; }
        public void setNext(Node n) { this.next = n; }

        public Node Next {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
