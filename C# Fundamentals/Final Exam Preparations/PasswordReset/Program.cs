using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "Done")
            {
                if (cmd[0] == "TakeOdd" )
                {
                    password = TakeOdd(password);
                    Console.WriteLine(password);
                }
                else if (cmd[0] == "Cut")
                {
                    password = CuttingPassword(password, cmd);
                    Console.WriteLine(password);


                }
                else if (cmd[0] == "Substitute")
                {
                    password = ReplacingStrings(password, cmd);
                }



                cmd = Console.ReadLine().Split();
            }

            Console.WriteLine($"Your password is: {password}");
        }

        private static string ReplacingStrings(string password, string[] cmd)
        {
            string substring = cmd[1];
            string substitute = cmd[2];

            if (password.Contains(substring))
            {
                password = password.Replace(substring, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine($"Nothing to replace!");
            }

            return password;
        }

        private static string CuttingPassword(string password, string[] cmd)
        {
            int index = int.Parse(cmd[1]);
            int lenght = int.Parse(cmd[2]);

            List<char> charPassword = new List<char>();
            StringToCharList(password, charPassword);

            for (int i = index; i < index + lenght; i++)
            {
                charPassword.RemoveAt(index);
            }
            password = string.Join("", charPassword);
            return password;
        }

        private static void StringToCharList(string password, List<char> charPassword)
        {
            for (int i = 0; i < password.Length; i++)
            {
                charPassword.Add(password[i]);
            }
        }

        private static string TakeOdd(string password)
        {
            string newPassword = string.Empty;
            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newPassword += password[i];
                }
            }
            password = newPassword;
            return password;
        }
    }
}
