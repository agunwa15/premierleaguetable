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
           

            List<Team> teams = new List<Team>
            {
            new Team{ ID = 1, Name = "Arsenal"},
            new Team{ ID = 2, Name = "Aston Villa"},
            new Team{ ID = 3, Name = "Brentford" },
            new Team{ ID = 4, Name = "Brigthon & Hove Albion"},
            new Team{ ID = 5, Name = "Burnley"},
            new Team{ ID = 6, Name = "chelsea" },
            new Team{ ID = 7, Name = "Crystal Palace" },
            new Team{ ID = 8, Name = "Everton" },
            new Team{ ID = 9, Name = "Leeds United" },
            new Team{ ID = 10, Name = "Leicester City" },
            new Team{ ID = 11, Name = "Liverpool" },
            new Team{ ID = 12, Name = "Manchester City" },
            new Team{ ID = 13, Name = "Manchester United" },
            new Team{ ID = 14, Name = "Newcastle United" },
            new Team{ ID = 15, Name = "Norwich City" },
            new Team{ ID = 16, Name = "Southampton" },
            new Team{ ID = 17, Name = "Tottenham Hotspur" },
            new Team{ ID = 18, Name = "Watford" },
            new Team{ ID = 19, Name = "Westham United" },
            new Team{ ID = 20, Name = "Wolverhampton Wanderers" },

            };
            int num = 0;
            int ans = 0;
            int teamList = 1;
            int entermatch = 2;
            int leaguetable = 3;
            int quit = 4;
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Enter 1 to view team list");
            Console.WriteLine("Enter 2 to enter match");
            Console.WriteLine("Enter 3 to view league table");
            Console.WriteLine("Enter 4 to quit");
            Console.Write("Enter your option: ");
            ans = Convert.ToInt32(Console.ReadLine());
            while (num != quit) 
            {
               
                if (ans==entermatch) 
                {
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
                        Console.WriteLine(name1 + " Vs " + name2);
                    }

                    Console.Write("Enter Home Team goal: ");
                    int homegoal = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Away Team goal: ");
                    int awaygoal = int.Parse(Console.ReadLine());


                    match.HomeTeam = name1;
                    match.AwayTeam = name2;
                    match.HomeTeamGoal = homegoal;
                    match.AwayTeamGoal = awaygoal;

                    int played = table.getPlayed();
                    int point = table.getPoint();
                    int goaldifference = table.getGoalDifference();

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


                    //Console.WriteLine(name1+ " has played "+played++ +" with "+point++ );


                    //Console.WriteLine(name1 + " has played " + table.getPlayed());


                    if (ans == leaguetable)
                    {
                        Console.WriteLine("Team P PTS GD\n " + "Arsenal " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Aston Villa" + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Brentford " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Brigthon & Hove Albion " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Burnley " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "chelsea " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Crystal Palace " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Everton " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Leeds United " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Leicester City " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Liverpool " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Manchester City " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Manchester United " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Newcastle United " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Norwich City " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Southampton " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Tottenham Hotspur " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Watford " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Westham United " + played + point + goaldifference);
                        Console.WriteLine("Team P PTS GD\n " + "Wolverhampton Wanderers " + played + point + goaldifference);

                    }

                    if (ans==teamList)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Arsenal \nAston villa \nBrentford \nBrigthon & Hove Albion \nBurnley \nChelsea \nCrystal Palace \nEverton \nLeeds United \nLeicester city \nliverpool \nManchester City \nManchester United \nNewcastle United \nNorwich City \nSouthampton \nTottenham Hotspur \nWatford \nWestham United \nWolverhampton Wanderers");
                        Console.ResetColor();
                        
                    }
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("Enter 1 to view team list");
                    Console.WriteLine("Enter 2 to enter match");
                    Console.WriteLine("Enter 3 to view league table");
                    Console.WriteLine("Enter 4 to quit");
                    Console.Write("Enter your option: ");
                    ans = Convert.ToInt32(Console.ReadLine());

                }
                else if (ans==teamList) 
                {
                    int done = 0;
                    int limit = 1;
                    int played = table.getPlayed();
                    int point = table.getPoint();
                    int goaldifference = table.getGoalDifference();

                    while (teamList == ans)
                    {
                        if (limit != done)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Arsenal \nAston villa \nBrentford \nBrigthon & Hove Albion \nBurnley \nChelsea \nCrystal Palace \nEverton \nLeeds United \nLeicester city \nliverpool \nManchester City \nManchester United \nNewcastle United \nNorwich City \nSouthampton \nTottenham Hotspur \nWatford \nWestham United \nWolverhampton Wanderers");
                            Console.ResetColor();
                            done++;
                        }


                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("Enter 1 to view team list");
                        Console.WriteLine("Enter 2 to enter match");
                        Console.WriteLine("Enter 3 to view league table");
                        Console.WriteLine("Enter 4 to quit");
                        Console.Write("Enter your option: ");
                        ans = Convert.ToInt32(Console.ReadLine());
                        if (ans == entermatch)
                        {
                            int enterycount = 0;
                            int countlimit = 1;
                            bool backtomenu = false;
                            Console.Write("Enter Home Team: ");
                            string name1 = Console.ReadLine();
                            while (teams.Where(X => X.Name.ToUpper() == name1.ToUpper()).FirstOrDefault() == null)
                            {

                                if (enterycount != countlimit)
                                {
                                    Console.WriteLine(name1 + "does not exist in the team");
                                    Console.Write("Enter Home Team: ");
                                    name1 = Console.ReadLine();
                                    enterycount++;
                                }
                                else if (enterycount == countlimit)
                                {
                                    Console.WriteLine(name1 + "does not exist in the team");
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
                                Console.WriteLine(name1 + " Vs " + name2);
                            }

                            Console.Write("Enter Home Team goal: ");
                            int homegoal = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Away Team goal: ");
                            int awaygoal = int.Parse(Console.ReadLine());


                            match.HomeTeam = name1;
                            match.AwayTeam = name2;
                            match.HomeTeamGoal = homegoal;
                            match.AwayTeamGoal = awaygoal;

                            //int played = table.getPlayed();
                            //int point = table.getPoint();
                            //int goaldifference = table.getGoalDifference();

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


                            //Console.WriteLine(name1 + " has played " + table.getPlayed());

                            
                        }

                        if (ans == teamList)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Arsenal \nAston villa \nBrentford \nBrigthon & Hove Albion \nBurnley \nChelsea \nCrystal Palace \nEverton \nLeeds United \nLeicester city \nliverpool \nManchester City \nManchester United \nNewcastle United \nNorwich City \nSouthampton \nTottenham Hotspur \nWatford \nWestham United \nWolverhampton Wanderers");
                            Console.ResetColor();

                        }
                        if (ans== leaguetable)
                        {
                            Console.WriteLine("Team P PTS GD\n " + "Arsenal " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Aston Villa" + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Brentford " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Brigthon & Hove Albion " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Burnley " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "chelsea " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Crystal Palace " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Everton " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Leeds United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Leicester City " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Liverpool " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Manchester City " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Manchester United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Newcastle United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Norwich City " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Southampton " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Tottenham Hotspur " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Watford " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Westham United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Wolverhampton Wanderers " + played + point + goaldifference);

                        }


                    }

                }
                else if (ans == leaguetable) 
                {
                    int done = 0;
                    int limit = 1;
                    int played = table.getPlayed();
                    int point = table.getPoint();
                    int goaldifference = table.getGoalDifference();
                    while (leaguetable == ans) 
                    {
                        if (done != limit) 
                        {
                            Console.WriteLine("Team P PTS GD\n " + "Arsenal " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Aston Villa"  + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Brentford " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Brigthon & Hove Albion " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Burnley " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "chelsea " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Crystal Palace " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Everton " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Leeds United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Leicester City " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Liverpool " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Manchester City " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Manchester United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Newcastle United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Norwich City " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Southampton " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Tottenham Hotspur " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Watford " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Westham United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Wolverhampton Wanderers " + played + point + goaldifference);



                        }
                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("Enter 1 to view team list");
                        Console.WriteLine("Enter 2 to enter match");
                        Console.WriteLine("Enter 3 to view league table");
                        Console.WriteLine("Enter 4 to quit");
                        Console.Write("Enter your option: ");
                        ans = Convert.ToInt32(Console.ReadLine());

                        if (ans == entermatch)
                        {
                            int enterycount = 0;
                            int countlimit = 1;
                            bool backtomenu = false;
                            Console.Write("Enter Home Team: ");
                            string name1 = Console.ReadLine();
                            while (teams.Where(X => X.Name.ToUpper() == name1.ToUpper()).FirstOrDefault() == null)
                            {

                                if (enterycount != countlimit)
                                {
                                    Console.WriteLine(name1 + "does not exist in the team");
                                    Console.Write("Enter Home Team: ");
                                    name1 = Console.ReadLine();
                                    enterycount++;
                                }
                                else if (enterycount == countlimit)
                                {
                                    Console.WriteLine(name1 + "does not exist in the team");
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
                                Console.WriteLine(name1 + " Vs " + name2);
                            }

                            Console.Write("Enter Home Team goal: ");
                            int homegoal = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Away Team goal: ");
                            int awaygoal = int.Parse(Console.ReadLine());


                            match.HomeTeam = name1;
                            match.AwayTeam = name2;
                            match.HomeTeamGoal = homegoal;
                            match.AwayTeamGoal = awaygoal;

                            //int played = table.getPlayed();
                            //int point = table.getPoint();
                            //int goaldifference = table.getGoalDifference();

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


                            //Console.WriteLine(name1 + " has played " + table.getPlayed());


                        }

                        if (ans == teamList)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Arsenal \nAston villa \nBrentford \nBrigthon & Hove Albion \nBurnley \nChelsea \nCrystal Palace \nEverton \nLeeds United \nLeicester city \nliverpool \nManchester City \nManchester United \nNewcastle United \nNorwich City \nSouthampton \nTottenham Hotspur \nWatford \nWestham United \nWolverhampton Wanderers");
                            Console.ResetColor();

                        }
                        if (ans == leaguetable)
                        {
                            Console.WriteLine("Team P PTS GD\n " + "Arsenal " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Aston Villa" + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Brentford " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Brigthon & Hove Albion " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Burnley " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "chelsea " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Crystal Palace " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Everton " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Leeds United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Leicester City " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Liverpool " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Manchester City " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Manchester United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Newcastle United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Norwich City " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Southampton " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Tottenham Hotspur " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Watford " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Westham United " + played + point + goaldifference);
                            Console.WriteLine("Team P PTS GD\n " + "Wolverhampton Wanderers " + played + point + goaldifference);

                        }


                    }






                }
                else if (ans==quit) 
                {
                    break;

                }



            }
            if (ans == teamList||ans==entermatch||ans==leaguetable) 
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Enter 1 to view team list");
                Console.WriteLine("Enter 2 to enter match");
                Console.WriteLine("Enter 3 to view league table");
                Console.WriteLine("Enter 4 to quit");
                Console.Write("Enter your option: ");
                ans = Convert.ToInt32(Console.ReadLine());
            }
            else 
            {
                Console.WriteLine("Goodbye!");
            }

        }
    }
}
