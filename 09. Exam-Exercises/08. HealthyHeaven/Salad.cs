using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> products;

        public string Name { get; set; }

      
        public Salad(string name)
        {
            this.Name = name;
            this.products = new List<Vegetable>();
        }
        public int GetTotalCalories()
        {
           // int cal = products.Sum(x => x.Calories);

            int calories = 0;
            foreach (var product in products)
            {
                calories += product.Calories;
            }
            return calories;
        }

        public int GetProductCount()
        {
            int count = this.products.Count;
            return count;
        }

        public void Add(Vegetable product)
        {
            this.products.Add(product);
        }

        public override string ToString()
        {
            //   "* Salad {name} is {calories} calories and have {product count} products:
            //   { Vegetable 1}
            //   { Vegetable 2}
            //   { Vegetable 3}

            StringBuilder result = new StringBuilder();

            result.AppendLine($"* Salad {this.Name} is {this.GetTotalCalories()} calories and have {this.GetProductCount()} products:");

            foreach (var product in this.products)
            {
                result.AppendLine(product.ToString());
            }

            return result.ToString().TrimEnd();
        }

    }
}
