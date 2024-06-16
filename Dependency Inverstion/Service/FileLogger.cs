using Dependency_Inverstion.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inverstion.Service
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            //Write to file
            Console.WriteLine(message);
        }
    }
    
}
