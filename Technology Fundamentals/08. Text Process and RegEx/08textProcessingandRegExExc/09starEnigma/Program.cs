using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _09starEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> planetsDestroyed = new List<string>();
            List<string> planetsAttacked = new List<string>();
            //Regex pattern = new Regex(@"@(?'planet'[A-Z]+[a-z]+)(?'separator'[^@\-!:>]*):\2*(?'population'\d+)\2*!\2*(?'command'A|D)\2*!\2*->(?'soldiers'\d+)");
            Regex pattern = new Regex(@"@(?'planet'[A-Za-z]+)([^@:!\->]*):(?'population'[0-9]+)([^@:!\->]*)!(?'command'(A|D))!([^@:!\->]*)->(?'soldiers'[0-9]+)");


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                List<char> decryptedCharacters = new List<char>();
                int key = CalculateKey(input);
                string decrypted = "";

                //compile decrypted input
                foreach (var c in input)
                {
                    char newChar = (Char)(Convert.ToUInt16(c) - key);
                    decryptedCharacters.Add(newChar);
                }
                foreach (var item in decryptedCharacters)
                {
                    decrypted += item;
                }

               // check for matches
                Match match = pattern.Match(decrypted);

                // if matches r found process
                if (match.Success == true)
                {
                    string planetName = match.Groups["planet"].Value;
                    int planetPopulation = int.Parse(match.Groups["population"].Value);
                    string command = match.Groups["command"].Value;
                    int soldiers = int.Parse(match.Groups["soldiers"].Value);

                    if (command == "A")
                    {
                        planetsAttacked.Add(planetName);
                    }
                    else if (command == "D")
                    {
                        planetsDestroyed.Add(planetName);
                    }
                }
            }

            planetsAttacked.Sort();
            planetsDestroyed.Sort();
            Console.WriteLine($"Attacked planets: {planetsAttacked.Count}");
            foreach (var planet in planetsAttacked)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {planetsDestroyed.Count}");
            foreach (var planet in planetsDestroyed)
            {
                Console.WriteLine($"-> {planet}");
            }

        }

        private static int CalculateKey(string input)
        {
            int counter = 0;
            foreach (var c in input.ToLower())
            {
                if (c == 's'
                    || c == 't'
                    || c == 'a'
                    || c == 'r')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
