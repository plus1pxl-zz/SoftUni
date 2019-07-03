using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07_SoftuniParty
{
    public class StartUp_07
    {
        static void Main(string[] args)
        {
            HashSet<string> guestsRegular = new HashSet<string>();
            HashSet<string> guestsVIP = new HashSet<string>();
            string input = string.Empty;

            while (input?.ToLower() != "end" && input?.ToLower() != "party")
            {
                input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^\d"))
                {
                    guestsVIP.Add(input);
                }
                else if (input?.ToLower() != "party")
                {
                    guestsRegular.Add(input);
                }

            }

            if (input?.ToLower() == "party")
            {
                while (input?.ToLower() != "end")
                {
                    input = Console.ReadLine();
                    if (Regex.IsMatch(input, @"^\d") && guestsVIP.Contains(input))
                    {
                        guestsVIP.Remove(input);
                    }
                    else if(guestsRegular.Contains(input))
                    {
                        guestsRegular.Remove(input);
                    }
                }
            }

            int guestsOnTheParty = guestsRegular.Count + guestsVIP.Count;

            Console.WriteLine(guestsOnTheParty);
            foreach (var guest in guestsVIP)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in guestsRegular)
            {
                Console.WriteLine(guest);
            }


        }
    }
}
