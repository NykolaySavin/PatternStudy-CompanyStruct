using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Lab2
{
    public class SearchByPosition : ISearch
    {
        public IEnumerable<Employee> GetEmployees(Employee employee)
        {
            List<Employee> employees = new List<Employee>();
            if (employee.Position == position)
                employees.Add(employee);

            employees.AddRange( GetEmployeesRecursive(employee));
            
                return employees;
        }
        private IEnumerable<Employee> GetEmployeesRecursive(Employee employee)
        {
            
            List<Employee> employees = new List<Employee>();
            if (employee != null)
            {
                
                employees.AddRange(from e in employee.GetIterator() where e.Position == position select e);
                foreach (var item in employee.GetIterator())
                {
                    employees.AddRange(GetEmployeesRecursive(item));
                }
            }

            return employees;
        }
        string position;
        public SearchByPosition(string position)
        {
            this.position = position;
        }
    }
}
