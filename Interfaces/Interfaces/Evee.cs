using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Interfaces.PokemonZoo.cs;

namespace Interfaces
{
    class Evee : Pokeman, IStartingPokemon
    {
        GivenPokemon()
        {
          return Console.WriteLine("gary");
        }

        public string GivenPokemon()
        {
            throw new NotImplementedException();
        }
    }
}
