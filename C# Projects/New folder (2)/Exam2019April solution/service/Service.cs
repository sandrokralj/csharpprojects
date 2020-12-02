using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService, IAdmin
    {
        List<User> users = new List<User>();

        public void BlockUser(string name)
        {
            User u = users.FirstOrDefault(x => x.Name == name);
            u.IsBlocked = true;
            u.CallBack.ReceiveMessage("You have been blocked by admin");
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public List<User> GetUsers()
        {
            IServiceCallBack current = OperationContext.Current.GetCallbackChannel<IServiceCallBack>();
            List<User> temp = new List<User>();
            foreach(User u in users)
            {
                if(!u.IsBlocked && u.CallBack != current)
                {
                    temp.Add(u);
                }
            }
            return temp;
        }

        public bool LogIn(string name)
        {
            IServiceCallBack current = OperationContext.Current.GetCallbackChannel<IServiceCallBack>();
            User u = users.FirstOrDefault(x => x.Name == name);
            if(u == null)
            { 
                u = new User(name,current);
                users.Add(u);
                return true;
            }
            return false;
        }

        public void LogOut()
        {
            IServiceCallBack current = OperationContext.Current.GetCallbackChannel<IServiceCallBack>();
            User u = users.FirstOrDefault(x => x.CallBack == current);
            if(u != null)
            {
                users.Remove(u);
            }
        }

        public bool SendPrivateMessage(string message, string receiverName)
        {
            IServiceCallBack current = OperationContext.Current.GetCallbackChannel<IServiceCallBack>();
            User receiver = null;
            User sender = null;

            foreach(User u in users)
            {
                if(u.CallBack == current)
                {
                    sender = u;
                }
                if(u.Name == receiverName)
                {
                    receiver = u;
                }
            }
            if(receiver.IsBlocked || sender.IsBlocked || receiver == null)
            {
                return false;
            }
            string back = $"{sender.Name} private: {message}.";
            receiver.CallBack.ReceiveMessage(back);
            return true;

        }

        public bool SendPublicMessage(string message)
        {
            IServiceCallBack current = OperationContext.Current.GetCallbackChannel<IServiceCallBack>();
            User sender = null;

            foreach (User u in users)
            {
                if (u.CallBack == current)
                {
                    sender = u;
                    if (sender.IsBlocked)
                    {
                        return false;
                    }
                }
            }

            if (sender == null)
            {
                return false;
            }

            foreach (User u in users)
            {
                if (u.CallBack != current && !u.IsBlocked)
                {
                    u.CallBack.ReceiveMessage($"{sender.Name}: {message}.");
                }
            }
            return true;
        }
    }
}
