using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> userLanguage = new Dictionary<string, List<string>>();
            Dictionary<string, int> userPoints = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] info = input.Split("-");
                if (info[1] != "banned")
                {
                    CoutingResults(userLanguage, userPoints, submissions, info);
                }
                else
                {
                    BanningUser(ref userLanguage, ref userPoints, info);
                }
            }
            PritingResult(ref userPoints, ref submissions);
        }

        private static void BanningUser(ref Dictionary<string, List<string>> userLanguage, ref Dictionary<string, int> userPoints, string[] info)
        {
            string name = info[0];
            userPoints = userPoints.Where(x => x.Key != name).ToDictionary(a => a.Key, b => b.Value);
            userLanguage = userLanguage.Where(x => x.Key != name).ToDictionary(a => a.Key, b => b.Value);
        }

        private static void CoutingResults(Dictionary<string, List<string>> userLanguage, Dictionary<string, int> userPoints, Dictionary<string, int> submissions, string[] info)
        {
            string name = info[0];
            string language = info[1];
            int points = int.Parse(info[2]);
            if (!userLanguage.ContainsKey(name))
            {
                userLanguage[name] = new List<string>();
                userPoints[name] = 0;
            }
            if (points > userPoints[name])
            {
                userLanguage[name].Add(language);
                userPoints[name] = points;
            }
            if (!submissions.ContainsKey(language))
            {
                submissions[language] = 0;
            }
            submissions[language]++;
        }

        private static void PritingResult(ref Dictionary<string, int> userPoints, ref Dictionary<string, int> submissions)
        {
            userPoints = userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            submissions = submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"Results:");
            foreach (var item in userPoints)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine($"Submissions:");
            foreach (var item in submissions)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
