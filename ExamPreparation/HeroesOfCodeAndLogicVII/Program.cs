using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Hero
{
    public string Name;
    public int HP;
    public int MP;

    public Hero(string name, int hp, int mp)
    {
        Name = name;
        Heal(hp);
        Recharge(mp);
    }

    public int Heal(int hp)
    {
        int recoveredHP = Math.Min(hp, 100 - HP);
        HP += recoveredHP;
        return recoveredHP;
    }

    public int Recharge(int mp)
    {
        int recoveredMP = Math.Min(mp, 200 - MP);
        MP += recoveredMP;
        return recoveredMP;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Name);
        sb.AppendLine($"  HP: {HP}");
        sb.AppendLine($"  MP: {MP}");
        return sb.ToString();
    }
}

class Program
{
    static List<Hero> party = new List<Hero>();

    static void Main()
    {
        int heroesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < heroesCount; i++)
        {
            string[] heroArgs = Console.ReadLine().Split();
            Hero h = new Hero(heroArgs[0], int.Parse(heroArgs[1]), int.Parse(heroArgs[2]));
            party.Add(h);
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split(" - ");

            switch (arguments[0])
            {
                case "CastSpell":
                    CastSpell(arguments[1], int.Parse(arguments[2]), arguments[3]);
                    break;
                case "TakeDamage":
                    TakeDamage(arguments[1], int.Parse(arguments[2]), arguments[3]);
                    break;
                case "Recharge":
                    Recharge(arguments[1], int.Parse(arguments[2]));
                    break;
                case "Heal":
                    Heal(arguments[1], int.Parse(arguments[2]));
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }

        party.ForEach(h => Console.Write(h));
    }

    static void CastSpell(string heroName, int neededMP, string spellName)
    {
        Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
        if (foundHero != null && foundHero.MP >= neededMP)
        {
            foundHero.MP -= neededMP;
            Console.WriteLine($"{foundHero.Name} has successfully cast {spellName} and now has {foundHero.MP} MP!");
        }
        else
        {
            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
        }
    }

    private static void TakeDamage(string heroName, int damage, string attacker)
    {
        Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
        if (foundHero != null)
        {
            foundHero.HP -= damage;
        }

        if (foundHero != null && foundHero.HP > 0)
        {
            Console.WriteLine($"{foundHero.Name} was hit for {damage} HP by {attacker} and now has {foundHero.HP} HP left!");
        }
        else if (foundHero != null)
        {
            party.Remove(foundHero);
            Console.WriteLine($"{foundHero.Name} has been killed by {attacker}!");
        }
        else
        {
            Console.WriteLine($"Hero with name {heroName} not found!");
        }
    }

    private static void Recharge(string heroName, int mp)
    {
        Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
        if (foundHero != null)
        {
            int recovered = foundHero.Recharge(mp);
            Console.WriteLine($"{foundHero.Name} recharged for {recovered} MP!");
        }
        else
        {
            Console.WriteLine($"Hero with name {heroName} not found!");
        }
    }

    private static void Heal(string heroName, int hp)
    {
        Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);
        if (foundHero != null)
        {
            int recovered = foundHero.Heal(hp);
            Console.WriteLine($"{foundHero.Name} healed for {recovered} HP!");
        }
        else
        {
            Console.WriteLine($"Hero with name {heroName} not found!");
        }
    }
}
