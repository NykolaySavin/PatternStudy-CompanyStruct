using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP2Lab2;

namespace CompanyTest
{
    [TestClass]
    public class CompanyTest
    {
        public CompanyTest()
        {
        }
        [TestMethod]
        public void TestAddEmployee()
        {
            //arrange
        
            Employee e = new Chief("Ivan", "Director", 10000,null,null);
            Employee m1 = new Chief("Ivan", "Manager", 10000, null, null);
            Employee e1 = new Worker("Serega", "ScalaDno", 2000,null,null);
            Employee e2 = new Worker("Nagulak", "Novuy", 1000,null,null);

            List<Employee> listofchief = new List<Employee>() { e1, e2 };
            List<Employee> listnull = new List<Employee>();

            //act
            e.Add(e1);
            e.Add(e2);
            e1.Add(m1);
            //assert
            CollectionAssert.AreEquivalent(e1.GetIterator().ToList(), listnull);
            CollectionAssert.AreEquivalent(e.GetIterator().ToList(), listofchief);
     
        }
        [TestMethod]
        public void TestDeleteEmployee()
        {
            //arrange
            Employee e = new Chief("Ivan", "Director", 10000, null, null);

            Employee e1 = new Worker("Serega", "ScalaDno", 2000, null, null);
            Employee e2 = new Worker("Nagulak", "Novuy", 1000, null, null);
   
            List<Employee> list = new List<Employee>() { e2 };
            //act
            e.Add(e1);
            e.Add(e2);
            e.Remove(e1);
            //assert
         
            CollectionAssert.AreEquivalent(e2.GetIterator().ToList(), new List<Employee>());
            CollectionAssert.AreEquivalent(e.GetIterator().ToList(), list);
       
        }
        [TestMethod]
        public void TestSearch()
        {
            //arrange
           
            Employee e = new Chief("Ivan", "Director", 10000,null,null);
            Employee e1 = new Manager("Serega", "ScalaDno", 2000, null, null);
            Employee e2 = new Manager("Nagulak", "Novuy", 1000, null, null);
            Employee e3 = new Worker("Nagulak2", "Novuy", 1000, null, null);
            Employee e4 = new Worker("Nagulak2", "Novuy", 1000, null, null);
            List<Employee> searchbychief = new List<Employee>() {e1,e2, e3, e4 };
            List<Employee> searchbyposition = new List<Employee>() {e2, e3, e4 };
            List<Employee> searchbysalary = new List<Employee>() { e};
            e.Add(e1);
            e.Add(e2);
            e1.Add(e3);
            e1.Add(e4);

            //assert && act
            e.Searchable = new SearchByChief();
            CollectionAssert.AreEqual(e.Search().ToList(), searchbychief);
            e.Searchable = new SearchByPosition("Novuy");
            CollectionAssert.AreEqual(e.Search().ToList(), searchbyposition);
            e.Searchable = new SearchBySalary(3000);
            CollectionAssert.AreEqual(e.Search().ToList(), searchbysalary);
        }
    }
}
