//main function
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liskov_Substitution.Interface;
using Liskov_Substitution.Implementation;
using Liskov_Substitution.Abstraction;

namespace Liskov_Substitution
{
    /*
    1.Liskov Substitution Principle states that objects of a superclass shall be replaceable with objects of its subclasses without breaking the application.
    2. The Liskov Substitution Principle is closely related to the Open/Closed Principle.
    3. a subclass can stand in for its superclass without causing problems in the program
    4. It promotes the use of polymorphism in the code.
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new ParmanentEmployee("1", "John"));
            employees.Add(new TemporaryEmployee("2", "Jason"));
            //employees.Add(new ContractEmployee("3", "Mike"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} Min Salary: {2}", employee.ToString(), employee.CalculateBonus(10000), employee.GetMinimumSalary()));
            }

            Console.WriteLine();

            List<IEmployee> employees1 = new List<IEmployee>();
            employees1.Add(new ParmanentEmployee("1", "John"));
            employees1.Add(new TemporaryEmployee("2", "Jason"));
            employees1.Add(new ContractEmployee("3", "Mike"));
            foreach (var employee in employees1)
            {
                Console.WriteLine(string.Format("Employee {0} Min Salary: {1}", employee.ToString(), employee.GetMinimumSalary()));
            }

        }
    }
}