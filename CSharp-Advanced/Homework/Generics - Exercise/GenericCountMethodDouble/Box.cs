using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable
    {
        public Box()
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }
        public void Switch(int a, int b)
        {
            T x;
            x = Items[a];
            Items[a] = Items[b];
            Items[b] = x;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
        public int Count(T x)
        {
            int count = 0;

            foreach (var item in Items)
            {
                if (item.CompareTo(x) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
