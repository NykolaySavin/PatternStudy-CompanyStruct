using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Lab2
{
    public class SearchByChief : ISearch
    {
        public IEnumerable<Employee> GetEmployees(Employee e)
        {
            List<Employee> employees = new List<Employee>();
            employees.AddRange(e.GetIterator());
            foreach (var item in e.GetIterator())
            {
                employees.AddRange(GetEmployees(item));
            }
            return employees;
        }
        
    }
}
