using System;

namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] drinkTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] numbersTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string, string> nameAddress = new Tuple<string, string, string>
            {
                Item1 = $"{personTokens[0]} {personTokens[1]}",
                Item2 = personTokens[2],
                Item3 = personTokens[3],
            };
            Tuple<string, int, bool> nameBeer = new Tuple<string, int, bool>
            {
                Item1 = drinkTokens[0],
                Item2 = int.Parse(drinkTokens[1]),
                Item3 = drinkTokens[2] == "drunk",
            };
            Tuple<string, double, string> numbers = new Tuple<string, double, string>
            {
                Item1 = numbersTokens[0],
                Item2 = double.Parse(numbersTokens[1]),
                Item3 = numbersTokens[2]
            };

            Console.WriteLine(nameAddress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(numbers);
        }
    }
}
