using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHeaven
{
   public  class Vegetable
    {
        public string Name { get; set; }

        public int Calories { get; set; }

        public Vegetable(string name, int calories)
        {
            this.Name = name;
            this.Calories = calories;
        }

        public override string ToString()
        {
            string result = $" - {Name} have {Calories} calories";

            return result;
        }
    }
}
