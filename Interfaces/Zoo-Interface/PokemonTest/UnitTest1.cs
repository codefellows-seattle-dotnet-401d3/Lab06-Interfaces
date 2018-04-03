using System;
using Xunit;
using PokemonZoo.cs;

namespace PokemonTest
{
    public class UnitTest1
    {
        [Fact]
        public void MakeWarTurtle()
        {
            Warturtle warturtle = new Warturtle();
            Assert.Equal(100, warturtle.Health);
        }

        [Fact]
        public void MakeSquritle()
        {
            Squritle squritle = new Squritle();
            Assert.Equal(50, squritle.Health);
        }

        [Fact]
        public void CheckAttack()
        {
            Squritle squritle = new Squritle();
            Assert.Equal("Plants", squritle.Weakness);
        }

        [Fact]
        public void MakeCharzoid()
        {
            Charizoid charizoid = new Charizoid();
            Assert.Equal(500, charizoid.Health);
        }

        [Fact]
        public void CheckCharzoidAttack()
        {
            Charizoid charizoid = new Charizoid();
            Assert.Equal("Flame Thrower", charizoid.Attack);
        }

    }    
}
