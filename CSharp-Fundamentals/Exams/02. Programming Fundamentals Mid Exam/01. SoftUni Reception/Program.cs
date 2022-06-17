using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int worker1 = int.Parse(Console.ReadLine());
            int worker2 = int.Parse(Console.ReadLine());
            int worker3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int hours = Hours(worker1, worker2, worker3, students);
            Console.WriteLine($"Time needed: {hours}h.");
        }
        static int Hours(int a,int b,int c,int students)
        {
            int workdone = a + b + c;
            int workhours = 0;
            int breaks= 0;
            while (workdone < students)
            {
                workhours++;
                if (workhours % 3 == 0)
                {
                    breaks++;
                }
                students = students - workdone;
            }
            if (students>0)
            {
                workhours++;
            }
            return workhours+breaks;
        }
    }
}
