using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{

    /*
         Class & modules should focus on a single task at a time
     
     */
    internal interface IUser
    {
        bool Login(string username, string password);
        bool Registration(string username, string password);
        //bool SendEmail(string email);  Violation 
        // bool Log(string message); Violation of (SRP)
    }

    interface IEmail
    {
        bool SendEmail(string email);
    }

    interface ILogs
    {
       
    }
}
