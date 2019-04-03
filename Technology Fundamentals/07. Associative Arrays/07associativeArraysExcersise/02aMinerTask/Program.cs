using System;
using System.Collections.Generic;

namespace _02aMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int value = int.Parse(Console.ReadLine());


                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += value;
                    }
                    else
                    {
                        resources.Add(resource, value);
                    }
            }
            foreach (var resource in resources)
            {
                Console.WriteLine(resource.Key + " -> " + resource.Value);
            }
        }
    }
}
