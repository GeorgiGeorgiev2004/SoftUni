using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._String_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var com = Console.ReadLine().Split(" ").ToList();
            while (com[0]!="End")
            {
                switch (com[0])
                {
                    case "Translate":
                        char repch = char.Parse(com[1]);
                        char replacement = char.Parse(com[2]);
                        var chararr = str.ToCharArray();
                        for (int i = 0; i < chararr.Length; i++)
                        {
                            if (chararr[i]==repch)
                            {
                                chararr[i] = replacement;
                            }
                        }
                        str=String.Join("",chararr);
                        Console.WriteLine(str);
                        break;
                    case "Includes":
                        bool contains = false;
                        if (str.Contains(com[1]))
                        {
                            contains = true;
                        }
                        Console.WriteLine(contains);
                        break;
                    case "Start":
                        string substr = com[1];
                        var subchar = substr.ToCharArray();
                        var strchar = str.ToCharArray();
                        bool valid = true;
                        for (int i = 0; i < substr.Length; i++)
                        {
                            if (subchar[i] != strchar[i])
                            {
                                valid = false;
                            }
                        }
                        Console.WriteLine(valid);
                        break;
                    case "Lowercase":
                        var strchar1 = str.ToCharArray();
                        for (int i = 0; i < strchar1.Length; i++)
                        {
                            strchar1[i] = char.ToLower(strchar1[i]);
                        }
                        str = String.Join("", strchar1);
                        Console.WriteLine(str);
                        break;
                    case "FindIndex":
                        char givenchar = char.Parse(com[1]);
                        var strchar2 = str.ToCharArray();
                        var list = strchar2.ToList();
                        int index = list.LastIndexOf(givenchar);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        int startindex = int.Parse(com[1]);
                        int count = int.Parse(com[2]);
                        str = str.Remove(startindex, count);
                        Console.WriteLine(str);
                            break;
                    default:
                        break;

                }
                com = Console.ReadLine().Split(" ").ToList();
            }
        }
    }
}