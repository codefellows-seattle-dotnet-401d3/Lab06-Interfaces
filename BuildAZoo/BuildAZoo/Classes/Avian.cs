using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    abstract class Avian : Animal
    {
        public virtual bool HasWings { get; set; } = true;

        public abstract bool CanFly();
        public virtual string Caws()
        {
            return "Caw";
        }
    }
}
