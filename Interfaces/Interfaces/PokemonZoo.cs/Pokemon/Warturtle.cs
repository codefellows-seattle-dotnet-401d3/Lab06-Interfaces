using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Interfaces.PokemonZoo.cs;

namespace PokemonZoo.cs
{
    class Warturtle : Watertype, ISwiftAttack
    {
        public override string Attack { get; set; } = "Water Cannon";
        public override string Name { get; set; } = "Warturtle";
        public override int Health { get; set; } = 100;

        public override string BubbleAttack()
        {
            return "Shoots water";
        }

        public string SwfiftAttack()
        {
            return " Warturtle dodges the enemy";
        }
    }
}
