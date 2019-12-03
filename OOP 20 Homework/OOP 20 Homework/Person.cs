using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_20_Homework
{
    class Person : IComparable<Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }
        private static readonly IComparer<Person> idComparer;
        private static readonly IComparer<Person> ageComparer;
        private static readonly IComparer<Person> heightComparer;
        private static readonly IComparer<Person> nameComparer;
        public static IComparer<Person> IDComparer
        {
            get
            {
                return idComparer;
            }
        }
        public static IComparer<Person> AgeComparer
        {
            get
            {
                return ageComparer;
            }
        }
        public static IComparer<Person> HeightComparer
        {
            get
            {
                return heightComparer;
            }
        }
        public static IComparer<Person> NameComparer
        {
            get
            {
                return nameComparer;
            }
        }
        private static IComparer<Person> DefaultComparer;

        static Person()
        {
            idComparer = new PersonCompareById();
            ageComparer = new PersonCompareByAge();
            heightComparer = new PersonCompareByHeight();
            nameComparer = new PersonCompareByName();
        }

        public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }

        public int CompareTo(Person other)
        {
            if (this.Id == other.Id)
            {
                return 0;
            }
            if (this.Id > other.Id)
            {
                return 1;
            }
            return -1;
        }

        public override string ToString()
        {
            return $"Person --- Id: {Id}, Age: {Age}, Height: {Height}, Name: {Name}";
        }
    }
}
