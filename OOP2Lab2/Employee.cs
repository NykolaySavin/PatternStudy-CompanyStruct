using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Lab2
{
    public abstract class Employee
    {
        public IShow Showable { private get; set; }
        public ISearch Searchable { private get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public virtual void Add(Employee e) { }
        public virtual void Remove(Employee e) { }
        public virtual IEnumerable<Employee> GetIterator() { return new List<Employee>(); }
        public string Show() { return Showable.Show(this); }
        public IEnumerable<Employee> Search() { return Searchable.GetEmployees(this); }
        public Employee(string name, string position, decimal salary, IShow show, ISearch search)
        {
            Salary = salary;
            Name = name;
            Showable = show;
            Searchable = search;
            Position = position;
        }
    }
}
