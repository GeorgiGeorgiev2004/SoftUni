using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{  
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj) => obj != null;
    }
}
