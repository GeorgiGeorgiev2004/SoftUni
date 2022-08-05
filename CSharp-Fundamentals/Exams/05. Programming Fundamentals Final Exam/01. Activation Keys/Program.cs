using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            var input = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (input[0] !="Generate")
            {

                switch (input[0])
                {
                    case "Contains":
                        var substring = input[1] ;
                        if (key.Contains(substring))
                        {
                            Console.WriteLine($"{key} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                       var str = key.ToCharArray();
                        if (input[1]=="Upper")
                        {
                            for (int i = int.Parse(input[2]); i < int.Parse(input[3]); i++)
                            {
                                str[i] = char.ToUpper(str[i]);
                            }
                            key = String.Join("", str);
                            Console.WriteLine(key);
                        }
                        else
                        {
                            for (int i = int.Parse(input[2]); i < int.Parse(input[3]); i++)
                            {
                                str[i] = char.ToLower(str[i]);
                            }
                            key = String.Join("", str);
                            Console.WriteLine(key);
                        }
                        break;
                    case "Slice":
                        StringBuilder sb = new StringBuilder();
                        var stri = key.ToCharArray();
                        for (int i = int.Parse(input[1]); i < int.Parse(input[2]); i++)
                        {
                            stri[i] = (char)0;
                        }
                        for (int i = 0; i < stri.Length; i++)
                        {
                            if (stri[i]!=(char)0)
                            {
                                sb.Append(stri[i]);
                            }
                        }
                        key = sb.ToString();
                        Console.WriteLine(key);
                        break;
                }

                input = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}