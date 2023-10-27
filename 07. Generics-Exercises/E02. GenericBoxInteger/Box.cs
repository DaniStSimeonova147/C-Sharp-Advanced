using System;
using System.Collections.Generic;
using System.Text;

namespace E02.GenericBoxInteger
{
    public class Box<Titem>
    {
        List<Titem> items = new List<Titem>();

        public Box()
        {
            items = new List<Titem>();
        }

        public void Add(Titem currentItem)
        {
            items.Add(currentItem);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in items)
            {

                stringBuilder.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return stringBuilder.ToString();
        }
    }
}
