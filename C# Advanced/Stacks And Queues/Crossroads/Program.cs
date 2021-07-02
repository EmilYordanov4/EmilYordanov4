using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int greenLightTimer = greenLightDuration;
            int freeWindow = int.Parse(Console.ReadLine());
            int freeWindowTimer = freeWindow;
            int totalSeconds = greenLightDuration + freeWindow;
            bool isPassed = false;
            char crashSymbol = ' ';
            int carsPassed = 0;

            Queue<string> cars = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    while (totalSeconds != 0 && cars.Count != 0)
                    {

                        string passingCar = cars.Peek();
                        int carLength = 0;
                        if (greenLightTimer > 0)
                        {
                            for (int i = 0; i < passingCar.Length; i++)
                            {
                                carLength++;
                                totalSeconds--;
                                greenLightTimer--;
                                if (greenLightTimer == 0)
                                {
                                    break;
                                }
                                if (carLength == passingCar.Length)
                                {
                                    isPassed = true;
                                    break;
                                }
                            }
                        }
                        if (isPassed == false && carLength < passingCar.Length)
                        {
                            for (int i = carLength; i < passingCar.Length; i++)
                            {
                                crashSymbol = passingCar[i];
                                totalSeconds--;
                                carLength++;
                                if (totalSeconds < 0)
                                {
                                    Console.WriteLine($"A crash happened!");
                                    Console.WriteLine($"{passingCar} was hit at {crashSymbol}.");
                                    Environment.Exit(0);
                                }
                                if (carLength == passingCar.Length)
                                {
                                    isPassed = true;
                                    break;
                                }
                            }
                        }
                        if (isPassed == true)
                        {
                            isPassed = false;
                            carsPassed++;
                            cars.Dequeue();
                        }
                        if (totalSeconds <= freeWindow)
                        {
                            break;
                        }
                    }
                    totalSeconds = freeWindow + greenLightDuration;
                    greenLightTimer = greenLightDuration;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");

        }
    }
}
