using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes.zoo
{
    class Bat :Mammal, IFly
    {
        
        new string Food { get; set; } = "bugs";
        public Sleep BatSleep { get; set; } = Sleep.day;
        public Size BatSize { get; set; } = Size.small;
        new int Cute { get; set; } = 2;
        new int Noble { get; set; } = 0;

        string speak = "click, click";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a bat.  I eat {Food}.  I'm {BatSize} and I say {speak}.");
        }

        public override void CleanUp()
        {
            Console.WriteLine("The same as a bird, but worse.");
        }

        public override void Bury()
        {
            Console.WriteLine("Vampires are already undead.");
        }

        public string CanFly()
        {
            return "I can fly!";
        }
    }
}
