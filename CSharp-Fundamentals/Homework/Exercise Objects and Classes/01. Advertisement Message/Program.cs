using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] Events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int ammount = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < ammount; i++)
            {
                Console.WriteLine($"{Phrases[rnd.Next(Phrases.Length)]} {Events[rnd.Next(Events.Length)]} {Authors[rnd.Next(Authors.Length)]} - {Cities[rnd.Next(Cities.Length)]}");
            }
        }
    }
}
