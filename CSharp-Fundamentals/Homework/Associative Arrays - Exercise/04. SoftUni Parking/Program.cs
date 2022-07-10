using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> Spots = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input[0]=="register")
                {
                    var user = input[1];
                    var licenseplate = input[2];
                    if (Spots.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseplate}");
                    }
                    else
                    {
                        Spots.Add(user, licenseplate);
                        Console.WriteLine($"{user} registered {licenseplate} successfully");
                    }
                }
                else if (input[0] == "unregister")
                {
                    var user = input[1];
                    if (!Spots.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Spots.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }
            foreach (var item in Spots)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}