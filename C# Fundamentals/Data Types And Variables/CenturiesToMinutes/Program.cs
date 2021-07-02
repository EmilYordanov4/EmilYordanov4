using System;
using System.Numerics;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            decimal years = centuries * 100;

            decimal days = years * 365.2422M;

            BigInteger hours = (int)days * 24;

            BigInteger minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes");
        }
    }
}
