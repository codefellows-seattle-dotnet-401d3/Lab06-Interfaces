using System;
using Xunit;
using BuildAZoo;
using static BuildAZoo.Program;

namespace ZooTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateLion()
        {
            BuildAZoo.Classes.Lion leon = new BuildAZoo.Classes.Lion();

            Assert.True(leon is BuildAZoo.Classes.Lion);
        }
    }
}
