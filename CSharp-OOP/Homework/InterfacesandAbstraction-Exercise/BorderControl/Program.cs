namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection.Metadata.Ecma335;

    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split().ToList();
            List<string> IDs = new List<string>();
            List<string> FakeIDs = new List<string>();
            while (command[0]!="End")
            {
                if (command.Count() ==2)
                {
                    string id= command[1];
                    IDs.Add(id);
                }
                else if (command.Count() == 3)
                {
                    string id = command[2];
                    IDs.Add(id);
                }
                command = Console.ReadLine().Split().ToList();
            }
            string num = Console.ReadLine();
            var array = num.ToArray();
            Array.Reverse(array);
            bool IsOk=false;
            for (int i = 0; i < IDs.Count; i++)
            {
                var array1 = IDs[i].ToArray();
                Array.Reverse(array1);
                for (int f = 0; f < num.Length; f++)
                {
                    if (array1[f] != array[f])
                    {
                        IsOk=true;
                        break; 
                    }
                }
                if (IsOk)
                {
                    IsOk=false;
                    continue;   
                }
                FakeIDs.Add(IDs[i]);
            }
            foreach (var item in FakeIDs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
