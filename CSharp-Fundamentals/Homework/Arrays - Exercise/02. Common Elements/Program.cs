using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();
            int len = 0;
            if (arr1.Length>arr2.Length)
            {
                len = arr2.Length;
            }
            len = arr1.Length;
            string[] combinedArr = new string[len];
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[j]==arr2[i])
                    {
                       combinedArr[i]= arr2[i];
                        break;
                    }
                }
            }
            for (int i = 0; i < combinedArr.Length; i++)
            {
                if (combinedArr[i] != null)
                {
                Console.Write(combinedArr[i]+" ");
                }
            }
        }
    }
}
