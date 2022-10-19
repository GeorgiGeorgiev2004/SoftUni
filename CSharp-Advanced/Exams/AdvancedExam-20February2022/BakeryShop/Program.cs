using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Water = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            var Flour = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            Queue<double> water = new Queue<double>();
            for (int i = 0; i < Water.Count; i++)
            {
                water.Enqueue(Water[i]);
                
            }
            Stack<double> flour = new Stack<double>();
            for (int i = 0; i < Flour.Count; i++)
            {
                flour.Push(Flour[i]);
            }
            Dictionary<string, int> Products = new Dictionary<string, int>();
            while (true)
            {
                if (water.Count==0||flour.Count==0)
                {
                    break;
                }
                double currFlour = flour.Peek();
                double currWater = water.Peek();
                double ratioFlour = (currFlour * 100) / (currFlour + currWater);
                ratioFlour =Math.Round(ratioFlour,0);
                double ratioWater = (currWater * 100) / (currFlour + currWater);
                ratioWater=Math.Round(ratioWater,0);
                if (ratioFlour==ratioWater)
                {
                    if (!Products.ContainsKey("Croissant"))
                    {
                        Products.Add("Croissant", 1);
                    }
                    else
                    {
                        Products["Croissant"]++;
                    }
                    flour.Pop();
                    water.Dequeue();
                }
                else if (ratioFlour == 60 && ratioWater == 40)
                {
                    if (!Products.ContainsKey("Muffin"))
                    {
                        Products.Add("Muffin", 1);
                    }
                    else
                    {
                        Products["Muffin"]++;
                    }
                    flour.Pop();
                    water.Dequeue();
                }
                else if (ratioFlour == 70 && ratioWater == 30)
                {
                    if (!Products.ContainsKey("Baguette"))
                    {
                        Products.Add("Baguette", 1);
                    }
                    else
                    {
                        Products["Baguette"]++;
                    }
                    flour.Pop();
                    water.Dequeue();
                }
                else if (ratioFlour == 80 && ratioWater == 20)
                {
                    if (!Products.ContainsKey("Bagel"))
                    {
                        Products.Add("Bagel", 1);
                    }
                    else
                    {
                        Products["Bagel"]++;
                    }
                    flour.Pop();
                    water.Dequeue();
                }
                else
                {
                    double leftover = currFlour - currWater;
                    if (!Products.ContainsKey("Croissant"))
                    {
                        Products.Add("Croissant", 1);
                    }
                    else
                    {
                        Products["Croissant"]++;
                    }
                    flour.Pop();
                    water.Dequeue();
                    flour.Push(leftover);
                }
            }
            foreach (var product in Products.OrderByDescending(x=>x.Value).ThenBy(s=>s.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
            if (water.Count>0)
            {
                Console.WriteLine("Water left: "+String.Join(", ",water));
            }
            else
            {
                Console.WriteLine("Water left: None");
            }
            if (flour.Count > 0)
            {
                Console.WriteLine("Flour left: " + String.Join(", ", flour));
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}
