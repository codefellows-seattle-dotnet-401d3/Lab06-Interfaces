using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs.NewFolder
{
  class Bulbasuar : Planttype , ICatchable, IProfessorGary
    {
        //bulbasusar is the concrete level
        public override string Attack { get; set; } = "Water Cannon";
        public override string Name { get; set; } = "bulbasuar";
        public override int Health { get; set; } = 100;

        public string Original()
        {
            Console.WriteLine("Professor Gary Gave Ash this Starting Pokemon");
            return "yes";
        }
    }
}
