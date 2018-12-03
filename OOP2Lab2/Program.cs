using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            IShow show = new ShowByPosition();
            ISearch search = new SearchByChief();
            Employee chief = new Chief("John", "Chief", 1000,show,search);
            Employee m1 = new Manager("John1", "Manager", 500,show, search);
            chief.Add(m1);
            Employee m2 = new Manager("T1", "Manager", 200,show, search);
            chief.Add(m2);
            Employee w1 = new Worker("T2", "Rab", 200,show, search);
            m1.Add(w1);
            Employee w2 = new Worker("John2", "Rab", 500,show, search);
            m1.Add(w2);
            Employee w3 = new Worker("K1", "Rab", 200,show, search);
            Employee w4 = new Worker("K2", "Rab", 200,show, search);
            m2.Add(w3);
            m2.Add(w4);
            var e = chief.Search();
            ISearch searchbyposition = new SearchByPosition("Rab");
            ISearch searchbysalary = new SearchBySalary(300);
            chief.Searchable = searchbyposition;
            e = chief.Search();
            chief.Searchable = searchbysalary;
            e = chief.Search();
            Console.WriteLine(chief.Show());
            Console.WriteLine(m1.Show());
            chief.Showable = new ShowBySubordinates();
            Console.WriteLine(chief.Show());
            Console.ReadKey();
        }
    }
}
