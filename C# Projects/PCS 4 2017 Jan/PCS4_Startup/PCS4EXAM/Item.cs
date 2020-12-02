using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS4EXAM
{
    class Item
    {

        private String startUpName;
        private String donatorName;
        private int amount;

        public Item(String startUpName, String donatorName, int amount)
        {
            this.startUpName = startUpName;
            this.donatorName = donatorName;
            this.amount = amount ;
        }

        public override string ToString()
        {
            return this.donatorName + " donated to " + this.startUpName + " " + this.amount + "$";
        }
        
    }
}
