using System;

namespace DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            Console.WriteLine($"{Math.Abs(DateModifierExercise.DifferenceBetweenDates(firstDate, secondDate))}");
        }
    }
}
