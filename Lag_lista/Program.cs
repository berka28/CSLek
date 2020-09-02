using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lag_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _haveTeam;

            Console.Write("Do you have any favorite soccer team ( yes/no ) ");
            var _teamResponse = Console.ReadLine();

            switch (_teamResponse.ToLower())
            {
                case "yes":
                    _haveTeam = true;
                    break;

                case "no":
                    _haveTeam = false;
                    break;

                default:
                    _haveTeam = false;
                    break;
            }

            if (!_haveTeam)
                Console.WriteLine("Ok, well you should get at least one :)");
            
            else
            {
                Console.Write("Aha, that's awesome, how many favorite team(s) do you have? ");
                int _numberOfTeam = Convert.ToInt32(Console.ReadLine());

                var teams = new List<string>();

                if (_numberOfTeam == 1)
                {
                    Console.Write("What's your favorite team? ");
                    teams.Add(Console.ReadLine());

                    Console.WriteLine($"Ok, so your favorite team is {teams[0]} ");
                }
                else
                {
                    Console.Write("What are their names? Separate by comma( , ) ");
                    var _response = Console.ReadLine();

                    var names = _response.Replace(" ", "").Split(",");

                    foreach (var name in names)
                    {
                        teams.Add(name);
                    }

                    Console.Write("What team is your favorite team of them all? ");
                    var _favorite = Console.ReadLine();

                    var index = teams.FindIndex(x => x.Contains(_favorite));
                    teams.RemoveAt(index);
                    teams.Insert(0, _favorite);

                    Console.Write($"Ok, so your favorite teams are: ");
                    foreach(var team in teams)
                    {
                        Console.Write($"{team} ");
                    }
                }
            }
        }
    }
}
