using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Lab2
{
    class ShowBySubordinates : IShow
    {
        public string Show(Employee e)
        {
            string s = e.Position +" "+e.Name+ Environment.NewLine;
            return s + GetStringOfSubordinates(e);
        }
        private string GetStringOfSubordinates(Employee e)
        {
            string s = "";
            
            foreach (var item in e.GetIterator())
            {
                s += item.Position+" "+item.Name + Environment.NewLine;
                s += GetStringOfSubordinates(item);
            }
            return s;
        }
    }
}
