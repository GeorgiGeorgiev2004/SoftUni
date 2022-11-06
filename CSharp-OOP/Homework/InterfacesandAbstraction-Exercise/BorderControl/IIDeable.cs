using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IIDeable
    {
        string ID { get; }
        public void CheckID(string id,string lastdigits);
    }
}
