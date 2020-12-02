using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Uncooked : Doneness
    {
        public Uncooked(Doneness state) : this(state.CurrentTemp, state.Steak)
        {
        }
        public Uncooked(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 0;
            upperTemp = 53.99999999;
            canEat = false;
        }

        public override void AddTemp(double amount)
        {
            currentTemp += amount;
            DonenessCheck();
        }

        public override void RemoveTemp(double amount)
        {
            currentTemp -= amount;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemp > upperTemp && currentTemp < 60)
            {
                steak.State = new Rare(this);
                
            }
            else if(currentTemp >= 60 && currentTemp < 69)
            {
                steak.State = new MediumRare(this);
            }
            else if(currentTemp >= 69 && currentTemp < 77)
            {
                steak.State = new Medium(this);
            }
            else if(currentTemp >= 77)
            {
                steak.State = new WellDone(this);
            }
            else
            {
                steak.State = new Uncooked(this);
            }
        }
    }
}
