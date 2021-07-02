using System;

namespace AdvertisementМessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            string[] phrases = { "Excellent product.",
                "Such a great product.", "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random rnd = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {

                int rndPhrase = rnd.Next(0, phrases.Length);
                int rndEvent = rnd.Next(0, events.Length);
                int rndAuthor = rnd.Next(0, authors.Length);
                int rndCitie = rnd.Next(0, cities.Length);

                Console.WriteLine($"{phrases[rndPhrase]} {events[rndEvent]} {authors[rndAuthor]} – {cities[rndCitie]}");
            }
        }
    }
}
