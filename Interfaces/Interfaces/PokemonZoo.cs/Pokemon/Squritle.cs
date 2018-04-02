using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Interfaces.PokemonZoo.cs;

namespace PokemonZoo.cs
{
    class Squritle: Watertype, IStartingPokemon
    {
        public override string Attack { get; set; } = "water gun";
        public override string Name { get; set; } = "Bulbasur";
        public override int Health { get; set; } = 50;

        public string GivenPokemon()
        {
            return "Professor gary gave Ash a squirtle!";
        }
    }
}
