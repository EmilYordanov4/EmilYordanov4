using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    break;
                case "June":    
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
            }

            if (nights > 7 && nights < 14 && (month == "May" || month == "October") )
            {
                studioPrice -= studioPrice * 0.05;
            }
            else if (nights > 14 && (month == "May" || month == "October"))
            {
                studioPrice -= studioPrice * 0.30;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                studioPrice -= studioPrice * 0.20;
            }

            if (nights > 14)
            {
                apartmentPrice -= apartmentPrice * 0.10;
            }

            Console.WriteLine($"Apartment: {apartmentPrice * nights:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice * nights:F2} lv.");
        }
    }
}
