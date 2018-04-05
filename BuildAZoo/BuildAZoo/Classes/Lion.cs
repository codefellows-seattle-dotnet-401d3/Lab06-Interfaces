using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Lion : Mammal, Interfaces.ISwim
    {
        public override int NumberOfLegs { get; set; } = 4;
        public override bool Carnivore { get; set; } = true;
        public override string FurColor { get; set; } = "yellow";
        public override bool HasHorns { get; set; } = false;
        public string Name { get; set; } = "lion";

        public override string Eat()
        {
            return "Eating a steak";
        }

        public override string Sleep()
        {
            return "ZZZZ slight growl ZZZZ";
        }

        public override bool Roars()
        {
            return true;
        }

        public override int HaveBabies()
        {
            return 3;
        }

        public string Swim()
        {
            return "Cooling off";
        }
    }
}
