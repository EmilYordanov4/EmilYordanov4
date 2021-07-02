using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] manipulatedArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] input = Console.ReadLine().Split().ToArray();


            while (input[0] != "end")
            {
                if (input[0] == "exchange")
                {
                    int exchanges = int.Parse(input[1]);
                    if (exchanges >= 0 && exchanges < manipulatedArr.Length)
                    {
                        manipulatedArr = ExchangingIndex(manipulatedArr, exchanges);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (input[0] == "max")
                {
                    if (input[1] == "even")
                    {
                        MaxEven(manipulatedArr);
                    }
                    else
                    {
                        MaxOdd(manipulatedArr);
                    }
                }
                else if (input[0] == "min")
                {
                    if (input[1] == "even")
                    {
                        MinEven(manipulatedArr);
                    }
                    else
                    {
                        MinOdd(manipulatedArr);
                    }
                }
                else if (input[0] == "first")
                {
                    int countNeeded = int.Parse(input[1]);
                    if (countNeeded >= manipulatedArr.Length + 1)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (input[2] == "even")
                    {
                        PrintingFirstEvenNumbers(manipulatedArr, countNeeded);
                    }
                    else
                    {
                        PrintingFirstOddNumbers(manipulatedArr, countNeeded);
                    }
                }
                else if (input[0] == "last")
                {
                    int countNeeded = int.Parse(input[1]);
                    if (countNeeded >= manipulatedArr.Length + 1)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (input[2] == "even")
                    {
                        PrintingLastEvenNumbers(manipulatedArr, countNeeded);
                    }
                    else
                    {
                        PrintingLastOddNumbers(manipulatedArr, countNeeded);
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
            if (input[0] == "end")
            {
                Console.Write($"[{string.Join(", ", manipulatedArr)}]");
            }
        }

        static int[] ExchangingIndex(int[] array, int exchanges)
        {
            int[] firstHalfArr = new int[exchanges + 1];
            int[] secondHalfArr = new int[array.Length - exchanges - 1];

            int firstHalf = array.Length - exchanges - 1;
            int secondHalf = array.Length - firstHalf;

            int[] manipulatedArr = new int[array.Length];

            for (int i = 0; i < exchanges + 1; i++)
            {
                firstHalfArr[i] = array[i];
                manipulatedArr[i + firstHalf] = firstHalfArr[i];
            }
            for (int i = 0; i < array.Length - exchanges - 1; i++)
            {
                secondHalfArr[i] = array[i + secondHalf];
                manipulatedArr[i] = secondHalfArr[i];
            }
            return manipulatedArr;
        }

        static void MaxEven(int[] array)
        {
            int minValue = int.MinValue;
            int index = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] >= minValue)
                {
                    minValue = array[i];
                    index = i;
                }
            }
            if (minValue == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MaxOdd(int[] array)
        {
            int minValue = int.MinValue;
            int index = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {

                }
                else
                {
                    if (array[i] >= minValue)
                    {
                        minValue = array[i];
                        index = i;
                    }
                }
            }
            if (minValue == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MinEven(int[] array)
        {
            int maxValue = int.MaxValue;
            int index = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] <= maxValue)
                {
                    maxValue = array[i];
                    index = i;
                }
            }
            if (maxValue == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MinOdd(int[] array)
        {
            int maxValue = int.MaxValue;
            int index = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {

                }
                else
                {
                    if (array[i] <= maxValue)
                    {
                        maxValue = array[i];
                        index = i;
                    }

                }
            }
            if (maxValue == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void PrintingFirstEvenNumbers(int[] array, int countNeeded)
        {
            int count = 0;
            int[] firstNumbers = new int[countNeeded];

            for (int i = 0; i < array.Length; i++)
            {
                if (count >= countNeeded)
                {
                    break;
                }
                if (array[i] % 2 == 0)
                {
                    firstNumbers[count] = array[i];
                    count++;
                }
            }
            int countForCW = 0;
            Console.Write("[");
            for (int i = 0; i < countNeeded; i++)
            {

                if (firstNumbers[i] != 0 && countForCW == 0)
                {
                    Console.Write(firstNumbers[i]);
                    countForCW++;
                }
                else if (firstNumbers[i] == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(", " + firstNumbers[i]);
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }

        static void PrintingFirstOddNumbers(int[] array, int countNeeded)
        {
            int count = 0;
            int[] firstNumbers = new int[countNeeded];

            for (int i = 0; i < array.Length; i++)
            {
                if (count >= countNeeded)
                {
                    break;
                }
                if (array[i] % 2 == 0)
                {

                }
                else
                {
                    firstNumbers[count] = array[i];
                    count++;
                }
            }
            int countForCW = 0;
            Console.Write("[");
            for (int i = 0; i < countNeeded; i++)
            {

                if (firstNumbers[i] != 0 && countForCW == 0)
                {
                    Console.Write(firstNumbers[i]);
                    countForCW++;
                }
                else if (firstNumbers[i] == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(", " + firstNumbers[i]);
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }

        static void PrintingLastEvenNumbers(int[] array, int countNeeded)
        {
            int count = 0;
            int[] lastNumbers = new int[countNeeded];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (count >= countNeeded)
                {
                    break;
                }
                if (array[i] % 2 == 0)
                {
                    lastNumbers[count] = array[i];
                    count++;
                }
            }
            int countForCW = 0;
            Console.Write("[");
            for (int i = 0; i < countNeeded; i++)
            {

                if (lastNumbers[i] != 0 && countForCW == 0)
                {
                    Console.Write(lastNumbers[i]);
                    countForCW++;
                }
                else if (lastNumbers[i] == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(", " + lastNumbers[i]);
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }

        static void PrintingLastOddNumbers(int[] array, int countNeeded)
        {
            int count = 0;
            int[] lastNumbers = new int[countNeeded];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (count >= countNeeded)
                {
                    break;
                }
                if (array[i] % 2 == 0)
                {

                }
                else
                {
                    lastNumbers[count] = array[i];
                    count++;
                }
            }
            int countForCW = 0;
            Console.Write("[");
            for (int i = 0; i < countNeeded; i++)
            {

                if (lastNumbers[i] != 0 && countForCW == 0)
                {
                    Console.Write(lastNumbers[i]);
                    countForCW++;
                }
                else if (lastNumbers[i] == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(", " + lastNumbers[i]);
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
