using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex rgx = new Regex(@"\@#+(?<body>[A-Z][^_\W]{4,}[A-Z])\@#+");
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                string productgroup = "00";
                if (rgx.IsMatch(barcode))
                {
                    StringBuilder sb = new StringBuilder();
                    var charr = barcode.ToCharArray();
                    foreach (char item in charr)
                    {
                        if (char.IsDigit(item))
                        {
                            sb.Append(item);
                        }
                    }
                    if (sb.Length>0)
                    {
                        productgroup = sb.ToString();
                    }
                    Console.WriteLine($"Product group: {productgroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode"); 
                }
            }
        }
    }
}