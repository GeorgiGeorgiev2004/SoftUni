using System;
using System.Linq;
using System.Collections.Generic;
namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumOfTeams = int.Parse(Console.ReadLine());
            var teams = new List<Team>();
            for (int i = 0; i < NumOfTeams; i++)
            {
                var curInputInfo = Console.ReadLine().Split('-');
                if (teams.Any(team=>team.Name== curInputInfo[1]))
                {
                    Console.WriteLine($"Team {curInputInfo[1]} was already created!");
                }
                else if(teams.Any(team=>team.Creator== curInputInfo[0]))
                {
                    Console.WriteLine($"{curInputInfo[0]} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Name = curInputInfo[1];
                    team.Creator = curInputInfo[0];
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {curInputInfo[1]} has been created by {curInputInfo[0]}!");
                }
            }
            var switchpoint =Console.ReadLine();
            while (switchpoint != "end of assignment")
            {
                var membername = switchpoint.Split(new string[] { "->" }, StringSplitOptions.None)[0];
                var teamtojoin = switchpoint.Split(new string[] { "->" }, StringSplitOptions.None)[1];
                if (teams.Any(team=> team.Members.Contains(membername) || teams.Any(creator => creator.Creator == membername)))
                {
                    Console.WriteLine($"Member {membername} cannot join team {teamtojoin}!");
                }
                else if(!teams.Any(teamname=>teamname.Name==teamtojoin))
                {                  
                   Console.WriteLine($"Team {teamtojoin} does not exist!");                        
                }
                else
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].Name==teamtojoin)
                        {
                            teams[i].Members.Add(membername);
                        }
                    }
                   
                }
                switchpoint = Console.ReadLine();
            }
            var FullTeams = teams.Where(x => x.Members.Count > 0);
            var Disbandedteams = teams.Where(team => team.Members.Count == 0);
            foreach (var item in FullTeams.OrderByDescending(x=>x.Members.Count).ThenBy(y=>y.Name))
            {
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"- {item.Creator}");
                foreach (var member in item.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- { member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            if (Disbandedteams!=null)
            {
                foreach (var disbandedteam in Disbandedteams.OrderBy(x=>x.Name))
                {
                    Console.WriteLine(disbandedteam.Name);
                }
            }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members  { get; set; }

    }
}
