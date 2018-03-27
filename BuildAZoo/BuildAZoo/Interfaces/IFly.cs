using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    interface IFly
    {
        string Name { get; set; }

        string Flying();
    }
}
