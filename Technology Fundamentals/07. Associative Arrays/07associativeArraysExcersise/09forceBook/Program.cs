using System;
using System.Collections.Generic;
using System.Linq;

namespace _09forceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var sides = new Dictionary<string, List<string>>();
            string inputLine = Console.ReadLine();

            while (inputLine != "Lumpawaroo")
            {
                if (inputLine.Contains(" | "))
                {
                    string[] input = inputLine.Split(" | ");
                    string side = input[0];
                    string user = input[1];
                    string sideContainingTheUser = CheckIfUserExists(user, sides);
                    if (sideContainingTheUser == "")
                    {
                        AddUserToSide(side, user, sides);
                    }
                    
                }
                else if (inputLine.Contains(" -> "))
                {
                    string[] input = inputLine.Split(" -> ");
                    string side = input[1];
                    string user = input[0];
                    string sideContainingTheUser = CheckIfUserExists(user, sides);
                    if (sideContainingTheUser == "")
                    {
                        AddUserToSide(side, user, sides);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        sides[sideContainingTheUser].Remove(user);
                        sides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }

                inputLine = Console.ReadLine();
            }
            
           // foreach (var kvp in sides.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            foreach (var kvp in sides.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                if (kvp.Value.Count() > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count()}");
                    foreach (var user in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }

        private static void AddUserToSide(string side, string user, Dictionary<string, List<string>> sides)
        {
            if (sides.ContainsKey(side))
            {
                sides[side].Add(user);
            }
            else
            {
                sides.Add(side, new List<string>());
                sides[side].Add(user);
            }
        }

        private static string CheckIfUserExists(string user, Dictionary<string, List<string>> sides)
        {
            string sideContainingTheUser = "";
            foreach (var kvp in sides)
            {
                foreach (var usr in kvp.Value)
                {
                    if (usr.Equals(user))
                    {
                        sideContainingTheUser =  kvp.Key;
                        break;
                    }
                }
            }
            return sideContainingTheUser;
        }
    }
}
