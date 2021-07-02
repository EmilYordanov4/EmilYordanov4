using System;

namespace SheUmra
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string[] cmds = Console.ReadLine().Split("|");

            while (cmds[0] != "Decode")
            {
                string typeOfAction = cmds[0];

                if (typeOfAction == "Move")
                {
                    int numberOfLetters = int.Parse(cmds[1]);

                    for (int i = 0; i < numberOfLetters; i++)
                    {
                        char letter = encryptedMessage[0];
                        encryptedMessage = encryptedMessage.Remove(0, 1);
                        encryptedMessage = encryptedMessage.Insert(encryptedMessage.Length, letter.ToString());
                    }
                }
                else if (typeOfAction == "Insert")
                {
                    int index = int.Parse(cmds[1]);
                    string value = cmds[2];

                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (typeOfAction == "ChangeAll")
                {
                    string oldString = cmds[1];
                    string newString = cmds[2];

                    encryptedMessage = encryptedMessage.Replace(oldString, newString);
                }


                cmds = Console.ReadLine().Split("|");
            }
            Console.WriteLine($"The decrypted message is: { encryptedMessage}");
        }
    }
}
