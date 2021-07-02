using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Person other)
        {
            if (this.Name.ToLower() == other.Name.ToLower())
            {
                return this.Age.CompareTo(other.Age);
            }
            return this.Name.ToLower().CompareTo(other.Name.ToLower());
        }
        public override int GetHashCode()
        {
            return this.Name.ToLower().GetHashCode() + this.Age.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }
    }
}
