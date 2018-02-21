using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gem = 0;
            long cash = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long broika = long.Parse(safe[i + 1]);

                string type = string.Empty;

                if (name.Length == 3)
                {
                    type = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    type = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    type = "Gold";
                }

                if (type == "")
                {
                    continue;
                }
                else if (input < bag.Values.Select(x => x.Values.Sum()).Sum() + broika)
                {
                    continue;
                }

                switch (type)
                {
                    case "Gem":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (broika > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + broika > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (broika > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + broika > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(type))
                {
                    bag[type] = new Dictionary<string, long>();
                }

                if (!bag[type].ContainsKey(name))
                {
                    bag[type][name] = 0;
                }

                bag[type][name] += broika;
                if (type == "Gold")
                {
                    gold += broika;
                }
                else if (type == "Gem")
                {
                    gem += broika;
                }
                else if (type == "Cash")
                {
                    cash += broika;
                }
            }

            PrintResults(bag);
        }

        private static void PrintResults(Dictionary<string, Dictionary<string, long>> bag)
        {
            foreach (var typeInbag in bag)
            {
                Console.WriteLine($"<{typeInbag.Key}> ${typeInbag.Value.Values.Sum()}");
                foreach (var item in typeInbag.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }
        }
    }
}