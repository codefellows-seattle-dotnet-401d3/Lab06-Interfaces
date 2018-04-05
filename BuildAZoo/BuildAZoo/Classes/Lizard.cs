﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Lizard : Reptile
    {
        public override int NumberOfLegs { get; set; } = 4;
        public override bool Carnivore { get; set; } = true;

    }
}
