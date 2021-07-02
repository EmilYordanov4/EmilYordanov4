using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = number[0];
            int power = number[1];
            int indexOfBombNumber = 0;
            int countOfBombingNumbers = 1;

            while (countOfBombingNumbers != 0)
            {
                indexOfBombNumber = FindingIndexOfBombNumber(listOfNumbers, bombNumber, indexOfBombNumber);

                BombingRightSide(listOfNumbers, power, indexOfBombNumber);
                BombingLeftSide(listOfNumbers, power, indexOfBombNumber);
                countOfBombingNumbers--;
                for (int i = 0; i < listOfNumbers.Count; i++)
                {
                    if (bombNumber == listOfNumbers[i])
                    {
                        countOfBombingNumbers++;
                        break;
                    }
                }
            }
            Console.WriteLine(listOfNumbers.Sum());
        }

        private static void BombingLeftSide(List<int> listOfNumbers, int power, int indexOfBombNumber)
        {
            for (int i = indexOfBombNumber - 1; i >= indexOfBombNumber - power; i--)
            {
                if (i < 0)
                {
                    break;
                }
                else
                {
                    listOfNumbers.RemoveAt(i);
                }
            }
        }

        private static int FindingIndexOfBombNumber(List<int> listOfNumbers, int bombNumber, int indexOfBombNumber)
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] == bombNumber)
                {
                    indexOfBombNumber = i;
                }
            }

            return indexOfBombNumber;
        }

        private static void BombingRightSide(List<int> listOfNumbers, int power, int indexOfBombNumber)
        {
            for (int i = 0; i < power + 1; i++)
            {
                if (indexOfBombNumber >= listOfNumbers.Count)
                {
                    break;
                }
                else
                {
                    listOfNumbers.RemoveAt(indexOfBombNumber);

                }

            }
        }
    }
}
