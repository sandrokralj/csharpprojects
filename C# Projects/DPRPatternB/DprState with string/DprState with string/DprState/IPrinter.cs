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
            return "Document is in Printer (First State).";
        }

        public override string ToString()
        {
            return "Send.";
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
            return "Document is ready to print (Second State).";
        }

        public override string ToString()
        {
            return "Ready.";
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
            return "Document is printing (Third State).";
        }

        public override string ToString()
        {
            return "Start.";
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
            return "Document Print succesfully (Last State).";
        }

        public override string ToString()
        {
            return "Printing.";
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
            return "Waiting on new document (Last State).";
        }

        public override string ToString()
        {
            return "Waiting...";
        }
    }


}
