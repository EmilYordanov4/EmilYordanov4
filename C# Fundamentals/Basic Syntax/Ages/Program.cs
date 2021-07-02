using System;

namespace BasicSyntaxConditionalStatementsAndLoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string type = "";

            if (age < 0)
            {

            }
            else if (age <= 2)
            {
                type = "baby";
            }
            else if (age <= 13)
            {
                type = "child";
            }
            else if (age <= 19)
            {
                type = "teenager";
            }
            else if (age <= 65)
            {
                type = "adult";
            }
            else
            {
                type = "elder";
            }
            Console.WriteLine(type);
        }
    }
}
