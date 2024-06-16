using Dependency_Inverstion.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inverstion
{
    public class DataAccessLayer
    {
        private ILogger _logger;

        public DataAccessLayer()
        {
        }

        public DataAccessLayer(ILogger logger)
        {
            _logger = logger;
        }

        public void Add(string name)
        {
            _logger.Log("Customer Added = " + name);
        }
    }
}
