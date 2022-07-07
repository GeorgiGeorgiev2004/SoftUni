using System;

namespace _04._Password_Validator
{
    class Program
    {
        static bool Validation1(string a)
        {
            if (a.Length>=6&&a.Length<=10)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        static bool Validation2(string a)
        {
            char[] arr = a.ToCharArray();
            bool trueorfalse = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((char)arr[i]>=65 && (char)arr[i] <= 90)
                {
                    trueorfalse = true;
                }
                else if((char)arr[i] >= 97 && (char)arr[i] <= 122)
                {
                    trueorfalse = true;
                }
                else if ((char)arr[i] >= 48 && (char)arr[i] <= 57)
                {
                    trueorfalse = true;
                }
                else
                {
                    return false;
                }
            }
            return trueorfalse;
        }
        static bool Validation3(string a)
        {
            char[] arr = a.ToCharArray();
            char[] nums = "0123456789".ToCharArray();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (arr[i]==nums[j])
                    {
                        counter++;
                    }
                }
            }
            if (counter<2)
            {
                return false;
            }
            return true;
        }
        

        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            if (Validation1(a) && Validation2(a) && Validation3(a))
            {
                Console.WriteLine("Password is valid");
            }
            if (Validation1(a) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (Validation2(a) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (Validation3(a) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}
