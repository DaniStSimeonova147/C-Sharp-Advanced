﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    class Stat
    {
        //        •	Strength: int
        //•	Flexibility: int
        //•	Agility: int
        //•	Skills: int
        //•	Intelligence: int

        public int Strength { get; set; }

        public int Flexibility { get; set; }

        public int Agility { get; set; }

        public int Skills { get; set; }

        public int Intelligence { get; set; }

        public Stat(int strength, int flexibility, int agility, int  skills, int intelligence)
        {
            this.Strength = strength;
            this.Flexibility = flexibility;
            this.Agility = agility;
            this.Skills = skills;
            this.Intelligence = intelligence;
        }

    }
}
