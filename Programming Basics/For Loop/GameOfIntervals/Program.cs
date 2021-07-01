using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double endScore = 0;
            double firstRow = 0;
            double secondRow = 0;
            double thirdRow = 0;
            double forthRow = 0;
            double fifthRow = 0;
            double invalidNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    firstRow++;
                    endScore += number * 0.20;
                }
                else if (number >= 10 && number <= 19)
                {
                    secondRow++;
                    endScore += number * 0.30;
                }
                else if (number >= 20 && number <= 29)
                {
                    thirdRow++;
                    endScore += number * 0.40;
                }
                else if (number >= 30 && number <= 39)
                {
                    forthRow++;
                    endScore += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    fifthRow++;
                    endScore += 100;
                }
                else if (number < 0 || number > 50)
                {
                    invalidNumbers++;
                    endScore -= endScore / 2;
                }
            }

            Console.WriteLine($"{endScore:F2}");
            Console.WriteLine($"From 0 to 9: {firstRow / n * 100:F2}%");
            Console.WriteLine($"From 10 to 19: {secondRow / n * 100:F2}%");
            Console.WriteLine($"From 20 to 29: {thirdRow / n * 100:F2}%");
            Console.WriteLine($"From 30 to 39: {forthRow / n * 100:F2}%");
            Console.WriteLine($"From 40 to 50: {fifthRow / n * 100:F2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers / n * 100:F2}%");
        }
    }
}
