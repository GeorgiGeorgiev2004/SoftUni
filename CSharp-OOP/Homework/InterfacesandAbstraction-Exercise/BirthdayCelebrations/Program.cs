using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split().ToList();
            List<string> Bdays = new List<string>();
            List<string> MatchingBdays = new List<string>();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Citizen":
                        string name = command[1];
                        int age = int.Parse(command[2]);
                        string id = command[3];
                        string birthdate = command[4];
                        Bdays.Add(birthdate);
                        break;
                    case "Pet":
                        string namePet = command[1];
                        string birthdatePet = command[2];
                        Bdays.Add(birthdatePet);
                        break;
                    case "Robot":
                        command = Console.ReadLine().Split().ToList();
                        continue;
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split().ToList();
            }
            string year = Console.ReadLine();
            var array = year.ToArray();
            Array.Reverse(array);
            bool IsOk = false;
            for (int i = 0; i < Bdays.Count; i++)
            {
                var array1 = Bdays[i].ToArray();
                Array.Reverse(array1);
                for (int f = 0; f < year.Length; f++)
                {
                    if (array1[f] != array[f])
                    {
                        IsOk = true;
                        break;
                    }
                }
                if (IsOk)
                {
                    IsOk = false;
                    continue;
                }
                MatchingBdays.Add(Bdays[i]);
            }
            foreach (var item in MatchingBdays)
            {
                Console.WriteLine(item);
            }
        }
    }
}
