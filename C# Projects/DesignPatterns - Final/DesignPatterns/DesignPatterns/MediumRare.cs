using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class MediumRare : Doneness
    {
        public MediumRare(Doneness state) : this(state.CurrentTemp, state.Steak)
        {
        }

        public MediumRare(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            canEat = true;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 60;
            upperTemp = 68.99999999;
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
            if (currentTemp < lowerTemp && currentTemp >= 54)
            {
                steak.State = new Rare(this);
            }
            else if (currentTemp < 54)
            {
                steak.State = new Uncooked(this);
            }
            else if (currentTemp > upperTemp && currentTemp < 77)
            {
                steak.State = new Medium(this);
            }
            else if(currentTemp >= 77)
            {
                steak.State = new WellDone(this);
            }
            else
            {
                steak.State = new MediumRare(this);
            }
        }
    }
}
