using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private int counter;
        public ListyIterator(List<T> items)
        {
            Items = items;
        }

        public List<T> Items { get; set; }
        public bool Move()
        {
            if (counter < Items.Count - 1)
            {
                counter++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return counter < Items.Count - 1;
        }

        public void Print()
        {
            if (Items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(Items[counter]);
        }
    }
}
