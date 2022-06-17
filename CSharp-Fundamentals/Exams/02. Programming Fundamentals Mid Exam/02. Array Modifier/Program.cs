using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> input = Console.ReadLine().Split(' ').ToList();
            while (input[0]!="end")
            {
                if (input[0]=="swap")
                {
                    int x = int.Parse(input[1]);
                    int s = int.Parse(input[2]);
                    int m = arr[x];
                    arr[x] = arr[s];
                    arr[s] = m;
                }
                if (input[0] == "multiply")
                {
                    int x = int.Parse(input[1]);
                    int s = int.Parse(input[2]);
                    arr[x] *= arr[s];
                }
                if (input[0] == "decrease")
                {
                    for (int i = 0; i < arr.Count; i++)
                    {
                        arr[i]--;
                    }
                }
                input = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(", ",arr));
        }
    }
}
