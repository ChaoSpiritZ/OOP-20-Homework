using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_20_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[5];
            persons[0] = new Person(1, 12, 52.4f, "Michael");
            persons[1] = new Person(2, 30, 87.2f, "Michael Jordan");
            persons[2] = new Person(3, 47, 79.0f, "George");
            persons[3] = new Person(5, 32, 80.1f, "Bill");
            persons[4] = new Person(4, 2, 10f, "Bebe");

            PrintPersonArray(persons);

            //default
            Console.WriteLine();
            Array.Sort(persons);
            PrintPersonArray(persons);

            //by name
            Console.WriteLine();
            Array.Sort(persons, Person.NameComparer);
            PrintPersonArray(persons);

            //by id
            Console.WriteLine();
            Array.Sort(persons, Person.IDComparer);
            PrintPersonArray(persons);

            //by age
            Console.WriteLine();
            Array.Sort(persons, Person.AgeComparer);
            PrintPersonArray(persons);

            //by height
            Console.WriteLine();
            Array.Sort(persons, Person.HeightComparer);
            PrintPersonArray(persons);

        }

        static void PrintPersonArray(Person[] persons)
        {
            foreach (Person item in persons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
