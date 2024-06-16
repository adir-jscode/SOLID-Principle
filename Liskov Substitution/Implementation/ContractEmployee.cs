using Liskov_Substitution.Abstraction;
using Liskov_Substitution.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Implementation
{
    internal class ContractEmployee : IEmployee
    {
        public string Id { get; set; }
        public string Name { get; set ; }

        public ContractEmployee(string id, string name)
        {
            Id = id;
            Name = name;
        }
        public decimal GetMinimumSalary()
        {
            return 5000;
        }

        public override string ToString()
        {
            return string.Format("Id {0} Name : {1}", this.Id, this.Name);
        }
    }
}
