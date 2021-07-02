using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(key))
                {
                    synonyms.Add(key, new List<string>());
                }
                synonyms[key].Add(synonym);
            }
            foreach (var item in synonyms)
            {
                Console.Write($"{item.Key} - ");
                if (item.Value.Count == 1)
                {
                    Console.Write(item.Value[0]);
                }
                else
                {
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write($"{item.Value[i]}");
                        }
                        else
                        {
                            Console.Write($", {item.Value[i]}");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
