using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingFedApp
{
    public class LinkedListOfTestRides

    {
        private Node first;
        private int itemCounter;

        public LinkedListOfTestRides()
        {
            this.first = null;
            this.itemCounter = 0;
        }
        public void addRacerToList(Racer r)
        {
            if (this.itemCounter == 0)
            {
                this.first = new Node(r);
            }
            else
            {
                Node temp = new Node(r);
                temp.setNext(first);
                first = temp;
            }
            this.itemCounter++;
        }

        public int nrOfTestRidesWithPlayersOfTeam()
        {
            return this.itemCounter;
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
