using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    abstract class Reptile : Animal
    {
        public abstract bool LooksSlimey { get; set; }

        public abstract bool Slither();

        public abstract bool LayEggs();
    }
}
