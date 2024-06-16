using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Interface
{
    internal interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
