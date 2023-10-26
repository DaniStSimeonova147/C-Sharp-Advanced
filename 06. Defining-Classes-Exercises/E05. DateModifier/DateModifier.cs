using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static void DateDifference (string firstDate, string secondDate)
        {
            int[] firstDateInput = firstDate.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondDateInput= secondDate.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            DateTime firstDateInfo = new DateTime(firstDateInput[0], firstDateInput[1], firstDateInput[2]);

            DateTime secondDateInfo = new DateTime(secondDateInput[0], secondDateInput[1], secondDateInput[2]);

            TimeSpan difference = firstDateInfo.Subtract(secondDateInfo);

            Console.WriteLine(Math.Abs(difference.TotalDays));

        }
    }
}
