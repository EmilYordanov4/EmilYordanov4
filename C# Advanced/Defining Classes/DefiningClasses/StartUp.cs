using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family newFamily = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person newPerson = new Person(input[0], int.Parse(input[1]));

                newFamily.AddMember(newPerson);
            }

            Console.WriteLine(newFamily.GetOldestMember().ToString());
        }
    }
}
