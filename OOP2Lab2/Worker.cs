using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Lab2
{
    public class Worker :Employee
    {
        public Worker(string name, string position, decimal salary, IShow show, ISearch search) : base( name, position, salary, show, search)
        {

        }
    }
}
