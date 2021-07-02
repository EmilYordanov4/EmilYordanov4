using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double pricePerLightsaber = double.Parse(Console.ReadLine());
            double pricePerRobe = double.Parse(Console.ReadLine()); 
            double pricePerBelt = double.Parse(Console.ReadLine());

            double priceLightsabers = pricePerLightsaber * (students + Math.Ceiling(students * 0.10));
            double priceRobes = pricePerRobe * students;
            double priceBelts = pricePerBelt * students - (students / 6 * pricePerBelt);

            double totalSum = priceLightsabers + priceBelts + priceRobes;

            if (totalSum <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else if(budget < totalSum)
            {
                Console.WriteLine($"Ivan Cho will need {totalSum - budget:F2}lv more.");
            }
        }
    }
}
