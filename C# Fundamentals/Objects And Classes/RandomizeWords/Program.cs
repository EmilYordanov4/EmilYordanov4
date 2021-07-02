    using System;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split().ToArray();
            Random rnd = new Random();


            for (int i = 0; i < sentence.Length; i++)
            {
                int randomIndex = rnd.Next(0, sentence.Length);

                string a = sentence[randomIndex];
                string b = sentence[i];

                sentence[randomIndex] = b;
                sentence[i] = a;
            }

            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }        
        }
    }
}
