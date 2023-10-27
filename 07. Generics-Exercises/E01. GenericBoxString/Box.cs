using System;
using System.Collections.Generic;
using System.Text;

namespace E01.GenericBoxString
{
     public class Box<Titem>
    {
        List<Titem> result = new List<Titem>();

        public Box()
        {
            result = new List<Titem>();
        }

        public void Add(Titem item)
        {
            result.Add(item);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var currentText in result)
            {

                stringBuilder.AppendLine($"{currentText.GetType().FullName}: {currentText}");
            }


            return stringBuilder.ToString();
        }
    }
}
