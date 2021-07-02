using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string codedWord = Console.ReadLine();

            string[] cmd = Console.ReadLine().Split(":|:");

            while (cmd[0] != "Reveal")
            {
                string typeOfCmd = cmd[0];
                if (typeOfCmd == "InsertSpace")
                {
                    codedWord = InsertingSpace(codedWord, cmd);
                }
                else if (typeOfCmd == "Reverse")
                {
                    codedWord = ReversingWords(codedWord, cmd);
                }
                else if (typeOfCmd == "ChangeAll")
                {
                    codedWord = ChangingAll(codedWord, cmd);
                }

                cmd = Console.ReadLine().Split(":|:");
            }

            Console.WriteLine($"You have a new text message: {codedWord}");
        }

        private static string ChangingAll(string codedWord, string[] cmd)
        {
            string substring = cmd[1];
            string replacement = cmd[2];

            codedWord = codedWord.Replace(substring, replacement);

            Console.WriteLine(codedWord);
            return codedWord;
        }

        private static string ReversingWords(string codedWord, string[] cmd)
        {
            string reverseWord = cmd[1];
            if (codedWord.Contains(reverseWord))
            {

                int index = codedWord.IndexOf(reverseWord);
                codedWord = codedWord.Remove(index, reverseWord.Length);
                
                char[] reversedWord = reverseWord.ToCharArray();
                Array.Reverse(reversedWord);
                reverseWord = string.Join("", reversedWord);

                
                StringBuilder sbCodedWord = new StringBuilder(codedWord);
                sbCodedWord.Append(reverseWord);
                codedWord = sbCodedWord.ToString();

                Console.WriteLine(codedWord);


            }
            else
            {
                Console.WriteLine($"error");
            }

            return codedWord;
        }

        private static string InsertingSpace(string codedWord, string[] cmd)
        {
            int index = int.Parse(cmd[1]);
            if (index < 0 || index >= codedWord.Length)
            {
                return codedWord;
            }
            codedWord = codedWord.Insert(index, " ");

            Console.WriteLine(codedWord);
            return codedWord;
        }
    }
}
