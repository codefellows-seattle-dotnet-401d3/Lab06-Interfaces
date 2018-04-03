using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
   abstract class Planttype : Pokemon, ICatchable
    {
        public override string Attack { get; set; } = "Vine Whip";
        public override int Health { get; set; } = 200;
        public override string Weakness { get; set; } = "fire";

        public string Catch()
        {
            Console.WriteLine($"This Plant type Pokemon is Catchable");
            return "yes";
        }
    }
}
