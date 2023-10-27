using System;
using System.Collections.Generic;
using System.Text;

namespace E04.GenericSwapMethodIntegers
{
    class Box<Titem>
    {
        List<Titem> items = new List<Titem>();

        public Box()
        {
            items = new List<Titem>();
        }

        public void Add(Titem item)
        {
            items.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex <0 || secondIndex < 0 || firstIndex > items.Count || secondIndex > items.Count)
            {
                throw new IndexOutOfRangeException();
            }

            Titem currentItem = items[firstIndex];

            items[firstIndex] = items[secondIndex];
            items[secondIndex] = currentItem;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
                
            }

            return sb.ToString().TrimEnd();
        }
    }
}
