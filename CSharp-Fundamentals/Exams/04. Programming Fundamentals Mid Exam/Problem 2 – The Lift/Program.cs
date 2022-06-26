using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_2___The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int numpass = int.Parse(Console.ReadLine());
            List<int> liftspace = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < liftspace.Count; i++)
            {
                while (liftspace[i]<4&&numpass>0)
                {
                    numpass--;
                    liftspace[i]++;
                }
            }
            if (numpass > 0)
            {
                Console.WriteLine($"There isn't enough space! {numpass} people in a queue!");
                Console.WriteLine(string.Join(" ", liftspace));
            }
            else if(liftspace[liftspace.Count-1]<4)
            { 
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ",liftspace));
            }
            else
            {
                Console.WriteLine(string.Join(" ", liftspace));
            }
        }
    }
}
