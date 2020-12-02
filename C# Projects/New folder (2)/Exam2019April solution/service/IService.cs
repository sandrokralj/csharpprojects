using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IServiceCallBack))]
    public interface IService
    {
        [OperationContract]
        bool LogIn(string name);

        [OperationContract]
        List<User> GetUsers();

        [OperationContract]
        bool SendPrivateMessage(string message, string receiverName);

        [OperationContract]
        bool SendPublicMessage(string message);

        [OperationContract(IsOneWay = true)]
        void LogOut();
    }

    public interface IServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void ReceiveMessage(string message);
    }

    [ServiceContract]
    public interface IAdmin
    {
        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract(IsOneWay = true)]
        void BlockUser(string name);

    }
}
