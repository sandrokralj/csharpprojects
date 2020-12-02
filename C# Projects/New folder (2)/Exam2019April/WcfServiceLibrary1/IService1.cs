using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IService1Callback))]
    public interface IService1
    {
        [OperationContract]
        string GetStudentUsername(bool isBlocked);


        [OperationContract(IsOneWay = true)]
        void Login();

        [OperationContract(IsOneWay = true)]
        void Logout();
        // TODO: Add your service operations here
    }

    public interface IService1Callback
    {
        [OperationContract(IsOneWay = true)]
        void PrivateMessage(bool isBlocked);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary1.ContractType".
    [DataContract]
    public class Student
    {
        string username;
        bool blockedUser;

        public Student(string username, bool blockedUser)
        {
            Username = username;
            BlockedUser = blockedUser;
            UserCallback = new List<IService1Callback>();
        }

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        
        public bool BlockedUser
        {
            get { return blockedUser; }
            set { blockedUser = value; }
        }

        public List<IService1Callback> UserCallback;
    }
}
