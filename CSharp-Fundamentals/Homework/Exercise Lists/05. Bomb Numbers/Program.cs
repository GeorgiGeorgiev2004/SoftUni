using System;
using System.Linq;
using System.Collections.Generic;
namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int combined = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]==bomb[0])
                {
                    numbers[i] = 0;
                    for (int j = 1; j <= bomb[1]; j++)
                    {
                        if (i+j>numbers.Count-1)
                        {
                            break;
                        } else numbers[i+j]=0;
                    }
                    for (int j = 1; j <= bomb[1]; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else numbers[i - j] = 0;
                    }
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                combined += numbers[i];
            }
            Console.WriteLine(combined);
        }
    }
}
