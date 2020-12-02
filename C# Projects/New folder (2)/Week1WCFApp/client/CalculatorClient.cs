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
    class CalculatorClient : ClientBase<ICalculator>
    {
        public CalculatorClient(Binding binding, EndpointAddress endpointAddress)
            : base(binding, endpointAddress) { }

        public ICalculator GetCalculatorService()
        {
            return base.Channel;
        }
    }
}
