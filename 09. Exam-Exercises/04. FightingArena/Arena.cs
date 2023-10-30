using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    class Arena
    {
        private List<Gladiator> gladiators;

        public string Name { get; set; }

        public int Count
        {
            get
            {
                return this.gladiators.Count;
            }
        }

        public Arena(string name)
        {
            this.Name = name;

            this.gladiators = new List<Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }
        public void Remove(string name)
        {
            if (gladiators.FirstOrDefault(n => n.Name == name) != null)
            {
                gladiators.Remove(gladiators.FirstOrDefault(n => n.Name == name));
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            int max = gladiators.Max(x => x.GetStatPower());

            return gladiators.FirstOrDefault(x => x.GetStatPower() == max);
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            int max = gladiators.Max(x => x.GetWeaponPower());

            return gladiators.FirstOrDefault(x => x.GetWeaponPower() == max);
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            int max = gladiators.Max(x => x.GetTotalPower());

            return gladiators.FirstOrDefault(x => x.GetTotalPower() == max);
        }

        public override string ToString()
        {
            string result = $"{Name} - {Count} gladiators are participating.";

            return result;
        }
    }
}
