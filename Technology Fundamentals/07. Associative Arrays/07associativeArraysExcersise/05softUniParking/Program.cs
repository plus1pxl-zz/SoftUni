using System;
using System.Collections.Generic;
using System.Linq;

namespace _05softUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var registeredUsers = new Dictionary<string, string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                //•	"register {username} {licensePlateNumber}":
                string input = Console.ReadLine();
                string[] inputLine = input.Split().ToArray();
                string command = inputLine[0];
                string username = inputLine[1];
                
                if (command == "unregister")
                {
                    if (!registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
                else if (command == "register")
                {
                    string licensePlate = inputLine[2];
                    if (registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registeredUsers[username]}");
                    }
                    else
                    {
                        registeredUsers.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                }


            }
            foreach (var kvp in registeredUsers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
