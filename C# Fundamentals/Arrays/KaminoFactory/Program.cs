using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] DNA = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] bestDNA = new string[DNA.Length];
            int[] numberDNA = new int[DNA.Length];
            int index = 0;
            int bestIndex = int.MaxValue;
            int count = 0;
            int bestCount = 0;
            int bestSum = 0;
            int whileCount = 1;
            int bestWhileCount = 0;
            while (true)
            {

                string entry = string.Join("", DNA);
                if (entry == "Clone them")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < DNA.Length; i++)
                    {
                        numberDNA[i] = int.Parse(DNA[i]);
                    }
                }

                for (int i = 0; i < DNA.Length; i++)
                {
                    for (int k = i; k < DNA.Length; k++)
                    {
                        if (DNA[i] == DNA[k] && numberDNA[i] > 0 && numberDNA[k] > 0)
                        {
                            count++;
                            index = i;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if ((bestIndex > index && count == bestCount) || (numberDNA.Sum() > bestSum && bestIndex == index && count == bestCount) || (count > bestCount))
                    {

                        bestSum = numberDNA.Sum();
                        bestIndex = index;
                        bestDNA = DNA;
                        bestCount = count;
                        bestWhileCount = whileCount;

                    }
                    count = 0;
                    index = 0;
                }
                DNA = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToArray();
                whileCount++;
            }
            Console.WriteLine($"Best DNA sample {bestWhileCount} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));

        }
    }
}
