using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Raiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> CollectionOfHeroes = new List<BaseHero>();
            while (CollectionOfHeroes.Count!=n)
            {
                string name = Console.ReadLine();
                string Class = Console.ReadLine();
                switch (Class)
                {
                    case "Druid":
                        Druid druid = new Druid(name, 80);
                        CollectionOfHeroes.Add(druid);
                        break;
                    case "Paladin":
                        Paladin paladin = new Paladin(name, 100);
                        CollectionOfHeroes.Add(paladin);
                        break;
                    case "Rogue":
                        Rogue rogue = new Rogue(name, 80);
                        CollectionOfHeroes.Add(rogue);
                        break;
                    case "Warrior":
                        Warrior warrior = new Warrior(name, 100);
                        CollectionOfHeroes.Add(warrior);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
            }
            int colectivepower = 0;
            foreach (BaseHero bh in CollectionOfHeroes)
            {
                colectivepower += bh.Power;
                Console.WriteLine(bh.CastAbility()); 
            }
            int monsterPower = int.Parse(Console.ReadLine());
            if (monsterPower<=colectivepower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}