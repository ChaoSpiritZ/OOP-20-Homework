using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_20_Homework
{
    class PersonCompareByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age == y.Age)
            {
                return 0;
            }
            if (x.Age > y.Age)
            {
                return 1;
            }
            return -1;
        }
    }
}
