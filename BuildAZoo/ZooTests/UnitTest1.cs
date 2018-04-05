using System;
using Xunit;
using BuildAZoo;
using static BuildAZoo.Program;
using BuildAZoo.Classes;
using BuildAZoo.Interfaces;

namespace ZooTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateWater()
        {
            Water river = new Water();

            Assert.NotNull(river);
        }

        [Fact]
        public void LionCanUseISwim()
        {
            Lion leon = new Lion();

            Assert.IsAssignableFrom<ISwim>(leon);
        }

        [Fact]
        public void PenguinCanUseISwim()
        {
            Penguin perry = new Penguin();

            Assert.IsAssignableFrom<ISwim>(perry);
        }

        [Fact]
        public void DuckCanUseISwim()
        {
            Duck daffy = new Duck();

            Assert.IsAssignableFrom<ISwim>(daffy);
        }

        [Fact]
        public void EagleCanUseIFly()
        {
            Eagle ernie = new Eagle();

            Assert.IsAssignableFrom<IFly>(ernie);
        }

        [Fact]
        public void DuckCanUseIFly()
        {
            Duck daffy = new Duck();

            Assert.IsAssignableFrom<IFly>(daffy);
        }

    }
}
