using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes.zoo
{
    class Duck : Bird, ISwim, IFly
    {
        new string Food { get; set; } = "bread crumbs"; 
        public Sleep DuckSleep { get; set; } = Sleep.night;
        public Size DuckSize { get; set; } = Size.small;
        new int Cute { get; set; } = 7;
        new int Noble { get; set; } = 4;

        string speak = "quack";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a duck.  I eat {Food}.  I'm {DuckSize} and I say {speak}."); ;
        }

        public string CanSwim()
        {
            return "I can swim!";
        }

        public string CanFly()
        {
            return "I can fly!";
        }
    }

}
