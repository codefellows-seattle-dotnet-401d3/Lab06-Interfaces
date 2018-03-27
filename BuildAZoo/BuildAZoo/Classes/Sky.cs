using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    class Sky
    {
        public string Name { get; set; }

        public void Flying(Interfaces.IFly a)
        {
            Console.WriteLine($"A {a.Name} is flying!");
        }
    }
}
