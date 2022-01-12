using System;
using System.Collections.Generic;
using System.Linq;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Premier League Table 2021/2022");

           


            Match match = new Match();
            LeagueTable table = new LeagueTable();
           


            bool quit = false;

            while (quit == false)
            {
                int option = showMenu();
                if (option == 1)
                {
                    listTeams();
                }
                else if (option == 2)
                {
                    Match();
                }
                else if (option == 3)
                {
                    LeagueTable();
                }
                else if (option == 4)
                {
                    quit = true;
                }

            }

            

        }

        static int showMenu()
        {
            int ans = 0;
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Enter 1 to view team list");
            Console.WriteLine("Enter 2 to enter match");
            Console.WriteLine("Enter 3 to view league table");
            Console.WriteLine("Enter 4 to quit");
            Console.Write("Enter your option: ");
            ans = Convert.ToInt32(Console.ReadLine());
            return ans;
        }

        static List<Team> getAllTeams()
        {

            List<Team> teams = new List<Team>
            {
            new Team{ Id= 1, Name = "Arsenal"},
            new Team{ Id= 2, Name = "Aston Villa"},
            new Team{ Id= 3, Name = "Brentford" },
            new Team{ Id= 4, Name = "Brigthon & Hove Albion"},
            new Team{ Id= 5, Name = "Burnley"},
            new Team{ Id= 6, Name = "chelsea" },
            new Team{ Id= 7, Name = "Crystal Palace" },
            new Team{ Id= 8, Name = "Everton" },
            new Team{ Id= 9, Name = "Leeds United" },
            new Team{ Id= 10, Name = "Leicester City" },
            new Team{ Id= 11, Name = "Liverpool" },
            new Team{ Id= 12, Name = "Manchester City" },
            new Team{ Id= 13, Name = "Manchester United" },
            new Team{ Id= 14, Name = "Newcastle United" },
            new Team{ Id= 15, Name = "Norwich City" },
            new Team{ Id= 16, Name = "Southampton" },
            new Team{ Id= 17, Name = "Tottenham Hotspur" },
            new Team{ Id= 18, Name = "Watford" },
            new Team{ Id= 19, Name = "Westham United" },
            new Team{ Id= 20, Name = "Wolverhampton Wanderers" },

            };
            return teams;
        }

        static void listTeams()
        {
            List<Team> teams = getAllTeams();

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var team in teams)
            {
                Console.WriteLine(team.Id.ToString()+" - "+team.Name);
            }
            Console.ResetColor();
        }

        static void Match() 
        {
            List<Team> teams = getAllTeams();
            int enterycount = 0;
            int countlimit = 1;
            bool backtomenu = false;
            Console.Write("Enter Home Team: ");
            string name1 = Console.ReadLine();
            while (teams.Where(X => X.Name.ToUpper() == name1.ToUpper()).FirstOrDefault() == null)
            {

                if (enterycount != countlimit)
                {
                    Console.WriteLine(name1 + " does not exist in the team");
                    Console.Write("Enter Home Team: ");
                    name1 = Console.ReadLine();
                    enterycount++;
                }
                else if (enterycount == countlimit)
                {
                    Console.WriteLine(name1 + " does not exist in the team");
                    Console.Write("Enter Home Team: ");
                    name1 = Console.ReadLine();
                    enterycount++;
                }
                else
                {
                    backtomenu = true;
                }


            }

            Console.Write("Enter Away Team: ");
            string name2 = Console.ReadLine();


            while (teams.Where(X => X.Name.ToUpper() == name2.ToUpper()).FirstOrDefault() == null)
            {

                if (enterycount != countlimit)
                {
                    Console.WriteLine(name2 + "does not exist in the team");
                    Console.Write("Enter Home Team: ");
                    name2 = Console.ReadLine();
                    enterycount++;
                }
                else if (enterycount == countlimit)
                {
                    Console.WriteLine(name2 + "does not exist in the team");
                    Console.Write("Enter Home Team: ");
                    name1 = Console.ReadLine();
                    enterycount++;
                }
                else
                {
                    backtomenu = true;
                }

            }

            if (backtomenu)
            {
                Console.WriteLine("Back to menu");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(name1 + " Vs " + name2);
                Console.ResetColor();
            }

            Console.Write("Enter Home Team goal: ");
            int homegoal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Away Team goal: ");
            int awaygoal = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            if (homegoal > awaygoal)
            {
                Console.WriteLine(name1 + " wins.");
            }

            else if (homegoal < awaygoal)
            {
                Console.WriteLine(name2 + " wins.");
            }

            else
            {
                Console.WriteLine("The match ends as a draw.");
            }
            Console.ResetColor();


        }

        static void LeagueTable() 
        {

        }
    }
}
