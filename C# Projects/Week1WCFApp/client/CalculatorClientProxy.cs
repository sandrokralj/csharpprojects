using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorContract;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace client
{
    class CalculatorClientProxy : ClientBase<ICalculator>
    {
        public CalculatorClientProxy(Binding binding, EndpointAddress endpointAddress)
            : base(binding, endpointAddress)
        { }

        //Return reference to service 

        public ICalculator GetCalculatorService()
        {
            return base.Channel;
        }
    }
}
