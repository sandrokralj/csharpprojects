using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race_Track_Solution
{
    public class LinkedListOfWinners

    {
        private Node first;
        private Node last;
        //In this example we implement it as a queue, which acts according to "first in first out".
        //For ease of use we register two nodes: the first node and the last node.

        public LinkedListOfWinners()
        {
            this.first = null;
            this.last = null;
        }

        public void registeredWinner(Participant p)
        {
            if (this.first == null)
            {
                this.first = new Node(new Item(p.Name));
                this.last = this.first;
            }
            else
            {
                Node current = first;
                while (current != null)
                {
                    if (current.getItem().ParticipantName == p.Name)
                    {// found an item for the winner
                        current.getItem().incrementNumberOfWins();
                        return;
                    }
                    else
                    {
                        current = current.getNext();
                    }
                    //there is no item about this winner, so add a new node
                    Node temp = new Node(new Item(p.Name));
                    this.last.setNext(temp);
                    this.last = temp;
                }
            }
        }


        public List<String> getInfoOfAllItems()
            {
                List<String> temp = new List<string>();
                if(first == null)
                {
                    temp.Add("There are no items in the linked list!");
                    return temp;
                }
                else
                {
                    Node current = first;
                    while(current !=null)
                    {
                        temp.Add(current.getItem().ToString());
                        current = current.getNext();
                    }
                    return temp;
                }
            }

        
        

    }
}
