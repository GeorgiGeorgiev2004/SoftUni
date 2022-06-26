using System;

namespace _01._The_Biscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numbiscperw = int.Parse(Console.ReadLine());
            int Workers = int.Parse(Console.ReadLine());
            int EnemyBisc = int.Parse(Console.ReadLine());
            int counter = 0;
            int workdone = Numbiscperw * Workers;
            double producedbics = 0;
            for (int i = 0; i < 30; i++)
            { 
                if (counter%3==0)
                {
                    producedbics += Math.Floor( workdone * 0.75);
                    counter = 0;
                }
                else
                {
                    producedbics += workdone;
                }
                counter++;
            }
            Console.WriteLine($"You have produced {producedbics} biscuits for the past month.");
            double perscentdiff = 0;
            if (EnemyBisc<producedbics)
            {
                perscentdiff = (producedbics - EnemyBisc) / EnemyBisc*100;
                Console.WriteLine($"You produce {perscentdiff:f2} percent more biscuits.");
            }
            else
            {
                perscentdiff = (EnemyBisc - producedbics) / EnemyBisc * 100;
                Console.WriteLine($"You produce {perscentdiff:f2} percent less biscuits.");
            }
        }
       
    }
}
