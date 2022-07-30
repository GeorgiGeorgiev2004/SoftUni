using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<int>> dic = new Dictionary<string,List<int>>();
            for (int i = 0; i < n; i++)
            {
                var stats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                var list = new List<int> { int.Parse(stats[1]), int.Parse(stats[2]) };
                dic.Add(stats[0], list);
            }
            var com = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (com[0] !="End")
            {
                if (com[0] =="CastSpell")
                {
                    if (dic[com[1]][0] > int.Parse(com[2]))
                    {
                        int remainingmana = dic[com[1]][1] - int.Parse(com[2]);
                        dic[com[1]][1] = remainingmana;
                        Console.WriteLine($"{com[1]} has successfully cast {com[3]} and now has {remainingmana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{com[1]} does not have enough MP to cast {com[3]}!");
                    }
                }
                if (com[0] == "TakeDamage")
                {
                    int remaininghealth = dic[com[1]][0] - int.Parse(com[2]);
                    dic[com[1]][0] = remaininghealth;
                    if (remaininghealth>0)
                    {
                        Console.WriteLine($"{com[1]} was hit for {com[2]} HP by {com[3]} and now has {remaininghealth} HP left!");
                    }
                    else
                    {
                       dic.Remove(com[1]);
                        Console.WriteLine($"{com[1]} has been killed by {com[3]}!");
                    }
                }
                if (com[0] == "Recharge")
                {
                    int manaafterregen = dic[com[1]][1] + int.Parse(com[2]);
                    int regenedmana = int.Parse(com[2]);
                    if (manaafterregen>200)
                    {
                        regenedmana = 200 - dic[com[1]][1];
                        dic[com[1]][1] = 200;
                    }
                    else
                    {
                        dic[com[1]][1] = manaafterregen;
                    }
                    Console.WriteLine($"{com[1]} recharged for {regenedmana} MP!");
                }
                if (com[0] == "Heal")
                {
                    int healthafterregen = dic[com[1]][0] + int.Parse(com[2]);
                    int regenedhealth = int.Parse(com[2]);
                    if (healthafterregen > 100)
                    {
                        regenedhealth = 100 - dic[com[1]][0];
                        dic[com[1]][0] = 100;
                    }
                    else
                    {
                        dic[com[1]][0] = healthafterregen;
                    }
                    Console.WriteLine($"{com[1]} healed for {regenedhealth} HP!");
                }
                com = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}" +"\n"+ $"  HP: {item.Value[0]}" + "\n" +$"  MP: {item.Value[1]}");
            }
        }
    }
}