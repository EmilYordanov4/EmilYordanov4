    using System;

    namespace ConvertMetersToKilometers
    {
        class Program
        {
            static void Main(string[] args)
            {
                int meters = int.Parse(Console.ReadLine());

                float km = meters * 0.001f;

                Console.WriteLine($"{km:F2}");
            }
        }
    }
