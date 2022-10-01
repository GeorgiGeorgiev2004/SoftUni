using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
namespace EvenLines
{
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            List<string> lines = new List<string>();
            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                while (!reader.EndOfStream)
                {
                    lines.Add(reader.ReadLine());
                }
            }
            List<string> lines2 = new List<string>();   
            for (int i = 0; i < lines.Count; i++)
            {
                if (i%2==0)
                {
                    List<string> words = lines[i].Split(' ').ToList();
                    for (int j = 0; j < words.Count(); j++)
                    {
                        var charsinword = words[j].ToCharArray();
                        for (int x = 0; x < charsinword.Count(); x++)
                        {
                            if (char.IsPunctuation(charsinword[x]))
                            {
                                if (charsinword[x]=='\'')
                                {
                                    continue;
                                }
                                charsinword[x] = '@';
                                words[j] = String.Join("",charsinword);
                            }
                        }
                    }
                    lines2.Add(string.Join(" ", words)); 
                }
            }
            for (int i = 0; i < lines2.Count; i++)
            {
                var nz = lines2[i].Split().ToArray();
                Array.Reverse(nz);
                sb.AppendLine(String.Join(' ',nz));
            }
            return sb.ToString().TrimEnd();
            throw new NotImplementedException();
        }
    }
}