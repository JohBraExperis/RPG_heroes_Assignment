﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_heroes.Heroes.Attributes
{
    public class HeroAttributes
    {

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public int StrengthGain { get; set; }
        public int DexterityGain { get; set; }
        public int IntelligenceGain { get; set; }

        public HeroAttributes(int strength, int dexterity, int intelligence) {

            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;

        }

    }
}
