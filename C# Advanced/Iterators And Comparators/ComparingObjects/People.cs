using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class People<Person> : IEnumerable<Person>
    {
        public List<Person> ListOfPeople { get; set; }
        public People()
        {
            this.ListOfPeople = new List<Person>();
        }

        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < ListOfPeople.Count; i++)
            {
                yield return ListOfPeople[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
