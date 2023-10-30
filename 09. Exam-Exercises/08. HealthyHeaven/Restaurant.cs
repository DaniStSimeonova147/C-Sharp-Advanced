using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
   public class Restaurant
    {
        private List<Salad> data;

       
        public string Name { get; set; }

        public Restaurant(string name)
        {
            this.Name = name;

            data = new List<Salad>();

        }

            public void Add(Salad salad)
        {
            this.data.Add(salad);
        }
        public bool Buy(string name)
        {
            bool check = true;

            if (data.FirstOrDefault(n => n.Name == name) != null)
            {
                data.Remove(data.FirstOrDefault(n => n.Name == name));
            }
            else
            {
                check = false;
            }

            return check;
        }

        public Salad GetHealthiestSalad()
        {
            int min = this.data.Min(s => s.GetTotalCalories());

            return this.data.FirstOrDefault(s => s.GetTotalCalories() == min);
        }

        public string GenerateMenu()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{Name} have {data.Count} salads:");
            foreach (var salad in data)
            {
                result.AppendLine(salad.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
