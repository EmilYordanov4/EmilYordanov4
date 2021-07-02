using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(Area(width, height));

            static int Area(int width, int height) 
            {
                return width * height;
            }
        }
    }
}
