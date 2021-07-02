using System;
using System.Collections.Generic;
using System.Linq;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int power = int.Parse(input[i + 1].ToString());
                    for (int j = i ; j < i + power; j++)
                    {
                        if (input[j] == '>')
                        {
                            power += int.Parse(input[j + 1].ToString());
                        }
                        else
                        {
                            input = input.Remove(j + 1, int.Parse(input[i + 1].ToString()));
                        }
                    }
                }
            }
        }
    }
}
