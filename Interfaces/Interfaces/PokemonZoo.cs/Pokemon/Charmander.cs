using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Interfaces.PokemonZoo.cs;

namespace PokemonZoo.cs
{
    class Charmander : Firetype, IStartingPokemon
    {
        public override string Attack { get; set; } = "Flame Spit";
        public override string Name { get; set; } = "Charmander";
        public override int Health { get; set; } = 100;

        public string GivenPokemon()
        {
            return "Professor Gary gave Ash a Charmander";
        }
    }
}
