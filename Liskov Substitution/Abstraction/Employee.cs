using Liskov_Substitution.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Abstraction
{
    public abstract class Employee : IEmployee , IEmployeeBonus
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Employee(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);
        public abstract decimal GetMinimumSalary();

        public override string ToString()
        {
            return string.Format("Id {0} Name : {1}", this.Id, this.Name);
        }

    }
}
