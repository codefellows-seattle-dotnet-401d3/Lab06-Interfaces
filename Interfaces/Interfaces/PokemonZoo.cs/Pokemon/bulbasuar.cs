using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Interfaces.PokemonZoo.cs;

namespace PokemonZoo.cs.NewFolder
{
    class bulbasuar : Planttype, IStartingPokemon , ISwiftAttack
    {
        //bulbasusar is the concrete level
        public override string Attack { get; set; } = "Water Cannon";
        public override string Name { get; set; } = "Warturtle";
        public override int Health { get; set; } = 100;

        public string GivenPokemon()
        {
            return "Professor Gary Gave ash a Bulbasaur";
        }

        public string SwfiftAttack()
        {
            return"Bulbasur dodges the enemy";
        }
    }
}
