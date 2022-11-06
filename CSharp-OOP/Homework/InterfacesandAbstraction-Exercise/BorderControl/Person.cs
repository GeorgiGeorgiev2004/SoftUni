using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Person:IIDeable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }

        public void CheckID(string id, string lastdigits)
        {
            
        }
    }
}
