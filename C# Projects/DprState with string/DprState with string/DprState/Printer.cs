using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DprState
{
    public class Printer
    {
        // fields
        private IPrinterState state;
        public bool printing;

        // Properties
        public IPrinterState State
        {
            get { return state; }
            set { state = value; }
        }

        // Constructor
        public Printer(IPrinterState newState)
        {
            this.state = newState;
        }

        // Methods
        public void NextState()
        {
            switch (state.ToString())
            {
                case "waiting":
                    state = new SendToPrinter();
                    return;

                case "send":
                    state = new Ready();
                    return;

                case "ready":
                    state = new StartPrinting();
                    return;

                case "start":
                    state = new Printing();
                    return;

                case "printing":
                    state = new Waiting();
                    return;
            }
        }

        public void Cancel()
        {
            MessageBox.Show("state" + State + "was cancel");
        }
    }
}
