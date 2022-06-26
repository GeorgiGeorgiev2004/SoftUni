using System;

namespace Problem_1___Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            float food = float.Parse(Console.ReadLine())*1000;
            float hay = float.Parse(Console.ReadLine()) * 1000;
            float cover = float.Parse(Console.ReadLine()) * 1000;
            float weight = float.Parse(Console.ReadLine()) * 1000;
            int counterdays1 = 0;
            int counterdays2 = 0;
            for (int i = 0; i < 30; i++)
            {
                counterdays1++;
                counterdays2++;
                food -= 300;     
                if (counterdays1 == 2)
                {
                    counterdays1 = 0;
                    float neededhay = food * 5 / 100;
                    hay -= neededhay;
                }
                if (counterdays2 == 3)
                {
                    counterdays2 = 0;
                    float neededcover = weight /3;
                    cover -= neededcover;
                }
                if (food<=0||hay<=0||cover<=0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(food / 1000).ToString("F2")}, Hay: {(hay / 1000).ToString("F2")}, Cover: {(cover/1000).ToString("F2")}.");
        }
    }
}
