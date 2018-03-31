using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes.zoo
{
    class Whale : Mammal, ISwim
    {
        new string Food { get; set; } = "krill";
        public Sleep WhaleSleep { get; set; } = Sleep.diurnal;
        public Size WhaleSize { get; set; } = Size.huge;
        new int Cute { get; set; } = 1;
        new int Noble { get; set; } = 10;

        string speak = "oooooooooooooooo";

        public override void Speak()
        {
            Console.WriteLine($"Hi, I'm a whale.  I eat {Food}.  I'm {WhaleSize} and I say {speak}.");
        }

        public override void CleanUp()
        {
            Console.WriteLine("The ocean is my toilet.");
        }

        public override void Bury()
        {
            Console.WriteLine("Burial at sea.");            ;
        }

        string ISwim.CanSwim()
        {
            return "I can swim!";
        }
    }
}
