using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var materials = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);

            int quantity = 0;
            string resource = "";

            bool valanyrBoo = false;
            bool shadowmourneBoo = false;
            bool dragonwrathBoo = false;

            while (valanyrBoo == false && shadowmourneBoo == false && dragonwrathBoo == false)
            {
                string[] input = Console.ReadLine().ToLower().Split(" ").ToArray();
                for (int i = 0; i < input.Length; i += 2)
                {
                    resource = input[i + 1];
                    quantity = int.Parse(input[i]);
                    if (resource == "shards" || resource == "fragments" || resource == "motes")
                    {
                        if (materials.ContainsKey(resource))
                        {
                            materials[resource] += quantity;
                        }
                        else
                        {
                            materials[resource] = quantity;
                        }
                        if (resource == "shards" & materials[resource] >= 250)
                        {
                            shadowmourneBoo = true;
                            materials[resource] -= 250;
                            break;
                        }
                        else if (resource == "fragments" & materials[resource] >= 250)
                        {
                            valanyrBoo = true;
                            materials[resource] -= 250;
                            break;
                        }
                        else if (resource == "motes" & materials[resource] >= 250)
                        {
                            dragonwrathBoo = true;
                            materials[resource] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(resource))
                        {
                            junk[resource] += quantity;
                        }
                        else
                        {
                            junk[resource] = quantity;
                        }
                    }
                }
            }

            if (shadowmourneBoo == true)
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            if (valanyrBoo == true)
            {
                Console.WriteLine("Valanyr obtained!");
            }
            if (dragonwrathBoo == true)
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            foreach (var material in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var material in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
