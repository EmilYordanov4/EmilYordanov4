using System;
using System.Runtime.ExceptionServices;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int facebook = 150;
            int instragram = 100;
            int reddit = 50;

            for (int i = 0; i < n; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    salary -= facebook;
                }
                else if (site == "Instagram")
                {
                    salary -= instragram;
                }
                else if (site == "Reddit")
                {
                    salary -= reddit;
                }
                if (salary == 0)
                {
                    break;
                }
            }
            if (salary == 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
