using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Lab2
{
    public class Chief : Employee
    {
        private List<Employee> components = new List<Employee>();
        public override IEnumerable<Employee> GetIterator() { return components; }
        public Chief(string name, string position, decimal salary, IShow show, ISearch search) : base(name,  position, salary, show, search)
        {

        }
        public override void Add(Employee component)
        {
            components.Add(component);
        }

        public override void Remove(Employee component)
        {
            components.Remove(component);
        }
    }
}
