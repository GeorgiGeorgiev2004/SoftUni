using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
namespace LineNumbers
{
    
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            List<string> a = File.ReadAllLines(inputFilePath).ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < a.Count; i++)
            {
                int countpun = 0;
                int countlet = 0;
                foreach (var ch in a[i])
                {
                    if (char.IsLetter(ch))
                    {
                        countlet++;
                    }
                    else if (char.IsPunctuation(ch))
                    {
                        countpun++;
                    }
                }
                sb.AppendLine($"Line {i + 1}: " + a[i] + $" ({countlet})({countpun})");
            }
            File.WriteAllText(outputFilePath, sb.ToString().TrimEnd());
            throw new NotImplementedException();
        }
    }
}
