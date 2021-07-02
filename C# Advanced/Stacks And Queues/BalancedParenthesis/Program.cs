using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string brackets = Console.ReadLine();
            Stack<char> firstStack = new Stack<char>();
            Stack<char> secondStack = new Stack<char>();

            bool isBalanced = true;

            if (brackets.Length % 2 == 0 )
            {
                SettingFirstHalf(brackets, firstStack);
                SettingSecondHalf(brackets, secondStack);
                while (firstStack.Count != 0)
                {
                    char firstBracket = firstStack.Pop();
                    char secondBracket = secondStack.Pop();

                    if (firstBracket == '(')
                    {
                        if (secondBracket != ')')
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                    else if (firstBracket == '[')
                    {
                        if (secondBracket != ']')
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                    else if (firstBracket == '{')
                    {
                        if (secondBracket != '}')
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                    else if (firstBracket == ' ')
                    {
                        if (secondBracket != ' ')
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                isBalanced = false;
            }

            if (isBalanced == true && brackets.Length != 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static void SettingFirstHalf(string brackets, Stack<char> firstStack)
        {
            for (int i = 0; i < brackets.Length / 2; i++)
            {
                firstStack.Push(brackets[i]);
            }
        }

        private static void SettingSecondHalf(string brackets, Stack<char> secondStack)
        {
            for (int i = brackets.Length - 1; i >= brackets.Length / 2; i--)
            {
                secondStack.Push(brackets[i]);
            }
        }
    }
}
