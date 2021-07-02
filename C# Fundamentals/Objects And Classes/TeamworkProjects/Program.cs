using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Teams> allTeams = new List<Teams>();

            for (int i = 0; i < n; i++)
            {
                string[] newTeamInfo = Console.ReadLine().Split("-");
                Teams newTeam = new Teams(newTeamInfo[0], newTeamInfo[1]);
                Teams searchingTeamName = allTeams.Find(x => x.TeamName == newTeamInfo[1]);
                if (searchingTeamName != null)
                {
                    Console.WriteLine($"Team {newTeamInfo[1]} was already created!");
                    continue;
                }
                Teams existingCreator = allTeams.Find(x => x.Creator.Contains(newTeamInfo[0]));
                if (existingCreator != null)
                {
                    Console.WriteLine($"{newTeamInfo[0]} cannot create another team!");
                    continue;
                }
                Console.WriteLine($"Team {newTeamInfo[1]} has been created by {newTeamInfo[0]}!");
                allTeams.Add(newTeam);
            }
            string[] input = Console.ReadLine().Split("->");
            while (input[0] == "end of assignment")
            {
                
                input = Console.ReadLine().Split("->");
            }
                        
        }
    }
}
