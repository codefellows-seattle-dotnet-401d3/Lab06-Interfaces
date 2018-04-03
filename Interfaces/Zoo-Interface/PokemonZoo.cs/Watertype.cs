using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonZoo.cs
{
    abstract class Watertype : Pokemon, ICatchable
    {
        //Properties for water type Pokemon
        public override string Weakness { get; set; } = "Plants";
        

        //methods for water type Pokemon
        public virtual string BubbleAttack()
        {
            Console.WriteLine("shoots bubbles");
            return "Shoots bubbles";
        }

        public string Catch()
        {
            Console.WriteLine("This Water Type Pokemon is Catchable");
            return "yes";
        }

        public virtual string Tackle()
        {
            Console.WriteLine("Tackel ATtack Go!");
            return "Tackle Atack Go!";
        }

    }
}
