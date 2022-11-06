using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface IPersonOrPet
    {
        string Name { get; }
        string Birthdate { get; }
    }
}
