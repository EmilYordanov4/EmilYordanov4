using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string password = Console.ReadLine();

            if (!IsPassEnoughCharacter(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                count++;
            }
            if (!IsPassOnlyDigitsAndLetters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                count++;
            }
            if (!IsPassWithLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsPassEnoughCharacter(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool IsPassOnlyDigitsAndLetters(string password) 
        {
            for (int i = 0; i < password.Length; i++)
            {
                char letter = password[i];
                if (!char.IsLetterOrDigit(letter))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsPassWithLeastTwoDigits(string password) 
        {
            int digitsCount = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char letter = password[i];
                if (char.IsDigit(letter))
                {
                    digitsCount++;
                    if (digitsCount >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
