using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS4EXAM
{
    public class LinkedListOfBigDonations
    {
        private Node first;
        private int itemCounter;

        public LinkedListOfBigDonations()
        {
            this.first = null;
            this.itemCounter = 0;
        }
        public void addDonationToLinkedList(String startupName, String donatorName, int amount)
        {
            Item i = new Item(startupName, donatorName, amount);
            Node temp = new Node(i);
            temp.setNext(first);
            first = temp;
            this.itemCounter++;
            if(this.itemCounter == 11)
            {//remove last node
                Node helpNode = first;
                while(helpNode.getNext().getNext() != null)
                {
                    helpNode = helpNode.getNext();
                }
                helpNode.setNext(null);
                this.itemCounter--;
            }
        }
        public List<String> getInfoOfAllItems()
        {
            List<String> temp = new List<string>();
            if (first == null)
            {
                temp.Add("There are no items in the linked list");
                return temp;
            }
            else
            {
                Node current = first;
                while (current != null)
                {
                    temp.Add(current.getItem().ToString());
                    current = current.getNext();
                }
                return temp;
            }
        }
    }
}
