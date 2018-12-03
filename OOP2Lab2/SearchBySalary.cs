using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Lab2
{
    public class SearchBySalary : ISearch
    {
        public IEnumerable<Employee> GetEmployees(Employee employee)
        {
            List<Employee> employees = new List<Employee>();
            if (employee.Salary>salary)
                employees.Add(employee);

            employees.AddRange(GetEmployeesRecursive(employee));
           

            return employees; 
        }
        public IEnumerable<Employee> GetEmployeesRecursive(Employee employee)
        {
            
            List<Employee> employees = new List<Employee>();
            if (employee != null)
            {
                employees.AddRange(from e in employee.GetIterator() where e.Salary > salary select e);
                foreach (var item in employee.GetIterator())
                {
                    employees.AddRange(GetEmployeesRecursive(item));
                }
            }

            return employees;
        }
        private decimal salary;
        public SearchBySalary(decimal salary)
        {
            this.salary = salary;
        }
    }
}
