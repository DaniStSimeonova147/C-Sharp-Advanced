using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    class Gladiator
    {
        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }


        //•	GetTotalPower() : int – return the sum of the stat properties plus the sum of the weapon properties.
        //•	GetWeaponPower() : int - return the sum of the weapon properties.
        // •GetStatPower(): int - return the sum of the stat properties.

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public int GetTotalPower()
        {
            int weaponPower = Weapon.Size + Weapon.Sharpness + Weapon.Solidity;
            int statPower = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            int totalPower = weaponPower + statPower;
            return totalPower;
        }

        public int GetWeaponPower()
        {
            int weaponPower = Weapon.Size + Weapon.Sharpness + Weapon.Solidity;
            return weaponPower;
        }

        public int GetStatPower()
        {
            int statPower = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            return statPower;
        }

        //        "[Gladiator name] - [Gladiator total power]"
        //"  Weapon Power: [Gladiator weapon power]"
        //"  Stat Power: [Gladiator stat power]"

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{Name} - {GetTotalPower()}");
            result.AppendLine($"  Weapon Power: {GetWeaponPower()}");
            result.AppendLine($"  Stat Power: {GetStatPower()}");

            return result.ToString().TrimEnd();
        }
     
    }
}
