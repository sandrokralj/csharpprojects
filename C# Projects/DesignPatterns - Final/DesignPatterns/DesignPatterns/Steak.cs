using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Steak
    {
        private Doneness _state;
        private string BeefCut;

        public Steak(string beefCut)
        {
            BeefCut = beefCut;
            _state = new Uncooked(0.0, this);
        }

        public double CurrentTemp
        {
            get { return _state.CurrentTemp;  } 
        }

        public Doneness State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void AddTemp(double amount)
        {
            _state.AddTemp(amount);
            //Console.WriteLine("Increased temperature by {0} degrees.", amount);
            //Console.WriteLine(" Current temp is {0}", CurrentTemp);
            //Console.WriteLine(" Status is {0}", State.GetType().Name);
            //Console.WriteLine("");
        }

        public void RemoveTemp(double amount)
        {
            _state.RemoveTemp(amount);
            //Console.WriteLine("Decreased temperature by {0} degrees.", amount);
            //Console.WriteLine(" Current temp is {0}", CurrentTemp);
            //Console.WriteLine(" Status is {0}", State.GetType().Name);
            //Console.WriteLine("");
        }
    }
}
