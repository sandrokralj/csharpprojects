using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace service
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }

        public bool IsBlocked { get; set; }

        public IServiceCallBack CallBack { get; set; }

        public User(string name, IServiceCallBack callBack)
        {
            this.Name = name;
            this.IsBlocked = false;
            this.CallBack = callBack;
        }
    }
}
