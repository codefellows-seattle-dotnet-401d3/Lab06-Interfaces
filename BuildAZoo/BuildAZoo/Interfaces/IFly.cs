using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    public interface IFly
    {
        string Name { get; set; }

        string Flying();
    }
}
