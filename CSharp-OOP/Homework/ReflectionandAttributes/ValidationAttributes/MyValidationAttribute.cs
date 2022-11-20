using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ValidationAttributes
{
    public abstract class MyValidationAttribute:Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
