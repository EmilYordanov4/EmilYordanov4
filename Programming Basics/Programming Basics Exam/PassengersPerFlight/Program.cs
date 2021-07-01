using System;

namespace PassengersPerFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalPassengers = 0;
            double totalAveragePassengers = 0;
            double mostAveragePassengers = 0;
            string companyMost = "";
            double count = 0;

            for (int i = 0; i < n; i++)
            {
                string companyName = Console.ReadLine();
                string input = Console.ReadLine();
                while (input != "Finish")
                {
                    count++;
                    int passengers = int.Parse(input);
                    totalPassengers += passengers;

                    input = Console.ReadLine();
                }
                totalAveragePassengers = Math.Floor(totalPassengers / count);
                if (input == "Finish")
                {
                    Console.WriteLine($"{companyName}: {Math.Floor(totalPassengers / count)} passengers.");
                }
                if (totalAveragePassengers > mostAveragePassengers)
                {
                    mostAveragePassengers = totalAveragePassengers;
                    companyMost = companyName;
                }
                totalAveragePassengers = 0;
                totalPassengers = 0;
                count = 0;
            }
            Console.WriteLine($"{companyMost} has most passengers per flight: {mostAveragePassengers}");
        }
    }
}
