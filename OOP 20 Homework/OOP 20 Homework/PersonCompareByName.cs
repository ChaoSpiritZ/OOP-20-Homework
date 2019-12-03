using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_20_Homework
{
    class PersonCompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int cmpVal = x.Name.CompareTo(y.Name);
            return cmpVal;
        }
    }
}
