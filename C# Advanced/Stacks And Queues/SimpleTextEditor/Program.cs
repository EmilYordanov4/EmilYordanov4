using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ");

                string action = cmd[0];

                if (action == "1")
                {
                    for (int j = 1; j < cmd.Length; j++)
                    {
                        text.Append(cmd[j]);
                    }
                }
                else if (action == "2")
                {
                    int count = int.Parse(cmd[1]);

                    for (int j = text.Length - 1; j >= text.Length - count - 1; j--)
                    {

                    }
                }
            }
        }
    }
}
