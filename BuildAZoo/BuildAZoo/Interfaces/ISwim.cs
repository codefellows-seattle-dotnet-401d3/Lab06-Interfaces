using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    public interface ISwim
    {
        string Name { get; set; }

        string Swim();
    }
}
