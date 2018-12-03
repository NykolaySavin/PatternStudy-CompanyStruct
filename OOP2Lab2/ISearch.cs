using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Lab2
{
    public interface ISearch
    {
        IEnumerable<Employee> GetEmployees(Employee c);
    }
}
