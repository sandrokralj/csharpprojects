using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class WellDone : Doneness
    {
        public WellDone(Doneness state) : this(state.CurrentTemp, state.Steak)
        {
        }

        public WellDone(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            canEat = true;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 77;
            upperTemp = 110;
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
            if (currentTemp < 54)
            {
                steak.State = new Uncooked(this);
            }
            else if (currentTemp < lowerTemp && currentTemp >=69)
            {
                steak.State = new Medium(this);
            }
            else if(currentTemp < 69 && currentTemp >= 60)
            {
                steak.State = new MediumRare(this);
            }
            else if(currentTemp < 60 && currentTemp >= 54)
            {
                steak.State = new Rare(this);
            }
            else
            {
                steak.State = new WellDone(this);
            }
            
        }
    }
}
