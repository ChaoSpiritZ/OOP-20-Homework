using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_20_Homework
{
    class PersonCompareByHeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Height == y.Height)
            {
                return 0;
            }
            if (x.Height > y.Height)
            {
                return 1;
            }
            return -1;
        }
    }
}
