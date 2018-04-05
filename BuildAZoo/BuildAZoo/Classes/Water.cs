using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Water
    {
        public string Name { get; set; }

        public void Swim(Interfaces.ISwim a)
        {
            Console.WriteLine($"A {a.Name} is swimming");
        }
    }
}
