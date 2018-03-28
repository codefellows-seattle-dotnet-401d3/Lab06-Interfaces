using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    class Penguin : Avian, Interfaces.ISwim
    {
        public override int NumberOfLegs { get; set; } = 2;
        public override bool Carnivore { get; set; } = true;
        public override bool HasWings { get; set; } = true;
        public string Name { get; set; } = "penguin";

        public override string Eat()
        {
            return "Eating fish";
        }

        public override string Sleep()
        {
            return "ZZZZZZZZ";
        }

        public override string Caws()
        {
            return "Squawk";
        }

        public override bool CanFly()
        {
            return false;
        }

        public string Swim()
        {
            return "Diving deep looking for food";
        }
    }
}
