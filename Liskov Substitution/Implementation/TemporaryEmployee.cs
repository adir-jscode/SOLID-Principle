using Liskov_Substitution.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Implementation
{
    internal class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(string id, string name) : base(id, name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }

        public override decimal GetMinimumSalary()
        {
            return 10000;
        }
    }
}
