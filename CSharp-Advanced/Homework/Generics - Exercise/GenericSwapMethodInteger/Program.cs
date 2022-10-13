using System;
using System.Linq;
namespace GenericSwapMethodInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                box.Items.Add(int.Parse(Console.ReadLine()));
            }
            int[] swapers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Switch(swapers[0], swapers[1]);
            Console.WriteLine(box.ToString());
        }
    }
}
