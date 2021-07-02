using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> filters = new List<string>();

            string[] cmd = Console.ReadLine().Split(";", 2, StringSplitOptions.RemoveEmptyEntries);
            while (cmd[0] != "Print")
            {
                if (cmd[0] == "Add filter")
                {
                    filters.Add(cmd[1]);
                }
                else if (cmd[0] == "Remove filter")
                {
                    filters.Remove(cmd[1]);
                }

                cmd = Console.ReadLine().Split(";",2, StringSplitOptions.RemoveEmptyEntries);
            }
            Func<List<string>, string, string, List<string>> filteringFunc = (sArr, action, condition) =>
             {
                 switch (action)
                 {
                     case "Starts with":
                         return sArr.Where(x => !x.StartsWith(condition)).ToList();
                     case "Ends with":
                         return sArr.Where(x => !x.EndsWith(condition)).ToList();
                     case "Length":
                         return sArr.Where(x => x.Length != int.Parse(condition)).ToList();
                     case "Contains":
                         return sArr.Where(x => !x.Contains(condition)).ToList();
                     default:
                         return sArr;
                 }
             };

            foreach (var item in filters)
            {
                string[] info = item.Split(";");
                string typeOfAction = info[0];
                string condition = info[1];

                names = filteringFunc(names, typeOfAction, condition);
            }

            Console.WriteLine($"{string.Join(" ", names)}");
        }
    }
}
