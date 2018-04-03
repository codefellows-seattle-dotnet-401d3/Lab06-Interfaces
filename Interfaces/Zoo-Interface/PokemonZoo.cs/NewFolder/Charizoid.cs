using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    public class Charizoid :Firetype, ICatchable
    {
        public override string Attack { get; set; } = "Flame Thrower";
        public override string Name { get; set; } = "Charizoid";
        public override int Health { get; set; } = 500;

        public override string CanEvolve()
        {
            Console.WriteLine("Charizoid is already Evolved");
            return "Evolved";
        }

        public string Catch()
        {
            Console.WriteLine("this Pokemon is catchable");
            return " this Pokemon is catchable";
        }
    }
}

