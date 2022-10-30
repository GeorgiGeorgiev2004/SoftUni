using System;
using System.Linq;
using System.Collections.Generic;
namespace EnergyDrinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var milsCofeine = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            var energyDrinks = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int StamatCafeine = 0;
            Stack<int> cafeine = new Stack<int>();
            foreach (var item in milsCofeine)
            {
                cafeine.Push(item);
            }
            Queue<int> EnergDrinks = new Queue<int>();
            foreach (var item in energyDrinks)
            {
                EnergDrinks.Enqueue(item);
            }
            while (true)
            {
                if ((EnergDrinks.Peek()*cafeine.Peek())+StamatCafeine<=300)
                {
                    StamatCafeine += EnergDrinks.Dequeue() * cafeine.Pop();
                }
                else
                {
                    if (StamatCafeine<30)
                    {
                    StamatCafeine = 0;
                    }
                    else
                    {
                     StamatCafeine -= 30;
                    }
                    cafeine.Pop();
                    int variable = EnergDrinks.Dequeue();
                    EnergDrinks.Enqueue(variable);
                }
                if (EnergDrinks.Count == 0 || cafeine.Count == 0)
                {
                    break;
                }
            }
            if (EnergDrinks.Count()>0)
            {
                Console.WriteLine($"Drinks left: { string.Join(", ",EnergDrinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }
            Console.WriteLine($"Stamat is going to sleep with { StamatCafeine } mg caffeine.");
        }
    }
}
