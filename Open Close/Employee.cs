using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close
{
    /*
      1. Open for extension & Close for modification
      2. Software entities should be open for extension, but closed for modification.
      3. The "Open/Closed Principle" states that the design and writing of the code should be done in a way that new functionality should be added with minimum changes in the existing code.
     */
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
