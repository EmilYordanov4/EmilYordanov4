using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@(?<planet>[A-Z]{1}[a-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*!(?<type>A|D)![^@\-!:>]*->(?<soldiers>[0-9]+)";
            List<char> specialLetters = new List<char>() { 's', 't', 'a', 'r' };
            int n = int.Parse(Console.ReadLine());

            List<string> attack = new List<string>();
            List<string> destroy = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string encryptedInfo = Console.ReadLine();
                int count = 0;
                string decryptedMessage = DecryptingMessage(specialLetters, encryptedInfo, ref count);

                Match info = Regex.Match(decryptedMessage, pattern);

                if (info.Success)
                {
                    string planetName = info.Groups["planet"].Value;
                    string attackType = info.Groups["type"].Value;

                    if (attackType == "A")
                    {
                        attack.Add(planetName);
                    }
                    else
                    {
                        destroy.Add(planetName);
                    }
                }
            }

            attack = attack.OrderBy(x => x).ToList();
            destroy = destroy.OrderBy(x => x).ToList();

            Console.WriteLine($"Attacked planets: {attack.Count}");
            foreach (var planet in attack)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroy.Count}");
            foreach (var planet in destroy)
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        private static string DecryptingMessage(List<char> specialLetters, string encryptedInfo, ref int count)
        {
            for (int j = 0; j < encryptedInfo.Length; j++)
            {

                char infoLetter = encryptedInfo[j];
                if (specialLetters.Contains(char.ToLower(infoLetter)))
                {
                    count++;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < encryptedInfo.Length; j++)
            {
                char decryptedSymbol = (char)(encryptedInfo[j] - count);
                sb.Append(decryptedSymbol);
            }
            string decryptedMessage = sb.ToString();
            return decryptedMessage;
        }
    }
}
