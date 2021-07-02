using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int smallest = SmallestNumber(numberOne, numberTwo, numberThree);

            Console.WriteLine(smallest);
        }

        static int SmallestNumber(int numOne, int numTwo, int numThree) 
        {
            int smallest = 0;
            return smallest = Math.Min(numOne, Math.Min(numTwo, numThree));
        }
    }
}
