using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        List<IService1Callback> messages;

        List<Student> students;

        public Service1()
        {
            students = new List<Student>();
            students.Add(new Student("John", false));
            students.Add(new Student("Jack", false));
            students.Add(new Student("Josh", false));
            students.Add(new Student("Jim", false));
            messages = new List<IService1Callback>();
        }

        public string GetStudentUsername(bool isBlocked)
        {
            List<Student> tempStudent = new List<Student>();
            foreach (Student student in students)
            {
                if(student.BlockedUser == false)
                {
                    return student.Username;
                }
            }

            return null;
        }

        public void Login()
        {
            IService1Callback user = OperationContext.Current.GetCallbackChannel<IService1Callback>();
            messages.Add(user);
        }

        public void Logout()
        {
            IService1Callback user = OperationContext.Current.GetCallbackChannel<IService1Callback>();
            messages.Remove(user);
        }
    }
}
