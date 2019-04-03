using System;
using System.Collections.Generic;
using System.Linq;

namespace _03legendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            var keyMaterials = new Dictionary<string, int>();
            keyMaterials["fragments"] = 0;
            keyMaterials["shards"] = 0;
            keyMaterials["motes"] = 0;

            var junkMaterials = new Dictionary<string, int>();
            bool itemObtained = false;

                while (itemObtained == false)
                {
                    var tokens = Console.ReadLine().ToLower().Split().ToArray();

                    for (int i = 0; i < tokens.Length; i+=2)
                    {
                        string type = tokens[i + 1];
                        int quantity = int.Parse(tokens[i]);
                        if (keyMaterials.ContainsKey(type))
                        {
                            keyMaterials[type] += quantity;
                            if (keyMaterials[type] >= 250)
                            {
                                keyMaterials[type] -= 250;
                                IdentifyLegendaryItem(type);
                                itemObtained = true;
                                break;
                            }
                        }
                        else if(junkMaterials.ContainsKey(type))
                        {
                            junkMaterials[type] += quantity; 
                        }
                        else
                        {
                            junkMaterials.Add(type, quantity);
                        }
                    }
                }

            foreach (var kvp in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }

        private static void IdentifyLegendaryItem(string type)
        {
            if (type == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (type == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (type == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
        }
    }
}
