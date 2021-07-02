using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class Family
    {
        public List<Person> People { get; set; }

        public Family()
        {
            People = new List<Person>();
        }
        public void AddMember(Person person) 
        {
            People.Add(person);
        }

        public string GetOldestMember() 
        {
            var output = People.OrderByDescending(x => x.Age).FirstOrDefault();

            return $"{output.Name} {output.Age}";
        }

    }
}
