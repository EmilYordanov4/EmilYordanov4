using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;

            if (projection == "Premiere")
            {
                Console.WriteLine($"{row * column * premiere:F2} leva");
            }
            else if (projection == "Normal")
            {
                Console.WriteLine($"{row * column * normal:F2} leva");

            }
            else if (projection == "Discount" )
            {
                Console.WriteLine($"{row * column * discount:F2} leva");
            }
        }
    }
}
