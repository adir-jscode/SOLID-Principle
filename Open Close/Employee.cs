using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Employee() { }

        public Employee(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalulateBonus(decimal amount);
        

        public override string ToString()
        {
            return string.Format("Id {0} Name : {1}", this.Id, this.Name);
        }
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee() { }

        public PermanentEmployee(string id, string name) : base(id, name) { }

        public override decimal CalulateBonus(decimal amount)
        {
            return amount * .1M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee() { }

        public TemporaryEmployee(string id, string name) : base(id, name) { }

        public override decimal CalulateBonus(decimal amount)
        {
            return amount * .05M;
        }
    }
}
