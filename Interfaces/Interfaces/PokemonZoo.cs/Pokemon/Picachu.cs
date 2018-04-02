using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Interfaces.PokemonZoo.cs;

namespace PokemonZoo.cs.NewFolder
{
    class Picachu :Pokemon, ISwiftAttack
    {
        public override string Name { get; set; } = "picahu";
        public override int Health { get; set; } = 100;
        public override string Attack { get; set; } = "shock";
        public override string Weakness { get; set; } = "ASh KEtchup";

        public string SwfiftAttack()
        {
            return "Picachu dodges enemy";
        }
    }
}
