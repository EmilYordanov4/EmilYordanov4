using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> allEngines = new List<Engine>();
            List<Car> allCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine newEngine = new Engine();
                newEngine.Model = info[0];
                newEngine.Power = int.Parse(info[1]);

                if (info.Length == 3)
                {
                    string thirdParam = info[2];
                    if (char.IsDigit(thirdParam, 0))
                    {
                        newEngine.Displacement = thirdParam;
                    }
                    else
                    {
                        newEngine.Efficiency = thirdParam;
                    }
                }
                else if (info.Length == 4)
                {
                    newEngine.Displacement = info[2];
                    newEngine.Efficiency = info[3];
                }
                allEngines.Add(newEngine);
            }

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car newCar = new Car();

                newCar.Model = info[0];
                newCar.Engine = allEngines.Where(x => x.Model == info[1]).FirstOrDefault();

                if (info.Length == 3)
                {
                    string thirdParam = info[2];

                    if (char.IsDigit(thirdParam, 0))
                    {
                        newCar.Weight = thirdParam;
                    }
                    else
                    {
                        newCar.Color = thirdParam;
                    }
                }
                else if (info.Length == 4)
                {
                    newCar.Weight = info[2];
                    newCar.Color = info[3];
                }

                allCars.Add(newCar);
            }

            foreach (var item in allCars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
