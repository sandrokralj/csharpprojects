using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race_Track_Solution
{
    public class Item
    {
        private String participantName;    // a description for this item
        private int numberOfWins;          // the priority for this item: higher number means a higher priority


        public Item(String participantName)
        {
            this.participantName = participantName;
            this.numberOfWins = 1;
        }

        public String ParticipantName  { get { return this.participantName; }  }
        public void incrementNumberOfWins()   { this.numberOfWins++; }
        

        public override string ToString()
        {
            return this.participantName + "; won " + this.numberOfWins +
                " times.";
        }
    }
}
