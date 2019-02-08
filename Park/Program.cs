using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park
{
    internal class Program
    {
        private struct Team
        {
            public int Katu;
            public int Hiki;
            public int hai;
            public int tensu;
            public int bangou;
        }
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<Team> teams = new List<Team>();
            
            for(int i=0;i<n;i++)
            {
                Team newTeam = new Team();
                string inputStr = Console.ReadLine();
                int katu=0, hiki=0, hai=0;
                if (inputStr != null)
                    for (int j = 0; j < inputStr.Length; j++)
                    {
                        if (inputStr[j] == 'D')
                        {
                            hiki += 1;
                        }
                        else if (inputStr[j] == 'W')
                        {
                            katu += 1;
                        }
                        else if (inputStr[j] == 'L')
                        {
                            hai += 1;
                        }
                       
                    }

                newTeam.Katu = katu;
                newTeam.Hiki = hiki;
                newTeam.hai = hai;
                newTeam.tensu = katu * 2 + hiki * 1;
                newTeam.bangou = i + 1;
                teams.Add(newTeam);
            }

            for(int i=0;i<n-1;i++)
            {
                for(int j=0;j<n-1-i;j++)
                {
                    if(teams[j].tensu>=teams[j+1].tensu)
                    {
                        Team empty;
                        empty = teams[j];
                        teams[j] = teams[j + 1];
                        teams[j + 1] = empty;
                    }
                }
            }

            Console.WriteLine(teams[n-1].bangou + " " + teams[n-1].tensu + " " + teams[n-1].Katu + " " + teams[n-1].Hiki + " " + teams[n-1].hai);
        }

        
    }
}
