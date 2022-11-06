using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot:IIDeable
    {
        public string Model{ get; set; }

        public string ID { get; private set; }

        public void CheckID(string id, string lastdigits)
        {
            throw new NotImplementedException();
        }
    }
}
