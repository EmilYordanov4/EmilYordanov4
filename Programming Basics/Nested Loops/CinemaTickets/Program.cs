using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTicket = 0;
            int standardTicket = 0;
            int kidsTicket = 0;
            double tickets = 0;
            double totalTickets = 0;

            bool flag = false;

            while (true)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    Console.WriteLine($"Total tickets: {totalTickets}");
                    Console.WriteLine($"{studentTicket / totalTickets * 100:F2}% student tickets.");
                    Console.WriteLine($"{standardTicket / totalTickets * 100:F2}% standard tickets.");
                    Console.WriteLine($"{kidsTicket / totalTickets * 100:F2}% kids tickets.");
                    break;
                }
                double freeSpots = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                while (movieName != "Finish")
                {
                    switch (ticketType)
                    {
                        case "student":
                            tickets++;
                            studentTicket++;
                            totalTickets++;
                            break;
                        case "standard":
                            tickets++;
                            standardTicket++;
                            totalTickets++;
                            break;
                        case "kid":
                            tickets++;
                            kidsTicket++;
                            totalTickets++;
                            break;
                    }
                    if (ticketType == "End" || tickets >= freeSpots)
                    {
                        double fullness = tickets / freeSpots * 100;
                        Console.WriteLine($"{movieName} - {fullness:F2}% full.");
                        tickets = 0;
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
            }
        }
    }
}
