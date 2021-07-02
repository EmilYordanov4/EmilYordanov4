using System;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            People<Person> personList = new People<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                Person newPerson = new Person(name, age, town);

                personList.ListOfPeople.Add(newPerson);

                input = Console.ReadLine();
            }

            int neededPerson = int.Parse(Console.ReadLine());
            int countOfMatches = 0;
            int countOfNotEqualPeople = 0;


            Person comparablePerson = personList.ListOfPeople[neededPerson - 1];

            foreach (var item in personList)
            {
                int res = comparablePerson.CompareTo(item);
                if (res == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    countOfNotEqualPeople++;
                }
            }

            if (countOfMatches == 1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {countOfNotEqualPeople} {personList.ListOfPeople.Count}");
            }

        }
    }
}
