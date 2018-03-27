using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    abstract class Mammal : Animal
    {
        public abstract string FurColor { get; set; }
        public abstract bool HasHorns { get; set; }

        public virtual bool Roars()
        {
            return false;
        }

        public abstract int HaveBabies();
    }
}
