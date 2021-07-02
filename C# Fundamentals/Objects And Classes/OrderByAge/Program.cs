using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            List<PersonInfo> everyone = new List<PersonInfo>();

            while (input[0] != "End")
            {
                PersonInfo newPerson = new PersonInfo();

                newPerson.Name = input[0];
                newPerson.ID = input[1];
                newPerson.Age = int.Parse(input[2]);

                everyone.Add(newPerson);

                input = Console.ReadLine().Split(" ");
            }
            List<PersonInfo> sortedPersons = everyone.OrderByDescending(x => x.Age).ToList();
            sortedPersons.Reverse();
            sortedPersons.ForEach(x => Console.WriteLine(x));
        }
    }
}
class PersonInfo
{
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} with ID: {ID} is {Age} years old.";
    }
}
