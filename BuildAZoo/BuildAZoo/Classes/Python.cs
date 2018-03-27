﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    class Python : Snake
    {
        public string Name { get; set; } = "python";

        public override string Eat()
        {
            return "Eating small rodents";
        }

        public override string Sleep()
        {
            return "SSSSSS ZZZZZZZ SSSSSSS ZZZZZZ";
        }

        public override bool Slither()
        {
            return true;
        }

        public override bool LayEggs()
        {
            return true;
        }

        public override string Hisses()
        {
            return "HHHHHHIIIIIIISSSSSSSSSSSSSSSSSSSSSS";
        }
    }
}
