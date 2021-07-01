using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double face = side * side;
                Console.WriteLine(Math.Round(face, 3));
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double face = sideA * sideB;
                Console.WriteLine(Math.Round(face, 3));
            }
            else if (figure == "circle")
            {
                double side = double.Parse(Console.ReadLine());
                double face = (side * side) * Math.PI;
                Console.WriteLine(Math.Round(face, 3));
            }
            else 
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double face = (sideA * sideB) / 2;
                Console.WriteLine(Math.Round(face ,3));
            }
        }
    }
}
