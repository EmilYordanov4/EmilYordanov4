using System;
using System.Collections.Generic;
using System.Text;

namespace TeamworkProjects
{
    class Teams
    {
        public Teams(string creator, string teamName) 
        {
            Creator = creator;
            TeamName = teamName;
        }
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
}
