using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            int NumofCom = int.Parse(Console.ReadLine());
            Article art = new Article(list[0], list[1], list[2]);
            for (int i = 0; i < NumofCom; i++)
            {
                List<string> command = Console.ReadLine().Split(": ").ToList();
                switch (command[0])
                {
                    case "Edit": art.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        art.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        art.Rename(command[1]);
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(art.ToString());
        }
    }
    class Article 
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Rename(string title) => Title = title;
        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
