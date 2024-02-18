using System;
using System.Collections.Generic;

namespace HeroRecruitment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroInfo = new Dictionary<string, List<string>>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] currCommand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = currCommand[1];

                switch (currCommand[0])
                {
                    case "Enroll":
                        EnrollHero(heroInfo, heroName);
                        break;
                    case "Learn":
                        LearnSpell(heroInfo, heroName, currCommand[2]);
                        break;
                    case "Unlearn":
                        UnlearnSpell(heroInfo, heroName, currCommand[2]);
                        break;
                }
            }

            Console.WriteLine("Heroes:");
            foreach (var hero in heroInfo)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }

        static void EnrollHero(Dictionary<string, List<string>> heroInfo, string heroName)
        {
            if (!heroInfo.ContainsKey(heroName))
            {
                heroInfo.Add(heroName, new List<string>());
            }
            else
            {
                Console.WriteLine($"{heroName} is already enrolled.");
            }
        }

        static void LearnSpell(Dictionary<string, List<string>> heroInfo, string heroName, string spellName)
        {
            if (!heroInfo.ContainsKey(heroName))
            {
                Console.WriteLine($"{heroName} doesn't exist.");
            }
            else
            {
                if (heroInfo[heroName].Contains(spellName))
                {
                    Console.WriteLine($"{heroName} has already learnt {spellName}.");
                }
                else
                {
                    heroInfo[heroName].Add(spellName);
                }
            }
        }

        static void UnlearnSpell(Dictionary<string, List<string>> heroInfo, string heroName, string spellNameToUnlearn)
        {
            if (!heroInfo.ContainsKey(heroName))
            {
                Console.WriteLine($"{heroName} doesn't exist.");
            }
            else
            {
                if (!heroInfo[heroName].Contains(spellNameToUnlearn))
                {
                    Console.WriteLine($"{heroName} doesn't know {spellNameToUnlearn}.");
                }
                else
                {
                    heroInfo[heroName].Remove(spellNameToUnlearn);
                }
            }
        }
    }
}
