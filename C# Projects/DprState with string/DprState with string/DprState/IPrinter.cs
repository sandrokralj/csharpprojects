using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace DprState
{
    public interface IPrinterState
    {
        void Cancel(Printer printer);
        string Handle(Printer printer);        
    }

    public class SendToPrinter : IPrinterState
    {
        public void Cancel(Printer printer)
        {
            printer.Cancel();
        }

        public string Handle(Printer printer)
        {
            printer.NextState();
            Thread.Sleep(2000);
            return "Document is in Printer  /t first State";
        }

        public override string ToString()
        {
            return "send";
        }
    }

    public class Ready : IPrinterState
    {
        public void Cancel(Printer printer)
        {
            printer.Cancel();
        }


        public string Handle(Printer printer)
        {
            printer.State = new StartPrinting();
            Thread.Sleep(2000);
            return "Document is ready to print /t second State.";
        }

        public override string ToString()
        {
            return "ready";
        }
    }

    public class StartPrinting : IPrinterState
    {
        public void Cancel(Printer printer)
        {
            printer.Cancel();
        }


        public string Handle(Printer printer)
        {
            printer.NextState();
            Thread.Sleep(2000);
            return "document is printing /t third State.";
        }

        public override string ToString()
        {
            return "start";
        }
    }

    public class Printing : IPrinterState
    {
        public void Cancel(Printer printer)
        {
            printer.Cancel();
        }

        public string Handle(Printer printer)
        {
            Thread.Sleep(2000);
            printer.NextState();
            printer.printing = false;
            return "document Print succesfully /t last State.";
        }

        public override string ToString()
        {
            return "printing";
        }
    }
    public class Waiting : IPrinterState
    {
        public void Cancel(Printer printer)
        {
            printer.Cancel();
        }

        public string Handle(Printer printer)
        {
            printer.NextState();    
            return "Waiting on new document /t last State.";
        }

        public override string ToString()
        {
            return "waiting";
        }
    }


}
