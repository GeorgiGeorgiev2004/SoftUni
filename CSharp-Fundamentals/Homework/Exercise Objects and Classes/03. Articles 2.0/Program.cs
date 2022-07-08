using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumofCom = int.Parse(Console.ReadLine());
            List<string> fin = new List<string>();
            for (int i = 0; i < NumofCom; i++)
            {
                List<string> list= Console.ReadLine().Split(", ").ToList();
                Article art = new Article(list[0], list[1], list[2]);
                fin.Add(art.ToString());
            }
            for (int i = 0; i < NumofCom; i++)
            {
                Console.WriteLine(fin[i]);
            }
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
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
