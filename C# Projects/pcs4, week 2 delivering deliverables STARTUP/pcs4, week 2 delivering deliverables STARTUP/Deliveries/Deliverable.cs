using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliveries
{

    public class Deliverable
    {
        private int id;    //the unique id of a deliverable
        private int weight; //the weight (in grams) of this deliverable
        private Person buyer; //the person who bought this deliverable

        public Deliverable(int id, int weight, Person buyer)
        {
            this.id = id;
            this.weight = weight;
            this.buyer = buyer;
        }

        public int ID { get { return this.id; } }
        public int Weight { get { return this.weight; } }
        public Person Buyer { get { return this.buyer; } }


        public override string ToString()
        {
            return "Id: " + this.id + ", weight: " + this.weight + ", to be delivered at: " + this.buyer; //todo
        }

    }
}
