using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace League_table_12._10._23
{
    internal class Program
    {
        public struct team
        {
            public string Name;
            public int wins;
            public int losses;
            public int draws;
            public int points;
        }
        public static void Main(string[] args)
        {


            team[] LeagueTable = new team[5];
            TeamInfo(LeagueTable);
            DisplayTable(LeagueTable);
            Console.ReadLine();
        }
            public static void TeamInfo(team[] LeagueTable)
            {
                Console.WriteLine("Please enter 5 team Names.\n");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter a Team Name: ");
                    LeagueTable[i].Name = Console.ReadLine();
                    Console.Write("Enter amount of Wins /10: ");
                    LeagueTable[i].wins = int.Parse(Console.ReadLine());
                    Console.Write("Enter amount of Draws /10: ");
                    LeagueTable[i].draws = int.Parse(Console.ReadLine());
                    Console.Write("Enter amount of Losses /10: ");
                    LeagueTable[i].losses = int.Parse(Console.ReadLine());
                    Console.Write("Enter amount of Points /30: ");
                    LeagueTable[i].points = int.Parse(Console.ReadLine());
                
                }
            }
                public static void DisplayTable(team[] LeagueTable)
                {
                for (int i = 0; i < 5; i++)
                {
                Console.Write(LeagueTable[i].Name);

                Console.Write(LeagueTable[i].wins);

                Console.Write(LeagueTable[i].draws);

                Console.Write(LeagueTable[i].losses);

                Console.Write(LeagueTable[i].points);

                
                }
                
                
                }
    }
}
