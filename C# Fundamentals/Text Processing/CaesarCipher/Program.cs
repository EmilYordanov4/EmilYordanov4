using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                int encryptedNumber = (int)word[i] + 3;
                char encryptedChar = (char)encryptedNumber;
                sb.Append(encryptedChar);
            }
            Console.WriteLine(sb);
        }
    }
}
