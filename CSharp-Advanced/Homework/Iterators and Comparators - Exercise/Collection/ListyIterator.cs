using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> :IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void PrintAll() 
        {
            if (Items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.Append($"{item} ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
