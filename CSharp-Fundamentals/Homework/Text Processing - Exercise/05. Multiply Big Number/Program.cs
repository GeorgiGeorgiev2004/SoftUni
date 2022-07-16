using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int remaining = 0;
            StringBuilder sb = new StringBuilder();
            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = a.Length-1; i >= 0; i--)
            {
                char charray = a[i];
                int elementToNum = int.Parse(charray.ToString());
                int res = (num * elementToNum+remaining);
                sb.Append(res%10);
                remaining=res/10;
            }
            if (remaining!=0)
            {
                sb.Append(remaining);
            }
            StringBuilder revsb = new StringBuilder();
            for (int i = sb.Length-1; i >=0 ; i--)
            {
                revsb.Append(sb[i]);
            }
            Console.WriteLine(revsb);
        }
    }
}