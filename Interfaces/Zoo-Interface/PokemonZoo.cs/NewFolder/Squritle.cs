using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    class Squritle: Watertype , IProfessorGary
    {
        public override string Attack { get; set; } = "water gun";
        public override string Name { get; set; } = "Squritle";
        public override int Health { get; set; } = 50;

        public string Original()
        {
            Console.WriteLine("Professor Gary Gave Ash this Pokemon");
            return "yes";
        }
    }
}
