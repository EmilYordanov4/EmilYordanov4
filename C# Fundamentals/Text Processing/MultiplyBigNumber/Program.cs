using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplayer = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();
            int reminder = 0;
            if (multiplayer == 0)
            {
                Console.WriteLine($"0");
                return;
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int numberFromInput = int.Parse(input[i].ToString());
                int sum = numberFromInput * multiplayer + reminder;
                string numberForResult = (sum % 10).ToString();
                result.Add(numberForResult);
                reminder = sum / 10;
            }
            if (reminder != 0 )
            {
                result.Add( reminder.ToString());
            }
            result.Reverse();
            
            string finalResult = (string.Join("", result));
            finalResult = finalResult.TrimStart(new char[] {'0'});
            Console.WriteLine(finalResult);
        }
    }
}
