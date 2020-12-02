using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class ToDoList
    {
        private String name;
        private Node first;
        private Node last;
        //In this example we implement it as a queue, which acts according to "first in first out".
        //For ease of use we register two nodes: the first node and the last node.

        public ToDoList(String name)
        {
            this.name = name;
            this.first = null;
            this.last = null;
        }

        public String GetName() { return this.name; }

        public String GetInfoFirstItem()
        {
            if (first != null)
            {
                return first.getItem().ToString();
            }
            else
            {
                return "there is no first item in the list"; ;
            }
        }

        public String GetInfoSecondItem()
        {
            if (first != null)
            {
                Node second = first.getNext();
                if (second != null)
                {
                    return second.getItem().ToString();
                }
                else
                {
                    return "there is no second item in the list"; ;
                }
            }
            else
            {
                return "there is no second item in the list"; ;
            }
        }

        public String GetInfoThirdItem()
        {
            if (first != null)
            {
                Node second = first.getNext();
                if (second != null)
                {
                    Node third = second.getNext();
                    if (third != null)
                    {
                        return third.getItem().ToString();
                    }
                    else
                    {
                        return "there is no third item in the list"; ;
                    }
                }
                else
                {
                    return "there is no third item in the list"; ;
                }
            }
            else
            {
                return "there is no third item in the list"; ;
            }
        }

        /// <summary>
        /// Adds item i to the end of the linked list
        /// </summary>
        /// <param name="i"></param>
        public void AddItem(Item i)
        {

            if (this.first != null)
            {// there are already at least 1 items in the linked list
                Node temp;
                temp = new Node(i);
                last.setNext(temp);
                last = temp;

            }
            else
            {//there is no item in the linked list
                Node temp;
                temp = new Node(i);
                first = temp;
                last = temp;
                //first = new Node(i);
                //last = first;
            }
            //todo
        }

        /// <summary>
        /// If the list is not empty,
        /// it removes the first item from the linked list and returns this item,
        /// else it returns null and the list is not changed
        /// </summary>
        /// <returns></returns>
        public Item removeItem()
        {
            if (first == null)
            {//there are at least 3 items in the linkedlist
                return null;
            }
            //there is 1 or more items in the linked lis
            Item itemToReturn = first.getItem();

            if (first == last)
            {//there is exactly one item in the list
                first = null;
                last = null;
                return itemToReturn;

            }
            // there are at least 2 items in the linked list

            first = null;
            last = null;
            return itemToReturn;
        }

    }
}
